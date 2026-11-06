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
    public partial class manageBorrower : Form
    {
        private string? _initialBorrowerId;

        // Constructor 1: Required for the Visual Studio Designer to render
        public manageBorrower()
        {
            InitializeComponent();
        }

        // Constructor 2: Used by your app to pass the ID
        public manageBorrower(string selectedBorrowerId) : this()
        {
            _initialBorrowerId = selectedBorrowerId;
        }

        // Keep this dummy method so the Designer doesn't crash looking for it!
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void manageBorrower_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Setup Role Dropdown
                roleComboBox.Items.Clear();
                roleComboBox.Items.AddRange(new string[] { "Student", "Staff" });

                using (var db = new SportRoomContext())
            {
                // 2. Load Departments
                var depts = await db.Departments.ToListAsync();
                department.DisplayMember = "Name";
                department.ValueMember = "Id";
                department.DataSource = depts;

                // 3. Load Borrowers into Name Combobox
                var allBorrowers = await db.Borrowers.ToListAsync();
                var uniqueBorrowers = allBorrowers
                    .GroupBy(b => b.Name)
                    .Select(g => g.First())
                    .OrderBy(b => b.Name)
                    .ToList();

                nameCombobox.DisplayMember = "Name";
                nameCombobox.ValueMember = "BorrowerId";
                nameCombobox.DataSource = uniqueBorrowers;

                // 4. Set Initial Selection
                if (!string.IsNullOrEmpty(_initialBorrowerId))
                {
                    nameCombobox.SelectedValue = _initialBorrowerId;
                }
                else
                {
                    var latestBorrowerId = await db.BorrowReceipts
                        .OrderByDescending(r => r.IssuedDate)
                        .Select(r => r.BorrowerId)
                        .FirstOrDefaultAsync();

                    if (latestBorrowerId != null)
                    {
                        nameCombobox.SelectedValue = latestBorrowerId;
                    }
                }
            }

            // Attach selection events dynamically so they don't fire prematurely
                nameCombobox.SelectedIndexChanged += NameCombobox_SelectedIndexChanged;
                borrowalsTb.SelectionChanged += BorrowalsTb_SelectionChanged;

                // Force load the first selected profile
                await LoadBorrowerProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing borrower management: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void NameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadBorrowerProfile();
        }

        private async Task LoadBorrowerProfile()
        {
            if (nameCombobox.SelectedValue == null) return;
            string bId = nameCombobox.SelectedValue.ToString()!;

            try
            {
                using (var db = new SportRoomContext())
            {
                var b = await db.Borrowers.FindAsync(bId);
                if (b != null)
                {
                    email.Text = b.Email;
                    phoneNumber.Text = b.PhoneNumber;
                    roleComboBox.Text = b.Role;
                    department.SelectedValue = b.DepartmentId;

                    await LoadReceipts(bId);
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrower profile: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadReceipts(string borrowerId)
        {
            try
            {
                using (var db = new SportRoomContext())
            {
                var receipts = await db.BorrowReceipts
                    .Include(r => r.BorrowedCombinations)
                    .Where(r => r.BorrowerId == borrowerId)
                    .Select(r => new ReceiptGridItem
                    {
                        ReceiptId = r.ReceiptId,
                        Qty = r.BorrowedCombinations.Sum(c => c.Qty),
                        IssuedDate = r.IssuedDate,
                        DueDate = r.DueDate,
                        ReturnedDate = r.ReturnedDate,
                        Status = r.Status
                    }).ToListAsync();

                borrowalsTb.AutoGenerateColumns = false;
                borrowalsTb.DataSource = receipts;

                if (borrowalsTb.Rows.Count > 0)
                {
                    borrowalsTb.Rows[0].Selected = true;
                    await LoadEquipments(receipts[0].ReceiptId);
                }
                else
                {
                    borrwedEquipmentTB.DataSource = null;
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading receipts: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BorrowalsTb_SelectionChanged(object sender, EventArgs e)
        {
            if (borrowalsTb.CurrentRow == null) return;

            string? receiptId = borrowalsTb.CurrentRow.Cells["ReceiptId"].Value?.ToString();
            if (!string.IsNullOrEmpty(receiptId))
            {
                await LoadEquipments(receiptId);
            }
        }

        private async Task LoadEquipments(string receiptId)
        {
            try
            {
                using (var db = new SportRoomContext())
            {
                var equipments = await db.BorrowedCombinations
                    .Include(c => c.Equipment)
                    .ThenInclude(e => e.Category)
                    .Where(c => c.ReceiptId == receiptId)
                    .Select(c => new EquipmentGridItem
                    {
                        CombinationId = c.CombinationId,
                        eqId = c.EquipmentId,
                        EquipmentName = c.Equipment != null ? c.Equipment.Name : "N/A",
                        category = c.Equipment != null && c.Equipment.Category != null ? c.Equipment.Category.CategoryName : "N/A",
                        quantity = c.Qty,
                        BrokenQty = c.BrokenQty
                    }).ToListAsync();

                borrwedEquipmentTB.AutoGenerateColumns = false;
                borrwedEquipmentTB.DataSource = equipments;

                if (borrwedEquipmentTB.Columns.Contains("eqId")) borrwedEquipmentTB.Columns["eqId"].ReadOnly = true;
                if (borrwedEquipmentTB.Columns.Contains("EquipmentName")) borrwedEquipmentTB.Columns["EquipmentName"].ReadOnly = true;
                if (borrwedEquipmentTB.Columns.Contains("category")) borrwedEquipmentTB.Columns["category"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowed equipments: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                borrowalsTb.EndEdit();
                borrwedEquipmentTB.EndEdit();

                using (var db = new SportRoomContext())
                {
                    // 1. Update Borrower Info
                    string? bId = nameCombobox.SelectedValue?.ToString();
                    if (!string.IsNullOrEmpty(bId))
                    {
                        var borrower = await db.Borrowers.FindAsync(bId);
                        if (borrower != null)
                        {
                            borrower.Email = email.Text;
                            borrower.PhoneNumber = phoneNumber.Text;
                            borrower.Role = roleComboBox.Text;
                            if (department.SelectedValue != null)
                            {
                                borrower.DepartmentId = department.SelectedValue.ToString()!;
                            }
                        }
                    }

                    // 2. Safely Update Receipts with Stock Adjustment
                    var receiptsList = borrowalsTb.DataSource as List<ReceiptGridItem>;
                    if (receiptsList != null)
                    {
                        foreach (var item in receiptsList)
                        {
                            if (string.IsNullOrEmpty(item.ReceiptId)) continue;

                            var dbReceipt = await db.BorrowReceipts
                                .Include(r => r.BorrowedCombinations)
                                .FirstOrDefaultAsync(r => r.ReceiptId == item.ReceiptId);

                            if (dbReceipt != null)
                            {
                                DateTime? oldReturned = dbReceipt.ReturnedDate;
                                DateTime? newReturned = item.ReturnedDate;

                                dbReceipt.IssuedDate = item.IssuedDate;
                                dbReceipt.DueDate = item.DueDate;
                                dbReceipt.ReturnedDate = newReturned;
                                dbReceipt.UpdateStatus();

                                // Stock synchronization when return status transitions
                                if (oldReturned == null && newReturned != null)
                                {
                                    // Loan returned -> Restock inventory
                                    foreach (var combo in dbReceipt.BorrowedCombinations)
                                    {
                                        var eq = await db.Equipments.FindAsync(combo.EquipmentId);
                                        int broken = Math.Max(0, combo.BrokenQty);
                                        int healthy = Math.Max(0, combo.Qty - broken);
                                        if (eq != null)
                                        {
                                            eq.Quantity += healthy;
                                            eq.BrokenQty += broken;
                                        }
                                        combo.ReturnedQuantity = combo.Qty;
                                    }
                                }
                                else if (oldReturned != null && newReturned == null)
                                {
                                    // Return canceled -> Deduct from inventory
                                    foreach (var combo in dbReceipt.BorrowedCombinations)
                                    {
                                        var eq = await db.Equipments.FindAsync(combo.EquipmentId);
                                        int broken = Math.Max(0, combo.BrokenQty);
                                        int healthy = Math.Max(0, combo.Qty - broken);
                                        if (eq != null)
                                        {
                                            eq.Quantity = Math.Max(0, eq.Quantity - healthy);
                                            eq.BrokenQty = Math.Max(0, eq.BrokenQty - broken);
                                        }
                                        combo.ReturnedQuantity = 0;
                                    }
                                }
                            }
                        }
                    }

                    // 3. Safely Update Equipments
                    var equipmentsList = borrwedEquipmentTB.DataSource as List<EquipmentGridItem>;
                    if (equipmentsList != null)
                    {
                        foreach (var item in equipmentsList)
                        {
                            if (string.IsNullOrEmpty(item.CombinationId)) continue;

                            if (item.quantity <= 0)
                            {
                                MessageBox.Show($"Equipment '{item.EquipmentName}': Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (item.BrokenQty < 0)
                            {
                                MessageBox.Show($"Equipment '{item.EquipmentName}': Broken Quantity cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (item.BrokenQty > item.quantity)
                            {
                                MessageBox.Show($"Equipment '{item.EquipmentName}': Broken Quantity ({item.BrokenQty}) cannot exceed total quantity ({item.quantity}).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var dbCombo = await db.BorrowedCombinations
                                .Include(c => c.BorrowReceipt)
                                .FirstOrDefaultAsync(c => c.CombinationId == item.CombinationId);

                            if (dbCombo != null)
                            {
                                int oldQty = dbCombo.Qty;
                                int oldBroken = dbCombo.BrokenQty;
                                int newQty = item.quantity;
                                int newBroken = item.BrokenQty;

                                var eq = await db.Equipments.FindAsync(dbCombo.EquipmentId);

                                // If the parent receipt is currently ACTIVE (not returned yet)
                                if (dbCombo.BorrowReceipt.ReturnedDate == null)
                                {
                                    int qtyDiff = newQty - oldQty;
                                    if (eq != null && qtyDiff != 0)
                                    {
                                        if (qtyDiff > 0 && qtyDiff > eq.Quantity)
                                        {
                                            MessageBox.Show($"Cannot increase borrowed quantity for '{eq.Name}' by {qtyDiff}. Only {eq.Quantity} available in stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return;
                                        }
                                        eq.Quantity = Math.Max(0, eq.Quantity - qtyDiff);
                                    }
                                }
                                // If the parent receipt was ALREADY RETURNED
                                else
                                {
                                    int oldHealthy = Math.Max(0, oldQty - oldBroken);
                                    int newHealthy = Math.Max(0, newQty - newBroken);
                                    int healthyDiff = newHealthy - oldHealthy;
                                    int brokenDiff = newBroken - oldBroken;

                                    if (eq != null)
                                    {
                                        eq.Quantity = Math.Max(0, eq.Quantity + healthyDiff);
                                        eq.BrokenQty = Math.Max(0, eq.BrokenQty + brokenDiff);
                                    }
                                    dbCombo.ReturnedQuantity = newQty;
                                }

                                dbCombo.Qty = newQty;
                                dbCombo.BrokenQty = newBroken;
                            }
                        }
                    }

                    await db.SaveChangesAsync();
                }

                MessageBox.Show("All borrower information updated successfully!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadBorrowerProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving updates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class ReceiptGridItem
    {
        public string ReceiptId { get; set; } = "";
        public int Qty { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public string Status { get; set; } = "";
    }

    public class EquipmentGridItem
    {
        public string CombinationId { get; set; } = "";
        public string eqId { get; set; } = "";
        public string EquipmentName { get; set; } = "";
        public string category { get; set; } = "";
        public int quantity { get; set; }
        public int BrokenQty { get; set; }
    }
}