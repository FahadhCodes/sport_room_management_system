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
        public string selectedsuppliertId { get; set; }
        public SupplierForm()
        {
            InitializeComponent();
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

                    suppliersTb.Columns["Name"].HeaderText = "Supplier Name";
                    suppliersTb.Columns["Id"].Visible = false;

                    if (!string.IsNullOrEmpty(suppliersList.FirstOrDefault()?.Id))
                    {
                        await updateSummary(suppliersList.FirstOrDefault().Id);
                    }
                }
            }
            catch (Exception ex) { }
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
            try
            {
                using (var db = new SportRoomContext())
                {
                    var suppliersList = await db.Suppliers.Select(sup => new { sup.Name, sup.Id }).ToListAsync();

                    suppliersTb.Columns.Clear();
                    suppliersTb.DataSource = suppliersList;

                    suppliersTb.Columns["Name"].HeaderText = "Supplier Name";
                    suppliersTb.Columns["Id"].Visible = false;

                    // Use ?. to safely check the Id without crashing if FirstOrDefault() is null
                    if (!string.IsNullOrEmpty(suppliersList.FirstOrDefault()?.Id))
                    {
                        await updateSummary(suppliersList.FirstOrDefault().Id);
                    }
                }
            }
            catch (Exception ex) { }
            await LoadAllSuppliers();
        }
        private async Task updateSummary(string id)
        {
            using (var db = new SportRoomContext())
            {
                var supplierData = await db.Suppliers.Where(sup => sup.Id == id).
                    Select(val => new
                    {
                        val.Name,
                        val.PhoneNumber
                    }).ToListAsync();
                var totalSuppliedQty = await db.IntakeItems.Where(item => item.SupplierId == id).Select(sel => new
                {
                    sel.Quantity
                }).ToListAsync();
                int tot = 0;
                foreach (var item in totalSuppliedQty)
                {
                    tot += int.Parse(item.Quantity.ToString());
                }
                suppIdLabel.Text = id;
                phoneNumaber.Text = supplierData.FirstOrDefault().PhoneNumber??"";
                NameLable.Text = supplierData.FirstOrDefault().Name??"";
                totLabel.Text = tot.ToString();
            }
        }

        private async Task updateTable(string id, string cho)
        {
            using (var db = new SportRoomContext())
            {
                var query = db.IntakeItems.AsQueryable();
                // 2. Extract the dates from the two DateTimePickers
                // Start date defaults to midnight (00:00:00)
                DateTime startDate = startDatePicker.Value.Date;

                // End date defaults to midnight, so we add 1 day and subtract 1 tick 
                // to make it 23:59:59.999 of the selected end day.
                DateTime endDate = endDatePicker.Value.Date.AddDays(1).AddTicks(-1);
                switch (cho)
                {
                    case "forSupllierList":
                        query = query.Where(dt => dt.Supplier.Id == id);
                        break;
                    case "search":
                        query = query.Where(dt => dt.Supplier.Id == id && dt.Equipment.Name.Contains(searchTextBox.Text));
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
                    supplierName = intk.Supplier.Name,
                    equipmentName = intk.Equipment.Name,
                    intk.Quantity
                }).ToListAsync();

                supplierInfoTB.Columns.Clear();
                supplierInfoTB.DataSource = IntakeData;

                supplierInfoTB.Columns["Id"].HeaderText = "Intake Id";
                supplierInfoTB.Columns["SuppliedDate"].HeaderText = "Supplied Date";
                supplierInfoTB.Columns["supplierName"].HeaderText = "supplier Name";
                supplierInfoTB.Columns["equipmentName"].HeaderText = "Equipment Name";
                supplierInfoTB.Columns["Quantity"].HeaderText = "Quantity";
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
            using (var db = new SportRoomContext())
            {
                var suppliersList = await db.Suppliers.Where(cons => cons.Name.Contains(searchSupplier.Text))
                    .Select(sup => new { sup.Name, sup.Id }).ToListAsync();

                suppliersTb.Columns.Clear();
                suppliersTb.DataSource = suppliersList;

                suppliersTb.Columns["Name"].HeaderText = "Supplier Name";
                suppliersTb.Columns["Id"].Visible = false;
            }
        }
    }
}
