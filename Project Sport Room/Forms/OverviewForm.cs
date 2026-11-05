using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sport_Room
{
    public partial class OverviewForm : Form
    {
        private bool isOverviewLoaded = false;
        public OverviewForm()
        {
            InitializeComponent();
            // Use Activated to catch when the user clicks this tab from the Sidebar
            this.Activated += OverviewForm_Activated;
        }

        // 2. Leave this empty so the Visual Studio Designer doesn't crash!
        private async void OverviewForm_Load(object sender, EventArgs e)
        {
            // Fixes the N/A bug on initial startup
            await RefreshDashboard();
            isOverviewLoaded = true;
        }

        private async void OverviewForm_Activated(object sender, EventArgs e)
        {
            // Fixes the stale data bug when returning to this screen
            if (isOverviewLoaded)
            {
                await RefreshDashboard();
            }
        }

        private async Task RefreshDashboard()
        {
            await LoadComboBoxes();
            await UpdateKPIs();
            await LoadGridData();
        }

        private async Task LoadComboBoxes()
        {
            using (var db = new SportRoomContext())
            {
                // Setup Department Dropdown with an "All" option at the top
                var depts = await db.Departments.Select(dep => new { Id = dep.Id, Name = dep.Name }).ToListAsync();
                depts.Insert(0, new { Id = "ALL", Name = "All Departments" });

                departmentComboBox.DisplayMember = "Name";
                departmentComboBox.ValueMember = "Id";
                departmentComboBox.DataSource = depts;
            }

            // Setup Status Dropdown with an "All" option
            statusComboBox.Items.Clear();
            statusComboBox.Items.AddRange(new string[] { "All", "Borrowed", "Overdue", "Returned", "Returned Late" });
            statusComboBox.SelectedIndex = 0; // Default to "All"
        }

        private async Task UpdateKPIs()
        {
            using (var db = new SportRoomContext())
            {
                // 1. Available: Healthy items currently on the shelf (Deducts borrowed natively)
                int available = await db.Equipments.SumAsync(e => (int?)e.Quantity) ?? 0;
                avalableEq.Text = available.ToString();

                // 2. Damaged: Items currently broken
                int damaged = await db.Equipments.SumAsync(e => (int?)e.BrokenQty) ?? 0;

                // 3. Borrowed: Healthy items currently in the hands of students
                int borrowed = await db.BorrowedCombinations
                    .Where(bc => bc.BorrowReceipt.ReturnedDate == null)
                    .SumAsync(bc => (int?)bc.Qty) ?? 0;
                borrowedEq.Text = borrowed.ToString();

                // 4. True Total Equipment: Everything you physically own combined
                int totalEq = available + damaged + borrowed;
                totalEquipments.Text = totalEq.ToString();

                // 5. Newly Arrived (Last 30 days)
                DateTime thirtyDaysAgo = DateTime.Now.AddDays(-30);
                int newlyArr = await db.IntakeItems
                    .Where(i => i.SuppliedDate >= thirtyDaysAgo)
                    .SumAsync(i => (int?)i.Quantity) ?? 0;
                newlyArrived.Text = newlyArr.ToString();
            }
        }

        private async Task LoadGridData()
        {
            using (var db = new SportRoomContext())
            {
                var query = db.BorrowedCombinations
                    .Include(bc => bc.BorrowReceipt)
                    .ThenInclude(r => r.Borrower)
                    .ThenInclude(b => b.Department)
                    .Include(bc => bc.Equipment)
                    .AsNoTracking()
                    .AsQueryable();

                // --- APPLY FILTERS ---

                // 1. Global Text Search (Searches Receipt ID, Borrower Name, and Equipment Name)
                string searchTxt = searchAll.Text.Trim();
                if (!string.IsNullOrEmpty(searchTxt))
                {
                    query = query.Where(bc =>
                        bc.BorrowReceipt.ReceiptId.Contains(searchTxt) ||
                        bc.BorrowReceipt.Borrower.Name.Contains(searchTxt) ||
                        bc.Equipment.Name.Contains(searchTxt));
                }

                // 2. Department Filter
                if (departmentComboBox.SelectedValue != null && departmentComboBox.SelectedValue.ToString() != "ALL")
                {
                    string depId = departmentComboBox.SelectedValue.ToString();
                    query = query.Where(bc => bc.BorrowReceipt.Borrower.DepartmentId == depId);
                }

                // 3. Status Filter (Evaluated natively in SQL for performance)
                string statusFilter = statusComboBox.Text;
                DateTime now = DateTime.Now;

                if (statusFilter == "Borrowed")
                {
                    query = query.Where(bc => bc.BorrowReceipt.ReturnedDate == null && bc.BorrowReceipt.DueDate >= now);
                }
                else if (statusFilter == "Overdue")
                {
                    query = query.Where(bc => bc.BorrowReceipt.ReturnedDate == null && bc.BorrowReceipt.DueDate < now);
                }
                else if (statusFilter == "Returned")
                {
                    query = query.Where(bc => bc.BorrowReceipt.ReturnedDate != null && bc.BorrowReceipt.ReturnedDate <= bc.BorrowReceipt.DueDate);
                }
                else if (statusFilter == "Returned Late")
                {
                    query = query.Where(bc => bc.BorrowReceipt.ReturnedDate != null && bc.BorrowReceipt.ReturnedDate > bc.BorrowReceipt.DueDate);
                }

                // --- EXECUTE & BIND DATA ---
                var gridData = await query.Select(val => new
                {
                    ReceiptId = val.BorrowReceipt.ReceiptId,
                    BorrowerName = val.BorrowReceipt.Borrower.Name,
                    Borrower_Id = val.BorrowReceipt.Borrower.BorrowerId,
                    Department = val.BorrowReceipt.Borrower.Department != null ? val.BorrowReceipt.Borrower.Department.Name : "N/A",
                    Equipment = val.Equipment.Name,
                    Qty = val.Qty,
                    Status = val.BorrowReceipt.ReturnedDate.HasValue
                        ? (val.BorrowReceipt.ReturnedDate.Value <= val.BorrowReceipt.DueDate ? "Returned" : "Returned Late")
                        : (now > val.BorrowReceipt.DueDate ? "Overdue" : "Borrowed")
                }).OrderByDescending(x => x.ReceiptId).ToListAsync(); // Orders newest transactions at the top

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = gridData;
            }
        }

        // Triggered by the "Apply" button to filter the main grid
        private async void adorableFilter_Click(object sender, EventArgs e)
        {
            await LoadGridData();
        }

        // Required to prevent Visual Studio Designer errors if accidentally double-clicked
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}