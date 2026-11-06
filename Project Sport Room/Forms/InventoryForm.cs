using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sport_Room
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            // Fire the refresh every time the user navigates to this screen
            this.VisibleChanged += InventoryForm_VisibleChanged;
        }

        // Leave empty to protect the designer
        private void InventoryForm_Load(object sender, EventArgs e)
        {
        }

        private async void InventoryForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                    using (var db = new SportRoomContext())
                {
                    // 1. Total Types of Equipment (Count of unique rows)
                    var totalTypes = await db.Equipments.CountAsync();
                    totalEquipmentTypes.Text = totalTypes.ToString();

                    // 2. Fetch the 3 states of inventory
                    int availableHealthy = await db.Equipments.SumAsync(x => (int?)x.Quantity) ?? 0;
                    int damaged = await db.Equipments.SumAsync(x => (int?)x.BrokenQty) ?? 0;
                    int borrowedHealthy = await db.BorrowedCombinations
                        .Where(bc => bc.BorrowReceipt.ReturnedDate == null)
                        .SumAsync(bc => (int?)bc.Qty) ?? 0;

                    // 3. Calculate True Totals
                    int totalPhysicalStock = availableHealthy + damaged + borrowedHealthy;
                    int totalHealthyStock = availableHealthy + borrowedHealthy;

                    TotQuantity.Text = totalPhysicalStock.ToString();
                    healthyEquipments.Text = totalHealthyStock.ToString();
                    damagedEquipments.Text = damaged.ToString();

                    // 4. Setup Combobox safely
                    var Categories = await db.Categories.Select(cat => new { cat.Id, cat.CategoryName }).ToListAsync();
                    Categories.Insert(0, new { Id = "ALL", CategoryName = "All Categories" }); // Add an ALL option

                    categoryCombobox.DisplayMember = "CategoryName";
                    categoryCombobox.ValueMember = "Id";
                    categoryCombobox.DataSource = Categories;

                    await changeTableBasedOnConstrints("", "");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading inventory summary: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public async Task changeTableBasedOnConstrints(string constrintsTypex, string searchString)
        {
            try
            {
                using (var db = new SportRoomContext())
            {
                var query = db.Equipments.AsQueryable();

                switch (constrintsTypex)
                {
                    case "EquipmentCategory":
                        if (searchString != "All Categories")
                            query = query.Where(data => data.Category.CategoryName.Contains(searchString));
                        break;
                    case "idANDname":
                        query = query.Where(data => data.Id.Contains(searchString) || data.Name.Contains(searchString));
                        break;
                }

                // Map explicitly to match your designer column names exactly
                var tableData = await query.Select(data => new
                {
                    Equipment_Id = data.Id,
                    Equipment_Name = data.Name,
                    Equipment_Category = data.Category.CategoryName,
                    Qty_healthy = data.Quantity,
                    Qty_damaged = data.BrokenQty
                }).ToListAsync();

                // Lock auto-generation and strictly bind your columns
                EquipmentDataTable.AutoGenerateColumns = false;

                if (EquipmentDataTable.Columns.Contains("Equipment_Id"))
                    EquipmentDataTable.Columns["Equipment_Id"].DataPropertyName = "Equipment_Id";
                if (EquipmentDataTable.Columns.Contains("Equipment_Name"))
                    EquipmentDataTable.Columns["Equipment_Name"].DataPropertyName = "Equipment_Name";
                if (EquipmentDataTable.Columns.Contains("Equipment_Category"))
                    EquipmentDataTable.Columns["Equipment_Category"].DataPropertyName = "Equipment_Category";
                if (EquipmentDataTable.Columns.Contains("Qty_healthy"))
                    EquipmentDataTable.Columns["Qty_healthy"].DataPropertyName = "Qty_healthy";
                if (EquipmentDataTable.Columns.Contains("Qty_damaged"))
                    EquipmentDataTable.Columns["Qty_damaged"].DataPropertyName = "Qty_damaged";

                EquipmentDataTable.DataSource = tableData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void categoryCombobox_TextChanged(object sender, EventArgs e)
        {
            await changeTableBasedOnConstrints("EquipmentCategory", categoryCombobox.Text);
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            await changeTableBasedOnConstrints("idANDname", textBox1.Text);
        }
    }
}