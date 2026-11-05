using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sport_Room
{
    public partial class addBorrowers : Form
    {
        public addBorrowers()
        {
            InitializeComponent();
        }

        private async void addBorrowers_Load(object sender, EventArgs e)
        {
            using (var db = new SportRoomContext())
            {
                var items = await db.Departments.Select(dep => new { dep.Id, dep.Name }).ToListAsync();

                // These MUST match the property names exactly as they are written in the Select statement above
                departmentComboBox.DisplayMember = "Name";
                departmentComboBox.ValueMember = "Id";
                departmentComboBox.DataSource = items;

                var equipments = await db.Equipments.Select(eq => new { eq.Id, eq.Name }).ToListAsync();

                // 1. Cast the column specifically to a ComboBox column
                DataGridViewComboBoxColumn comboColumn = (DataGridViewComboBoxColumn)borrowingList.Columns["EquipmentName"];

                // 2. CRITICAL FIX: Bind the actual list of data to the column
                comboColumn.DataSource = equipments;

                // 3. Map the properties correctly
                comboColumn.DisplayMember = "Name";
                comboColumn.ValueMember = "Id";
                comboColumn.DataPropertyName = "EquipmentId";

                // --- Auto-Fill existing Borrowers ---

                // 1. Fetch all existing Borrower IDs from the database
                var existingIds = await db.Borrowers.Select(b => b.BorrowerId).ToArrayAsync();

                // 2. Create an auto-complete collection
                AutoCompleteStringCollection idCollection = new AutoCompleteStringCollection();
                idCollection.AddRange(existingIds);

                // 3. Attach it to your brrId text box
                brrId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                brrId.AutoCompleteSource = AutoCompleteSource.CustomSource;
                brrId.AutoCompleteCustomSource = idCollection;
            }

            // Bind defaults for the datagridview
            borrowingList.DefaultValuesNeeded += borrowingList_DefaultValuesNeeded;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            // 1. Check for missing Department
            if (departmentComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a department from the dropdown list to continue.",
                                "Department Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Check for missing Role
            if (string.IsNullOrWhiteSpace(brrRoleCombobox.Text))
            {
                MessageBox.Show("Please select a user role (Student or Staff) before proceeding.",
                                "Role Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string depId = departmentComboBox.SelectedValue.ToString();
            string studentId = brrId.Text.Trim();
            string borrowerName = brrName.Text.Trim();
            string phoneNum = phoneNumber.Text.Trim();

            // 3. User-friendly Student ID validation
            if (string.IsNullOrWhiteSpace(studentId) && brrRoleCombobox.Text == "Student")
            {
                MessageBox.Show("A Student ID is mandatory when registering a student. Please enter a valid ID to proceed.",
                                "Missing Student ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 4. Validate Name
            if (string.IsNullOrWhiteSpace(borrowerName))
            {
                MessageBox.Show("The borrower's name cannot be empty. Please enter their full name.",
                                "Name Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 5. Validate Phone Number
            if (string.IsNullOrWhiteSpace(phoneNum))
            {
                MessageBox.Show("A contact phone number is mandatory for accountability. Please enter a valid phone number.",
                                "Phone Number Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Email is deliberately ignored here so it remains optional!

            using (var db = new SportRoomContext())
            {
                // 1. Check if the borrower already exists in the database
                Borrower currentBorrower = await db.Borrowers.FirstOrDefaultAsync(b => b.BorrowerId == studentId);

                // 2. If they don't exist, create them as a brand new borrower
                if (currentBorrower == null)
                {
                    currentBorrower = new Borrower(brrRoleCombobox.Text, studentId)
                    {
                        Name = brrName.Text,
                        Email = email.Text,
                        PhoneNumber = phoneNumber.Text,
                        DepartmentId = depId
                    };
                }
                else
                {
                    // Optional: Update their info just in case they changed their phone number/email
                    currentBorrower.Name = brrName.Text;
                    currentBorrower.Email = email.Text;
                    currentBorrower.PhoneNumber = phoneNumber.Text;
                    currentBorrower.DepartmentId = depId;
                }

                // 3. Link the correct borrower to the receipt and assign the Global Dates!
                BorrowReceipt newReceipt = new BorrowReceipt
                {
                    Borrower = currentBorrower,
                    IssuedDate = issueDatepicker.Value,
                    DueDate = dueDatepicker.Value,
                    BorrowedCombinations = new List<BorrowedCombination>()
                };

                // Calculate initial status based on the selected dates
                newReceipt.UpdateStatus();

                // Dictionaries to track the TOTAL requested quantities and names for validation
                Dictionary<string, int> equipmentDemands = new Dictionary<string, int>();
                Dictionary<string, string> equipmentNames = new Dictionary<string, string>();

                // --- STEP 1: PARSE GRID & AGGREGATE DEMAND ---
                foreach (DataGridViewRow row in borrowingList.Rows)
                {
                    if (row.IsNewRow) continue;

                    var equipmentCell = row.Cells["EquipmentName"].Value;
                    var brokenQtyCell = row.Cells["BrokenQty"].Value;
                    var qtyCell = row.Cells["Qty"].Value;

                    // ENFORCEMENT: Check that ALL required cells in this row are filled
                    if (equipmentCell == null || string.IsNullOrWhiteSpace(equipmentCell.ToString()) ||
                        brokenQtyCell == null || string.IsNullOrWhiteSpace(brokenQtyCell.ToString()) ||
                        qtyCell == null || string.IsNullOrWhiteSpace(qtyCell.ToString()))
                    {
                        continue; // skip complete empty rows
                    }

                    string eqId = equipmentCell.ToString();
                    string eqName = row.Cells["EquipmentName"].FormattedValue?.ToString() ?? "Unknown Equipment";

                    // 1. Safely parse the required Quantity
                    if (!int.TryParse(qtyCell.ToString(), out int qty))
                    {
                        MessageBox.Show($"Row {row.Index + 1} has an invalid Quantity. Please enter numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Abort the save process completely so the user can fix it
                    }

                    // 2. Safely parse the optional Broken Quantity
                    int bqty = 0;
                    if (brokenQtyCell != null && !string.IsNullOrWhiteSpace(brokenQtyCell.ToString()))
                    {
                        if (!int.TryParse(brokenQtyCell.ToString(), out bqty))
                        {
                            MessageBox.Show($"Row {row.Index + 1} has an invalid Broken Quantity. Please enter numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Add combination to receipt
                    newReceipt.BorrowedCombinations.Add(new BorrowedCombination
                    {
                        ReceiptId = newReceipt.ReceiptId,
                        EquipmentId = eqId,
                        Qty = qty,
                        BrokenQty = bqty,
                        ReturnedQuantity = 0
                    });

                    // Aggregate the quantities for the stock check
                    if (equipmentDemands.ContainsKey(eqId))
                    {
                        equipmentDemands[eqId] += qty;
                    }
                    else
                    {
                        equipmentDemands[eqId] = qty;
                        equipmentNames[eqId] = eqName;
                    }
                }

                if (newReceipt.BorrowedCombinations.Count == 0)
                {
                    MessageBox.Show("Please add at least one valid item to the borrowing list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- STEP 2: BATCH STOCK VERIFICATION ---
                List<string> outOfStockErrors = new List<string>();

                foreach (var demand in equipmentDemands)
                {
                    string eqId = demand.Key;
                    int requestedQty = demand.Value;

                    var equipment = await db.Equipments.FirstOrDefaultAsync(eq => eq.Id == eqId);

                    if (equipment != null)
                    {
                        if (requestedQty > equipment.Quantity)
                        {
                            // Insufficient stock: Add to error list
                            outOfStockErrors.Add($"• {equipmentNames[eqId]}: Requested {requestedQty}, Available {equipment.Quantity}");
                        }
                        else
                        {
                            // Sufficient stock: Deduct it in memory
                            equipment.Quantity -= requestedQty;
                        }
                    }
                }

                // If any equipment failed the check, show the combined error message and abort
                if (outOfStockErrors.Count > 0)
                {
                    MessageBox.Show("Cannot proceed. The following items do not have enough stock:\n\n" +
                                    string.Join("\n", outOfStockErrors),
                                    "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Aborts the method. The database remains completely untouched.
                }

                // --- STEP 3: SAFE EXECUTION ---
                db.BorrowReceipts.Add(newReceipt);
                await db.SaveChangesAsync();

                MessageBox.Show("Borrower and valid rows saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void borrowingList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // 1. Check if the control about to be shown is a ComboBox
            if (e.Control is ComboBox combo)
            {
                // 2. Make sure we are in the correct column ("Name")
                if (borrowingList.CurrentCell.OwningColumn.Name == "EquipmentName")
                {
                    // 3. Change it to allow typing!
                    combo.DropDownStyle = ComboBoxStyle.DropDown;

                    // OPTIONAL BUT HIGHLY RECOMMENDED:
                    // Turn on AutoComplete so it suggests equipment names as they type
                    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
        }

        private async void brrId_Leave(object sender, EventArgs e)
        {
            string searchId = brrId.Text.Trim();

            // If the box is empty, do nothing
            if (string.IsNullOrEmpty(searchId)) return;

            using (var db = new SportRoomContext())
            {
                // Check if this ID already exists in the database
                var existingBorrower = await db.Borrowers.FirstOrDefaultAsync(b => b.BorrowerId == searchId);

                // If we found them, auto-fill all the fields!
                if (existingBorrower != null)
                {
                    // The ?? "" safely handles null database values so your text boxes don't crash
                    brrName.Text = existingBorrower.Name ?? "";
                    email.Text = existingBorrower.Email ?? "";
                    phoneNumber.Text = existingBorrower.PhoneNumber ?? "";

                    // Safely set the role dropdown
                    if (!string.IsNullOrEmpty(existingBorrower.Role))
                    {
                        brrRoleCombobox.Text = existingBorrower.Role;
                    }

                    // Safely set the department dropdown
                    if (existingBorrower.DepartmentId != null)
                    {
                        departmentComboBox.SelectedValue = existingBorrower.DepartmentId;
                    }
                }
            }
        }

        private void borrowingList_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Make sure these column names exactly match the (Name) property of your columns in the designer
            e.Row.Cells["Qty"].Value = 0;
            e.Row.Cells["BrokenQty"].Value = 0;
        }
    }
}