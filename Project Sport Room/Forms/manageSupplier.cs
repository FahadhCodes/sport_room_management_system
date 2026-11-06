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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Project_Sport_Room
{
    public partial class manageSupplier : Form
    {
        private class IntakeRowDTO
        {
            public string intakeId { get; set; }
            public string EquipmentId { get; set; }
            public string EquipmentName { get; set; }
            public DateTime suppliedDate { get; set; }
            public int HealthyQuantity { get; set; }
            public int DamagedQuantity { get; set; }
        }
        BindingList<IntakeRowDTO> currentIntakeList = new BindingList<IntakeRowDTO>();

        // Inside manageSupplier.cs

        private string _initialSupplierId;
        public manageSupplier()
        {
            InitializeComponent();
        }
        // Constructor 2: To receive the ID from the parent
        public manageSupplier(string selectedSupplierId) : this()
        {
            _initialSupplierId = selectedSupplierId;
        }
        private async Task updateTables()
        {
            // 1. SAFETY CHECK: Prevent crashes during Form_Load
            if (supplierIdComboBox.SelectedValue == null) return;

            string supplierID = supplierIdComboBox.SelectedValue.ToString();

            try
            {
                using (var db = new SportRoomContext())
                {
                    var intakeInfo = await db.IntakeItems
                        .Where(cons => cons.SupplierId == supplierID)
                        .Select(intk => new
                        {
                            intk.Id,
                            EquipmentId = intk.Equipment.Id,
                            EquipmentName = intk.Equipment.Name, // Extract the actual name text
                            intk.SuppliedDate,
                            healthy = intk.Quantity - intk.BrokenQty,
                            broken = intk.BrokenQty
                        }).ToListAsync();

                    // 2. CRITICAL FIX: Empty the previous items out of the temporary list
                    currentIntakeList.Clear();

                    foreach (var eq in intakeInfo)
                    {
                        currentIntakeList.Add(new IntakeRowDTO
                        {
                            intakeId = eq.Id,
                            // 3. Map both the ID and Name correctly to your DTO
                            EquipmentId = eq.EquipmentId,
                            EquipmentName = eq.EquipmentName,
                            suppliedDate = eq.SuppliedDate,
                            HealthyQuantity = eq.healthy,
                            DamagedQuantity = eq.broken
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading intake table: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task updateTextBoxes()
        {
            // 1. SAFETY CHECK: Prevent crashes during Form_Load
            if (supplierIdComboBox.SelectedValue == null) return;

            string supplierID = supplierIdComboBox.SelectedValue.ToString();
            try
            {
                using (var db = new SportRoomContext())
                {
                    var Suppliers = await db.Suppliers.Where(el => el.Id == supplierID).Select(sup => new
                    {
                        sup.Id,
                        sup.Name,
                        sup.PhoneNumber
                    }).ToListAsync();
                    if (!string.IsNullOrEmpty(supplierID))
                    {
                        phoneNO.Text = Suppliers.FirstOrDefault()?.PhoneNumber ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task updateKPYs()
        {
            // 1. SAFETY CHECK: Prevent crashes during Form_Load
            if (supplierIdComboBox.SelectedValue == null) return;

            string supplierID = (string)supplierIdComboBox.SelectedValue.ToString();
            try
            {
                using (var db = new SportRoomContext())
                {
                    var IntakeData = await db.IntakeItems.Where(el => el.SupplierId == supplierID).Select(intk => new
                    {
                        intk.Id,
                        intk.SuppliedDate,
                        equipmentName = intk.Equipment.Name,
                        intk.Quantity,
                        intk.BrokenQty
                    }).ToListAsync();
                    int tot = 0;
                    int broken = 0;
                    foreach (var item in IntakeData)
                    {
                        tot += item.Quantity;
                        broken += item.BrokenQty;
                    }
                    totalEq.Text = tot.ToString();
                    brokenEq.Text = broken.ToString();
                    healthyEq.Text = (tot - broken).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating supplier statistics: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void manageSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                //Table template
                // Bind the grid to your temporary DTO list
                supplierTBspecific.AutoGenerateColumns = false;
                supplierTBspecific.DataSource = currentIntakeList;


                // Define columns programmatically (or do this in the WinForms Designer)
                supplierTBspecific.Columns.Clear();
                supplierTBspecific.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Intake ID", DataPropertyName = "intakeId", ReadOnly = true });
                using (var db = new SportRoomContext())
                {
                    var equipments = await db.Equipments.Select(x => new { x.Id, x.Name }).ToListAsync();
                    supplierTBspecific.Columns.Add(new DataGridViewComboBoxColumn
                    {
                        Name = "Name",
                        HeaderText = "Equipment Name",
                        DataSource = equipments,
                        DisplayMember = "Name",
                        ValueMember = "Id",
                        DataPropertyName = "EquipmentId"
                    });
                }

                supplierTBspecific.Columns.Add(new DataGridViewTextBoxColumn { Name = "SuppliedDate", HeaderText = "Supplied Date", DataPropertyName = "suppliedDate" });
                supplierTBspecific.Columns.Add(new DataGridViewTextBoxColumn { Name = "Healthy", HeaderText = "Healthy", DataPropertyName = "HealthyQuantity" });
                supplierTBspecific.Columns.Add(new DataGridViewTextBoxColumn { Name = "Damage", HeaderText = "Damaged", DataPropertyName = "DamagedQuantity" });
                supplierTBspecific.Columns.Add(new DataGridViewButtonColumn { Name = "delete", HeaderText = "DELETE", Text = "Delete", UseColumnTextForButtonValue = true });

                // --- Completely replaced block starts here ---
                using (var db = new SportRoomContext())
                {
                    var Suppliers = await db.Suppliers.Select(sup => new { sup.Id, sup.Name }).ToListAsync();
                    supplierIdComboBox.DisplayMember = "Name";
                    supplierIdComboBox.ValueMember = "Id";
                    supplierIdComboBox.DataSource = Suppliers;

                    // Use the variable we passed into the constructor!
                    if (!string.IsNullOrEmpty(_initialSupplierId))
                    {
                        supplierIdComboBox.SelectedValue = _initialSupplierId;
                    }
                }
                // --- Completely replaced block ends here ---
                await updateTextBoxes();
                await updateTables();
                await updateKPYs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing supplier view: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            // 1. Force the grid to save whatever cell is currently being typed in!
            supplierTBspecific.EndEdit();
            supplierTBspecific.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if (supplierIdComboBox.SelectedValue == null) return;
            string supplierID = supplierIdComboBox.SelectedValue.ToString();

            try
            {
                using (var db = new SportRoomContext())
                {
                    var supplierData = await db.Suppliers.FirstOrDefaultAsync(sup => sup.Id == supplierID);
                    if (supplierData != null)
                    {
                        supplierData.Name = supplierIdComboBox.Text;
                        supplierData.PhoneNumber = phoneNO.Text;
                    }

                    foreach (var row in currentIntakeList)
                    {
                        var intakeItem = await db.IntakeItems.FirstOrDefaultAsync(intk => intk.Id == row.intakeId);

                        if (intakeItem != null)
                        {
                            // 1. Extract Old Values
                            int oldTotalQty = intakeItem.Quantity;
                            int oldBrokenQty = intakeItem.BrokenQty;
                            int oldHealthyQty = oldTotalQty - oldBrokenQty;
                            string oldEquipmentId = intakeItem.EquipmentId;

                            // 2. Extract New Values
                            int newHealthyQty = row.HealthyQuantity;
                            int newBrokenQty = row.DamagedQuantity;
                            if (newHealthyQty < 0 || newBrokenQty < 0)
                            {
                                MessageBox.Show($"Row for '{row.EquipmentName}': Quantities cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            int newTotalQty = newHealthyQty + newBrokenQty;
                            string newEquipmentId = row.EquipmentId;

                            // SCENARIO A: The user changed the Equipment Type in the dropdown
                            if (oldEquipmentId != newEquipmentId)
                            {
                                // Deduct old values from the OLD equipment
                                var oldEquipment = await db.Equipments.FirstOrDefaultAsync(eq => eq.Id == oldEquipmentId);
                                if (oldEquipment != null)
                                {
                                    oldEquipment.Quantity -= oldHealthyQty; // Deduct healthy
                                    oldEquipment.BrokenQty -= oldBrokenQty; // Deduct broken
                                    if (oldEquipment.Quantity < 0) oldEquipment.Quantity = 0;
                                    if (oldEquipment.BrokenQty < 0) oldEquipment.BrokenQty = 0;
                                }

                                // Add new values to the NEW equipment
                                var newEquipment = await db.Equipments.FirstOrDefaultAsync(eq => eq.Id == newEquipmentId);
                                if (newEquipment != null)
                                {
                                    newEquipment.Quantity += newHealthyQty;
                                    newEquipment.BrokenQty += newBrokenQty;
                                }
                            }
                            // SCENARIO B: The equipment is the same, only the numbers changed
                            else
                            {
                                int healthyChange = newHealthyQty - oldHealthyQty;
                                int brokenChange = newBrokenQty - oldBrokenQty;

                                var equipment = await db.Equipments.FirstOrDefaultAsync(eq => eq.Id == oldEquipmentId);
                                if (equipment != null)
                                {
                                    equipment.Quantity += healthyChange;
                                    equipment.BrokenQty += brokenChange;
                                    if (equipment.Quantity < 0) equipment.Quantity = 0;
                                    if (equipment.BrokenQty < 0) equipment.BrokenQty = 0;
                                }
                            }

                            // Update the Intake History log itself
                            intakeItem.EquipmentId = newEquipmentId;
                            intakeItem.SuppliedDate = row.suppliedDate;
                            intakeItem.Quantity = newTotalQty;
                            intakeItem.BrokenQty = newBrokenQty;
                        }
                        else if (!string.IsNullOrEmpty(row.EquipmentId) && (row.HealthyQuantity > 0 || row.DamagedQuantity > 0))
                        {
                            int newHealthyQty = row.HealthyQuantity;
                            int newBrokenQty = row.DamagedQuantity;
                            if (newHealthyQty < 0 || newBrokenQty < 0)
                            {
                                MessageBox.Show($"Row for '{row.EquipmentName}': Quantities cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            int newTotalQty = newHealthyQty + newBrokenQty;

                            var newIntake = new IntakeItem
                            {
                                SupplierId = supplierID,
                                EquipmentId = row.EquipmentId,
                                SuppliedDate = row.suppliedDate == default ? DateTime.Now : row.suppliedDate,
                                Quantity = newTotalQty,
                                BrokenQty = newBrokenQty
                            };
                            await db.IntakeItems.AddAsync(newIntake);

                            var eq = await db.Equipments.FirstOrDefaultAsync(e => e.Id == row.EquipmentId);
                            if (eq != null)
                            {
                                eq.Quantity += newHealthyQty;
                                eq.BrokenQty += newBrokenQty;
                            }
                        }
                    }

                    await db.SaveChangesAsync();

                    // Tell the UI to recalculate the KPIs and refresh the table!
                    await updateKPYs();
                    await updateTables();

                    MessageBox.Show("Supplier records and master stock updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supplierTBspecific_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // 1. Check if the control about to be shown is a ComboBox
            if (e.Control is ComboBox combo)
            {
                // 2. Make sure we are in the correct column ("Name")
                if (supplierTBspecific.CurrentCell.OwningColumn.Name == "Name")
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

        private async void supplierIdComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            await updateTextBoxes();
            await updateTables();
            await updateKPYs();
        }

        private async void supplierTBspecific_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Ensure the user clicked a valid row and specifically the "delete" button column
            if (e.RowIndex >= 0 && supplierTBspecific.Columns[e.ColumnIndex].Name == "delete")
            {
                // 2. Extract the data directly from your bound DTO list
                var rowData = currentIntakeList[e.RowIndex];
                string intakeId = rowData.intakeId;
                string eqId = rowData.EquipmentId;
                int healthyQty = rowData.HealthyQuantity;
                int brokenQty = rowData.DamagedQuantity;

                // 3. Ask the user how they want to handle the deletion
                DialogResult dialogResult = MessageBox.Show(
                    "Do you want to deduct these quantities from the Main Equipment stock?\n\n" +
                    "Yes = Delete history AND deduct from main stock\n" +
                    "No = Just clean the history\n" +
                    "Cancel = Abort",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Cancel) return;

                try
                {
                    using (var db = new SportRoomContext())
                    {
                        var intakeToDelete = await db.IntakeItems.FirstOrDefaultAsync(i => i.Id == intakeId);

                        if (intakeToDelete != null)
                        {
                            // Delete the history record regardless of Yes or No
                            db.IntakeItems.Remove(intakeToDelete);

                            // If Yes, also deduct from the main Equipment table
                            if (dialogResult == DialogResult.Yes)
                            {
                                var equipment = await db.Equipments.FirstOrDefaultAsync(eq => eq.Id == eqId);
                                if (equipment != null)
                                {
                                    equipment.Quantity -= healthyQty;
                                    equipment.BrokenQty -= brokenQty;

                                    // Prevent negative stock just in case
                                    if (equipment.Quantity < 0) equipment.Quantity = 0;
                                    if (equipment.BrokenQty < 0) equipment.BrokenQty = 0;
                                }
                            }

                            await db.SaveChangesAsync();

                            // Refresh the table to remove the deleted row from the UI
                            await updateTables();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting intake item: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void filterBtn_Click(object sender, EventArgs e)
        {
            if (supplierIdComboBox.SelectedValue == null) return;
            string supplierID = supplierIdComboBox.SelectedValue.ToString();

            // Assuming your DateTimePickers are named like this
            DateTime start = startDatePicker.Value;
            DateTime end = endDatePicker.Value;

            try
            {
                using (var db = new SportRoomContext())
                {
                    var intakeInfo = await db.IntakeItems
                        .Where(cons => cons.SupplierId == supplierID &&
                                       cons.SuppliedDate >= start &&
                                       cons.SuppliedDate <= end)
                        .Select(intk => new
                        {
                            intk.Id,
                            EquipmentId = intk.Equipment.Id,
                            EquipmentName = intk.Equipment.Name,
                            intk.SuppliedDate,
                            healthy = intk.Quantity - intk.BrokenQty,
                            broken = intk.BrokenQty
                        }).ToListAsync();

                    currentIntakeList.Clear();
                    foreach (var eq in intakeInfo)
                    {
                        currentIntakeList.Add(new IntakeRowDTO
                        {
                            intakeId = eq.Id,
                            EquipmentId = eq.EquipmentId,
                            EquipmentName = eq.EquipmentName,
                            suppliedDate = eq.SuppliedDate,
                            HealthyQuantity = eq.healthy,
                            DamagedQuantity = eq.broken
                        });
                    }

                    // Force the DataGridView to refresh its view of the list
                    supplierTBspecific.DataSource = null;
                    supplierTBspecific.DataSource = currentIntakeList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering intake items: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void bottomDeleteBtn_Click(object sender, EventArgs e)
        {
            if (currentIntakeList.Count == 0)
            {
                MessageBox.Show("No records to delete in the current view.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete ALL intake history currently visible in the table?\n\n" +
                "(Main equipment stock will NOT be affected).",
                "Clear History",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SportRoomContext())
                    {
                        // 1. Extract all the IDs currently loaded in the UI list
                        var idsToDelete = currentIntakeList.Select(row => row.intakeId).ToList();

                        // 2. Fetch all matching records from the database
                        var itemsToDelete = await db.IntakeItems
                            .Where(i => idsToDelete.Contains(i.Id))
                            .ToListAsync();

                        // 3. Remove them in bulk using RemoveRange
                        db.IntakeItems.RemoveRange(itemsToDelete);
                        await db.SaveChangesAsync();

                        // 4. Clear the UI list and refresh the grid
                        currentIntakeList.Clear();
                        supplierTBspecific.DataSource = null;

                        MessageBox.Show("Filtered history cleared successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error clearing history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
