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
    public partial class newIntake : Form
    {
        public newIntake()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Add frm1 = new Add();

            // The code stops here and waits while the user is using the Add form
            frm1.ShowDialog();

            // The moment the Add form closes, this code runs and refreshes the grid!
            await UpdateUI();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            addNewIntake frm2 = new addNewIntake();
            frm2.ShowDialog();

            // Refresh both tables to show the new intakes
            await UpdateUI();
            await changeTableBasedOnConstrints("", "");
        }

        private async Task UpdateUI()
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    var supplier_Data = await db.Suppliers.Select(data => new
                    {
                        data.Id,
                        data.Name,
                        data.PhoneNumber
                    }).ToListAsync();

                    supplierTable.Columns.Clear();
                    supplierTable.DataSource = supplier_Data;

                    if (supplierTable.Columns.Contains("Id"))
                        supplierTable.Columns["Id"].HeaderText = "Supplier ID";
                    if (supplierTable.Columns.Contains("Name"))
                        supplierTable.Columns["Name"].HeaderText = "Supplier Name";
                    if (supplierTable.Columns.Contains("PhoneNumber"))
                        supplierTable.Columns["PhoneNumber"].HeaderText = "Phone Number";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task changeTableBasedOnConstrints(string constrintsTypex, string searchString)
        {
            try
            {
                using (var db = new SportRoomContext())
            {
                var query = db.IntakeItems.AsQueryable();
                switch (constrintsTypex)
                {
                    case "supplierID":
                        query = query.Where(data => data.SupplierId == searchString);
                        break;
                }

                var tableData = await query.Select(data => new
                {
                    data.Id,
                    supplierName = data.Supplier != null ? data.Supplier.Name : "N/A",
                    equipmentName = data.Equipment.Name,
                    data.SuppliedDate,
                    healthy = Math.Max(0, data.Quantity - data.BrokenQty),
                    broken = data.BrokenQty

                }).ToListAsync();

                intakeTable.Columns.Clear();
                intakeTable.DataSource = tableData;

                intakeTable.Columns["Id"].HeaderText = "Intake ID";
                intakeTable.Columns["supplierName"].HeaderText = "Supplier Name";
                intakeTable.Columns["equipmentName"].HeaderText = "Equipment Name";
                if (intakeTable.Columns.Contains("healthy"))
                    intakeTable.Columns["healthy"].HeaderText = "Healthy Equipment";
                if (intakeTable.Columns.Contains("broken"))
                    intakeTable.Columns["broken"].HeaderText = "Broken Equipment";
                if (intakeTable.Columns.Contains("SuppliedDate"))
                    intakeTable.Columns["SuppliedDate"].HeaderText = "Supplied Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading intake records: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void newIntake_Load(object sender, EventArgs e)
        {
            await UpdateUI();
            await changeTableBasedOnConstrints("", "");
        }

        private async void supplierTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var cellValue = supplierTable.Rows[e.RowIndex].Cells["Id"].Value;
            if (cellValue == null) return;
            string selectedsuppliertId = cellValue.ToString();
            await changeTableBasedOnConstrints("supplierID", selectedsuppliertId);
        }
    }
}
