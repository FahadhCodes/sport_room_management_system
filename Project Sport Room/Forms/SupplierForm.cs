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
    public partial class SupplierForm : Form
    {
        public string? selectedsuppliertId { get; set; }

        public SupplierForm()
        {
            InitializeComponent();
            // Tells the form to refresh every time the sidebar button clicks it into view
            this.VisibleChanged += SupplierForm_VisibleChanged;
        }

        private async Task LoadAllSuppliers()
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    var suppliersList = await db.Suppliers.Select(sup => new { sup.Name, sup.Id }).ToListAsync();

                    suppliersTb.Columns.Clear();
                    suppliersTb.DataSource = suppliersList;

                    if (suppliersTb.Columns.Contains("Name"))
                        suppliersTb.Columns["Name"].HeaderText = "Supplier Name";
                    if (suppliersTb.Columns.Contains("Id"))
                        suppliersTb.Columns["Id"].Visible = false;

                    var firstSupplier = suppliersList.FirstOrDefault();
                    if (firstSupplier != null && !string.IsNullOrEmpty(firstSupplier.Id))
                    {
                        selectedsuppliertId = firstSupplier.Id;
                        await updateSummary(firstSupplier.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Add frm2 = new Add();
            frm2.ShowDialog();

            // Run the shared task seamlessly when the Add window closes!
            await LoadAllSuppliers();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Safety check: ensure a supplier is actually selected before trying to edit
            if (string.IsNullOrEmpty(selectedsuppliertId))
            {
                MessageBox.Show("Please select a supplier from the list first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Pass the selected ID to the child form
            manageSupplier frm1 = new manageSupplier(selectedsuppliertId);

            // 2. Pause here while the user edits the supplier
            frm1.ShowDialog();

            // 3. The instant the manageSupplier window closes, refresh the parent UI!
            await updateSummary(selectedsuppliertId);
            await updateTable(selectedsuppliertId, "forSupllierList");
        }

        private async void SupplierForm_Load(object sender, EventArgs e)
        {
          
        }

        private async Task updateSummary(string id)
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    var supplier = await db.Suppliers.FirstOrDefaultAsync(sup => sup.Id == id);
                    int tot = await db.IntakeItems.Where(item => item.SupplierId == id).SumAsync(item => (int?)item.Quantity) ?? 0;

                    suppIdLabel.Text = id;
                    phoneNumaber.Text = supplier?.PhoneNumber ?? "";
                    NameLable.Text = supplier?.Name ?? "";
                    totLabel.Text = tot.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier summary: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task updateTable(string id, string cho)
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    var query = db.IntakeItems.AsQueryable();

                    DateTime startDate = startDatePicker.Value.Date;
                    DateTime endDate = endDatePicker.Value.Date.AddDays(1).AddTicks(-1);

                    switch (cho)
                    {
                        case "forSupllierList":
                            query = query.Where(dt => dt.SupplierId == id);
                            break;
                        case "search":
                            query = query.Where(dt => dt.SupplierId == id && dt.Equipment.Name.Contains(searchTextBox.Text));
                            break;
                        case "dateFilter":
                            query = query.Where(dt => dt.SupplierId == id
                                && dt.SuppliedDate >= startDate
                                && dt.SuppliedDate <= endDate);
                            break;
                    }

                    var IntakeData = await query.Select(intk => new
                    {
                        intk.Id,
                        intk.SuppliedDate,
                        supplierName = intk.Supplier != null ? intk.Supplier.Name : "N/A",
                        equipmentName = intk.Equipment != null ? intk.Equipment.Name : "N/A",
                        intk.Quantity
                    }).ToListAsync();

                    supplierInfoTB.Columns.Clear();
                    supplierInfoTB.DataSource = IntakeData;

                    if (supplierInfoTB.Columns.Contains("Id"))
                        supplierInfoTB.Columns["Id"].HeaderText = "Intake Id";
                    if (supplierInfoTB.Columns.Contains("SuppliedDate"))
                        supplierInfoTB.Columns["SuppliedDate"].HeaderText = "Supplied Date";
                    if (supplierInfoTB.Columns.Contains("supplierName"))
                        supplierInfoTB.Columns["supplierName"].HeaderText = "Supplier Name";
                    if (supplierInfoTB.Columns.Contains("equipmentName"))
                        supplierInfoTB.Columns["equipmentName"].HeaderText = "Equipment Name";
                    if (supplierInfoTB.Columns.Contains("Quantity"))
                        supplierInfoTB.Columns["Quantity"].HeaderText = "Quantity";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading intake table: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void suppliersTb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var cellValue = suppliersTb.Rows[e.RowIndex].Cells["Id"].Value;
            if (cellValue == null) return;

            selectedsuppliertId = cellValue.ToString();
            await updateSummary(selectedsuppliertId);
            await updateTable(selectedsuppliertId, "forSupllierList");
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTextBox.Text) && !string.IsNullOrEmpty(selectedsuppliertId))
            {
                await updateTable(selectedsuppliertId, "search");
            }
        }

        private async void applyDateFilterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedsuppliertId))
            {
                await updateTable(selectedsuppliertId, "dateFilter");
            }
        }

        private async void searchSupplier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    var suppliersList = await db.Suppliers.Where(cons => cons.Name.Contains(searchSupplier.Text))
                        .Select(sup => new { sup.Name, sup.Id }).ToListAsync();

                    suppliersTb.Columns.Clear();
                    suppliersTb.DataSource = suppliersList;

                    if (suppliersTb.Columns.Contains("Name"))
                        suppliersTb.Columns["Name"].HeaderText = "Supplier Name";
                    if (suppliersTb.Columns.Contains("Id"))
                        suppliersTb.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching suppliers: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SupplierForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                await LoadAllSuppliers();
            }
        }
    }
}
