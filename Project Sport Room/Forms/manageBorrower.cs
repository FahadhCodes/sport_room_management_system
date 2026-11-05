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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Sport_Room
{
    public partial class manageBorrower : Form
    {
        private SportRoomContext _db;
        private string _initialBorrowerId;

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
            _db = new SportRoomContext();

            // 1. Setup Role Dropdown
            roleComboBox.Items.Clear();
            roleComboBox.Items.AddRange(new string[] { "Student", "Staff" });

            // 2. Load Departments
            var depts = await _db.Departments.ToListAsync();
            department.DisplayMember = "Name";
            department.ValueMember = "Id";
            department.DataSource = depts;

            // 3. Load Borrowers into Name Combobox
            // Replace your existing "var borrowers = ..." block in manageBorrower_Load with this:

            // Pull all borrowers, group them by exact name, and pick the first ID for each unique name
            var allBorrowers = await _db.Borrowers.ToListAsync();
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
                // Fallback: Get the borrower with the most recent receipt
                var latestBorrowerId = await _db.BorrowReceipts
                    .OrderByDescending(r => r.IssuedDate)
                    .Select(r => r.BorrowerId)
                    .FirstOrDefaultAsync();

                if (latestBorrowerId != null)
                {
                    nameCombobox.SelectedValue = latestBorrowerId;
                }
            }

            // Attach selection events dynamically so they don't fire prematurely
            nameCombobox.SelectedIndexChanged += NameCombobox_SelectedIndexChanged;
            borrowalsTb.SelectionChanged += BorrowalsTb_SelectionChanged;

            // Force load the first selected profile
            await LoadBorrowerProfile();
        }

        private async void NameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadBorrowerProfile();
        }

        private async Task LoadBorrowerProfile()
        {
            if (nameCombobox.SelectedValue == null) return;
            string bId = nameCombobox.SelectedValue.ToString();

            var b = await _db.Borrowers.FindAsync(bId);
            if (b != null)
            {
                email.Text = b.Email;
                phoneNumber.Text = b.PhoneNumber;
                roleComboBox.Text = b.Role;
                department.SelectedValue = b.DepartmentId;

                await LoadReceipts(bId);
            }
        }

        private async Task LoadReceipts(string borrowerId)
        {
            var receipts = await _db.BorrowReceipts
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

        private async void BorrowalsTb_SelectionChanged(object sender, EventArgs e)
        {
            if (borrowalsTb.CurrentRow == null) return;

            string receiptId = borrowalsTb.CurrentRow.Cells["ReceiptId"].Value?.ToString();
            if (!string.IsNullOrEmpty(receiptId))
            {
                await LoadEquipments(receiptId);
            }
        }

        private async Task LoadEquipments(string receiptId)
        {
            var equipments = await _db.BorrowedCombinations
                .Include(c => c.Equipment)
                .ThenInclude(e => e.Category)
                .Where(c => c.ReceiptId == receiptId)
                .Select(c => new EquipmentGridItem
                {
                    CombinationId = c.CombinationId, // Hidden ID required for updates
                    eqId = c.EquipmentId,
                    EquipmentName = c.Equipment.Name,
                    category = c.Equipment.Category.CategoryName,
                    quantity = c.Qty,
                    BrokenQty = c.BrokenQty
                }).ToListAsync();

            borrwedEquipmentTB.AutoGenerateColumns = false;
            borrwedEquipmentTB.DataSource = equipments;

            // Lock the read-only columns dynamically
            if (borrwedEquipmentTB.Columns.Contains("eqId")) borrwedEquipmentTB.Columns["eqId"].ReadOnly = true;
            if (borrwedEquipmentTB.Columns.Contains("EquipmentName")) borrwedEquipmentTB.Columns["EquipmentName"].ReadOnly = true;
            if (borrwedEquipmentTB.Columns.Contains("category")) borrwedEquipmentTB.Columns["category"].ReadOnly = true;
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 0. CRITICAL FIX: Force the grids to save whatever cell the user is currently typing in
                borrowalsTb.EndEdit();
                borrwedEquipmentTB.EndEdit();

                // 1. Update Borrower Info
                string bId = nameCombobox.SelectedValue?.ToString();
                if (bId != null)
                {
                    var borrower = await _db.Borrowers.FindAsync(bId);
                    if (borrower != null)
                    {
                        borrower.Email = email.Text;
                        borrower.PhoneNumber = phoneNumber.Text;
                        borrower.Role = roleComboBox.Text;
                        borrower.DepartmentId = department.SelectedValue?.ToString();
                    }
                }

                // 2. Safely Update Receipts by reading directly from the bound Data Source list
                var receiptsList = borrowalsTb.DataSource as List<ReceiptGridItem>;
                if (receiptsList != null)
                {
                    foreach (var item in receiptsList)
                    {
                        if (string.IsNullOrEmpty(item.ReceiptId)) continue;

                        var dbReceipt = await _db.BorrowReceipts.FindAsync(item.ReceiptId);
                        if (dbReceipt != null)
                        {
                            dbReceipt.IssuedDate = item.IssuedDate;
                            dbReceipt.DueDate = item.DueDate;
                            dbReceipt.ReturnedDate = item.ReturnedDate;
                            dbReceipt.UpdateStatus();
                        }
                    }
                }

                // 3. Safely Update Equipments by reading directly from the bound Data Source list
                var equipmentsList = borrwedEquipmentTB.DataSource as List<EquipmentGridItem>;
                if (equipmentsList != null)
                {
                    foreach (var item in equipmentsList)
                    {
                        if (string.IsNullOrEmpty(item.CombinationId)) continue;

                        var dbCombo = await _db.BorrowedCombinations.FindAsync(item.CombinationId);
                        if (dbCombo != null)
                        {
                            dbCombo.Qty = item.quantity;
                            dbCombo.BrokenQty = item.BrokenQty;
                        }
                    }
                }

                // 4. Save and Refresh
                await _db.SaveChangesAsync();
                MessageBox.Show("All borrower information updated successfully!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadBorrowerProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving updates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _db?.Dispose();
            base.OnFormClosed(e);
        }
    }

    public class ReceiptGridItem
    {
        public string ReceiptId { get; set; }
        public int Qty { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public string Status { get; set; }
    }

    public class EquipmentGridItem
    {
        public string CombinationId { get; set; }
        public string eqId { get; set; }
        public string EquipmentName { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
        public int BrokenQty { get; set; }
    }
}