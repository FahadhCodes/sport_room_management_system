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
    public partial class BorrowerForm : Form
    {
        private DateTimePicker returnPicker = new DateTimePicker();
        private string currentReceiptIdForReturn = "";
        public BorrowerForm()
        {
            InitializeComponent();
        }

        private async void BorrowerForm_Load(object sender, EventArgs e)
        {
            returnPicker.Visible = false;
            returnPicker.Format = DateTimePickerFormat.Custom;
            returnPicker.CustomFormat = "dd/MM/yyyy hh:mm tt";

            returnPicker.Leave += ReturnPicker_SaveAndHide;
            returnPicker.CloseUp += ReturnPicker_SaveAndHide;

            // Attach to the main form
            this.Controls.Add(returnPicker);

            // --- ADD THESE TWO LINES TO MAKE IT BULLETPROOF WITH TABLELAYOUTPANEL ---
            this.Resize += (s, ev) => returnPicker.Visible = false;
            reciptsData.Scroll += (s, ev) => returnPicker.Visible = false;
            // ------------------------------------------------------------------------

            await RefreshBorrowerList();
            await UpdateBorrowerSummary();
        }
        private async void ReturnPicker_SaveAndHide(object sender, EventArgs e)
        {
            if (!returnPicker.Visible) return;

            // 1. Hide the picker instantly
            returnPicker.Visible = false;

            try
            {
                // 2. Save the new date AND Restock the inventory
                using (var db = new SportRoomContext())
            {
                // Fetch the receipt AND its associated equipment items
                var receipt = await db.BorrowReceipts
                    .Include(r => r.BorrowedCombinations)
                    .FirstOrDefaultAsync(r => r.ReceiptId == currentReceiptIdForReturn);

                // Make sure we don't accidentally restock twice if it was already marked returned!
                if (receipt != null && receipt.ReturnedDate == null)
                {
                    receipt.ReturnedDate = returnPicker.Value;
                    receipt.UpdateStatus();

                    // RESTOCK INVENTORY: Add the items back to the master equipment shelf
                    foreach (var combo in receipt.BorrowedCombinations)
                    {
                        var equipment = await db.Equipments.FindAsync(combo.EquipmentId);
                        if (equipment != null)
                        {
                            int broken = Math.Max(0, combo.BrokenQty);
                            int healthy = Math.Max(0, combo.Qty - broken);
                            equipment.Quantity += healthy; // Put healthy units back on the shelf
                            equipment.BrokenQty += broken; // Add damaged units to broken inventory
                        }
                        combo.ReturnedQuantity = combo.Qty;
                    }
                    await db.SaveChangesAsync();
                }
            }

            // 3. Refresh the UI so the grids and labels update
                await UpdateBorrowerSummary(brrName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing return: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            addBorrowers frm = new addBorrowers();
            frm.ShowDialog();

            await RefreshBorrowerList();
            await UpdateBorrowerSummary(null); // Refresh the current summary
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            manageBorrower frm2 = new manageBorrower(brrId.Text);

            // The code pauses here while the user edits the information
            frm2.ShowDialog();

            // The instant the manageBorrower window closes, this line runs 
            // and refreshes all the tables and labels for the current person!
            await UpdateBorrowerSummary(brrName.Text);
        }

        // 1. Dedicated method to just refresh the left-side Unique Borrower List
        private async Task RefreshBorrowerList()
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    var borrowerList = await db.Borrowers
                        .Select(val => val.Name)
                        .Distinct() // Forces unique names
                        .Select(name => new { borrnames = name })
                        .ToListAsync();

                    borrList.AutoGenerateColumns = false;
                    borrList.DataSource = borrowerList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Borrowers");
            }
        }

        private async Task UpdateBorrowerSummary(string searchName = null)
        {
            try
            {
                using (var db = new SportRoomContext())
            {
                Borrower targetBorrower = null;

                if (string.IsNullOrEmpty(searchName))
                {
                    var latestReceipt = await db.BorrowReceipts
                        .Include(r => r.Borrower)
                            .ThenInclude(b => b.Department)
                        .OrderByDescending(r => r.IssuedDate)
                        .FirstOrDefaultAsync();

                    if (latestReceipt != null)
                        targetBorrower = latestReceipt.Borrower;
                }
                else
                {
                    targetBorrower = await db.Borrowers
                        .Include(b => b.Department)
                        .FirstOrDefaultAsync(b => b.Name == searchName);
                }

                if (targetBorrower != null)
                {
                    brrName.Text = targetBorrower.Name;
                    brrId.Text = targetBorrower.BorrowerId;
                    brrRole.Text = targetBorrower.Role;
                    brrEmail.Text = targetBorrower.Email;
                    brrPhoneNumber.Text = targetBorrower.PhoneNumber;

                    string deptName = targetBorrower.Department?.Name;
                    if (string.IsNullOrEmpty(deptName) && !string.IsNullOrEmpty(targetBorrower.DepartmentId))
                    {
                        var dept = await db.Departments.FirstOrDefaultAsync(d => d.Id == targetBorrower.DepartmentId);
                        deptName = dept?.Name;
                    }
                    brrDept.Text = deptName ?? targetBorrower.DepartmentId ?? "";

                    int pendingItems = await db.BorrowedCombinations
                        .Where(c => c.BorrowReceipt.BorrowerId == targetBorrower.BorrowerId && c.BorrowReceipt.ReturnedDate == null)
                        .SumAsync(c => (int?)c.Qty) ?? 0;

                    ItemsToReturn.Text = pendingItems.ToString();

                    // Populate the Receipts DataGridView
                    // Inside UpdateBorrowerSummary, update this specific block:
                    var receipts = await db.BorrowReceipts
                        .Where(r => r.BorrowerId == targetBorrower.BorrowerId)
                        .OrderByDescending(r => r.IssuedDate)
                        .Select(r => new ReceiptCheckItem
                        {
                            recipts = r.ReceiptId,
                            Returned = r.ReturnedDate.HasValue
                        })
                        .ToListAsync();

                    reciptsData.AutoGenerateColumns = false;
                    reciptsData.DataSource = receipts;

                    // Load the main grid
                    var filteredReceipts = await db.BorrowedCombinations
                        .Where(val => val.BorrowReceipt.BorrowerId == targetBorrower.BorrowerId)
                        .Select(val => new
                        {
                            BorrowReceipt = val.BorrowReceipt.ReceiptId,
                            borrName = val.BorrowReceipt.Borrower.Name,
                            borrowedItems = val.Equipment.Name, // <--- FIX: Added missing mapping
                            Qty = val.Qty,
                            IssuedDate = val.BorrowReceipt.IssuedDate,
                            DueDate = val.BorrowReceipt.DueDate,
                            ReturnedDate = val.BorrowReceipt.ReturnedDate,
                            status = val.BorrowReceipt.ReturnedDate.HasValue
                                ? (val.BorrowReceipt.ReturnedDate.Value <= val.BorrowReceipt.DueDate ? "Returned" : "Returned Late")
                                : (DateTime.Now > val.BorrowReceipt.DueDate ? "Overdue" : "Borrowed")
                        }).ToListAsync();

                    borrowerInfoTB.AutoGenerateColumns = false;
                    borrowerInfoTB.DataSource = filteredReceipts;
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrower summary: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Helper Method to fetch equipment for a specific Receipt ID
        private async Task LoadReceiptDetails(string receiptId)
        {
            try
            {
                using (var db = new SportRoomContext())
            {
                var filteredReceipts = await db.BorrowedCombinations
                    .Include(c => c.Equipment)
                    .Where(val => val.ReceiptId == receiptId)
                    .Select(val => new
                    {
                        BorrowReceipt = val.BorrowReceipt.ReceiptId, // Kept for the double-click logic
                        borrName = val.BorrowReceipt.Borrower.Name,
                        borrowedItems = val.Equipment.Name,          // Maps to your new Equipment Name column
                        Qty = val.Qty,
                        IssuedDate = val.BorrowReceipt.IssuedDate,
                        DueDate = val.BorrowReceipt.DueDate,
                        ReturnedDate = val.BorrowReceipt.ReturnedDate,
                        status = val.BorrowReceipt.ReturnedDate.HasValue
                            ? (val.BorrowReceipt.ReturnedDate.Value <= val.BorrowReceipt.DueDate ? "Returned" : "Returned Late")
                            : (DateTime.Now > val.BorrowReceipt.DueDate ? "Overdue" : "Borrowed")
                    }).ToListAsync();

                borrowerInfoTB.AutoGenerateColumns = false;
                borrowerInfoTB.DataSource = filteredReceipts;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading receipt details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Click event for the Borrower List
        private async void borrList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cellValue = borrList.Rows[e.RowIndex].Cells[0].Value;

            if (cellValue != null)
            {
                string selectedName = cellValue.ToString();
                await UpdateBorrowerSummary(selectedName);

            }
        }

        // 5. Click event for the Receipts List (Selects the row)
        private async void reciptsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // FIX: NEVER use Cells[0]! Always use the exact column name so it doesn't break if you move columns.
            var cellValue = reciptsData.Rows[e.RowIndex].Cells["recipts"].Value;

            if (cellValue != null)
            {
                string receiptId = cellValue.ToString();
                await LoadReceiptDetails(receiptId);
            }
        }

        // 6. Modified Return Date Logic (Updates the receipt, refreshes summary)
        private async void borrowerInfoTB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = borrowerInfoTB.Columns[e.ColumnIndex].Name;

            if (columnName == "ReturnedDate")
            {
                // Grabs the hidden ReceiptId from the row
                var cellValue = borrowerInfoTB.Rows[e.RowIndex].Cells["BorrowReceipt"].Value;
                if (cellValue == null) return;

                string receiptId = cellValue.ToString();

                ReturnInspectionDialog dialog = new ReturnInspectionDialog(receiptId);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    await UpdateBorrowerSummary(brrName.Text);
                }
            }
        }

        // 7. Left List Search Filter
        private async void borrSearchFromList_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    string searchText = borrSearchFromList.Text.Trim().ToLower();

                    var query = db.Borrowers.AsQueryable();
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query = query.Where(b => b.Name != null && b.Name.ToLower().Contains(searchText));
                    }

                    var borrowerList = await query
                        .Select(b => b.Name)
                        .Distinct()
                        .Select(name => new { borrnames = name })
                        .ToListAsync();

                    borrList.DataSource = borrowerList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching borrower list: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 8. Main Grid Global Search Filter
        private async void brrSearchfromData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    string searchText = brrSearchfromData.Text.Trim().ToLower();
                    var query = db.BorrowedCombinations.AsNoTracking().AsQueryable();

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query = query.Where(v =>
                            (v.Equipment != null && v.Equipment.Name != null && v.Equipment.Name.ToLower().Contains(searchText)) ||
                            (v.BorrowReceipt != null && v.BorrowReceipt.Borrower != null && v.BorrowReceipt.Borrower.Name != null && v.BorrowReceipt.Borrower.Name.ToLower().Contains(searchText)) ||
                            (v.BorrowReceipt != null && v.BorrowReceipt.ReceiptId != null && v.BorrowReceipt.ReceiptId.ToLower().Contains(searchText)));
                    }

                    var filteredData = await query.Select(val => new
                    {
                        BorrowReceipt = val.BorrowReceipt.ReceiptId,
                        borrName = val.BorrowReceipt.Borrower.Name,
                        borrowedItems = val.Equipment.Name,
                        Qty = val.Qty,
                        IssuedDate = val.BorrowReceipt.IssuedDate,
                        DueDate = val.BorrowReceipt.DueDate,
                        ReturnedDate = val.BorrowReceipt.ReturnedDate,
                        status = val.BorrowReceipt.ReturnedDate.HasValue
                            ? (val.BorrowReceipt.ReturnedDate.Value <= val.BorrowReceipt.DueDate ? "Returned" : "Returned Late")
                            : (DateTime.Now > val.BorrowReceipt.DueDate ? "Overdue" : "Borrowed")
                    }).ToListAsync();

                    // ADD THIS LINE TO PREVENT GHOST COLUMNS DURING SEARCH:
                    borrowerInfoTB.AutoGenerateColumns = false;

                    borrowerInfoTB.DataSource = filteredData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching borrowed records: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 9. Main Grid Date Filter
        private async void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    var query = db.BorrowedCombinations.AsNoTracking().AsQueryable();

                    DateTime sDate = startDate.Value.Date;
                    DateTime eDate = endDate.Value.Date.AddDays(1).AddTicks(-1);
                    string filterType = filterableDates.Text;

                    if (filterType == "Issued Date")
                    {
                        query = query.Where(v => v.BorrowReceipt.IssuedDate >= sDate && v.BorrowReceipt.IssuedDate <= eDate);
                    }
                    else if (filterType == "Due Date")
                    {
                        query = query.Where(v => v.BorrowReceipt.DueDate >= sDate && v.BorrowReceipt.DueDate <= eDate);
                    }
                    else if (filterType == "Returned Date")
                    {
                        query = query.Where(v => v.BorrowReceipt.ReturnedDate >= sDate && v.BorrowReceipt.ReturnedDate <= eDate);
                    }

                    var filteredData = await query.Select(val => new
                    {
                        BorrowReceipt = val.BorrowReceipt.ReceiptId,
                        borrName = val.BorrowReceipt.Borrower.Name,
                        borrowedItems = val.Equipment.Name, // Included Equipment Name mapping
                        Qty = val.Qty,
                        IssuedDate = val.BorrowReceipt.IssuedDate,
                        DueDate = val.BorrowReceipt.DueDate,
                        ReturnedDate = val.BorrowReceipt.ReturnedDate,
                        status = val.BorrowReceipt.ReturnedDate.HasValue
                            ? (val.BorrowReceipt.ReturnedDate.Value <= val.BorrowReceipt.DueDate ? "Returned" : "Returned Late")
                            : (DateTime.Now > val.BorrowReceipt.DueDate ? "Overdue" : "Borrowed")
                    }).ToListAsync();

                    borrowerInfoTB.AutoGenerateColumns = false;
                    borrowerInfoTB.DataSource = filteredData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Applying Filters", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void reciptsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // FIX: Use DataPropertyName instead of Name. It's much safer!
            if (reciptsData.Columns[e.ColumnIndex].DataPropertyName == "Returned")
            {
                // 1. Read the checkmark EXACTLY as it was clicked using EditedFormattedValue
                bool isChecked = Convert.ToBoolean(reciptsData.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue);

                // 2. Safely grab the Receipt ID using the column name
                string receiptId = reciptsData.Rows[e.RowIndex].Cells["recipts"].Value?.ToString();

                if (string.IsNullOrEmpty(receiptId)) return;

                if (isChecked)
                {
                    ReturnInspectionDialog dialog = new ReturnInspectionDialog(receiptId);
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        await UpdateBorrowerSummary(brrName.Text);
                    }
                    else
                    {
                        // User cancelled inspection: refresh summary to revert checkmark
                        await UpdateBorrowerSummary(brrName.Text);
                    }
                }
                else
                {
                    try
                    {
                        // BOX UNCHECKED: They made a mistake. Remove the return date and DEDUCT the stock again!
                        using (var db = new SportRoomContext())
                    {
                        var receipt = await db.BorrowReceipts
                            .Include(r => r.BorrowedCombinations)
                            .FirstOrDefaultAsync(r => r.ReceiptId == receiptId);

                        // Ensure we only deduct if it was actually returned previously
                        if (receipt != null && receipt.ReturnedDate != null)
                        {
                            receipt.ReturnedDate = null;
                            receipt.UpdateStatus();

                            // REMOVE FROM INVENTORY AGAIN
                            foreach (var combo in receipt.BorrowedCombinations)
                            {
                                var equipment = await db.Equipments.FindAsync(combo.EquipmentId);
                                if (equipment != null)
                                {
                                    int broken = Math.Max(0, combo.BrokenQty);
                                    int healthy = Math.Max(0, combo.Qty - broken);
                                    equipment.Quantity = Math.Max(0, equipment.Quantity - healthy);
                                    equipment.BrokenQty = Math.Max(0, equipment.BrokenQty - broken);
                                }
                                combo.ReturnedQuantity = 0;
                            }
                            await db.SaveChangesAsync();
                        }
                        await UpdateBorrowerSummary(brrName.Text);
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error canceling return: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    public class ReceiptCheckItem
    {
        public string recipts { get; set; }
        public bool Returned { get; set; }
    }
}