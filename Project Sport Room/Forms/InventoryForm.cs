using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Forms;
using Project_Sport_Room.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Sport_Room.Theme;

namespace Project_Sport_Room
{
    public partial class InventoryForm : Form
    {

        //Design

        private void ApplyKpiCardStyles()
        {
            Panel[] kpiCards =
            {
             panel1,
             panel2,
             panel3,
             panel4
         };

            foreach (Panel card in kpiCards)
            {
                // Preserve existing background color
                card.BorderStyle = BorderStyle.None;

                // Rounded corners and floating shadow
                ThemeManager.ApplyRoundedPanel(card, 16);

                // Give the shadow some breathing room
                card.Margin = new Padding(7);
            }
        }

        //Design

        public InventoryForm()
        {
            InitializeComponent();

            // Set grid usability enhancements
            EquipmentDataTable.ReadOnly = true;
            EquipmentDataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EquipmentDataTable.MultiSelect = false;
            EquipmentDataTable.Cursor = Cursors.Hand;

            // Wire events
            this.VisibleChanged += InventoryForm_VisibleChanged;
            this.EquipmentDataTable.CellClick += EquipmentDataTable_CellClick;
            //design
            ApplyKpiCardStyles();
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
                        var categories = await db.Categories.Select(cat => new { cat.Id, cat.CategoryName }).ToListAsync();
                        categories.Insert(0, new { Id = "ALL", CategoryName = "All Categories" }); // Add an ALL option

                        categoryCombobox.DisplayMember = "CategoryName";
                        categoryCombobox.ValueMember = "Id";
                        categoryCombobox.DataSource = categories;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading categories: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                await RefreshInventoryData();
            }
        }

        public async Task RefreshInventoryData()
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
                }

                // Re-apply current table filter so user stays on the same view
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    await changeTableBasedOnConstrints("idANDname", textBox1.Text);
                }
                else if (categoryCombobox.SelectedItem != null && categoryCombobox.Text != "All Categories")
                {
                    await changeTableBasedOnConstrints("EquipmentCategory", categoryCombobox.Text);
                }
                else
                {
                    await changeTableBasedOnConstrints("", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing inventory data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void EquipmentDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= EquipmentDataTable.Rows.Count) return;

            var row = EquipmentDataTable.Rows[e.RowIndex];
            if (row.Cells["Equipment_Id"]?.Value == null) return;

            string eqId = row.Cells["Equipment_Id"].Value.ToString();
            if (string.IsNullOrWhiteSpace(eqId)) return;

            using (var editForm = new equipmentEdit(eqId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    await RefreshInventoryData();
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
                    string term = (searchString ?? "").Trim().ToLower();

                    switch (constrintsTypex)
                    {
                        case "EquipmentCategory":
                            if (!string.IsNullOrEmpty(searchString) && searchString != "All Categories")
                            {
                                query = query.Where(data => data.Category != null && data.Category.CategoryName != null && data.Category.CategoryName.ToLower().Contains(term));
                            }
                            break;
                        case "idANDname":
                            if (!string.IsNullOrEmpty(term))
                            {
                                query = query.Where(data =>
                                    (data.Id != null && data.Id.ToLower().Contains(term)) ||
                                    (data.Name != null && data.Name.ToLower().Contains(term)));
                            }
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