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
using Project_Sport_Room.Theme;

namespace Project_Sport_Room
{
    public partial class addNewIntake : Form
    {
        // The simplified, flat temporary class
        private class IntakeRowDTO
        {
            public string EquipmentId { get; set; }
            public string EquipmentName { get; set; }
            public string CategoryId { get; set; }
            public int HealthyQuantity { get; set; }
            public int DamagedQuantity { get; set; }
        }
        BindingList<IntakeRowDTO> currentIntakeList = new BindingList<IntakeRowDTO>();
        public addNewIntake()
        {
            InitializeComponent();
            ThemeManager.StyleActionButton(supplyBtn, ActionButtonVariant.Primary);
            ThemeManager.StyleActionButton(enterBtn, ActionButtonVariant.Primary);
        }

        private async void addNewIntake_Load(object sender, EventArgs e)
        {
            try
            {
                // Bind the grid to your temporary DTO list
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = currentIntakeList;

                // Define columns programmatically (or do this in the WinForms Designer)
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Equipment ID", DataPropertyName = "EquipmentId", ReadOnly = true });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Equipment Name", DataPropertyName = "EquipmentName", ReadOnly = true });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Healthy", HeaderText = "Healthy", DataPropertyName = "HealthyQuantity" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Damage", HeaderText = "Damaged", DataPropertyName = "DamagedQuantity" });

                using (var db = new SportRoomContext())
                {
                    var Categories = await db.Categories.Select(cat => new { cat.Id, cat.CategoryName }).ToListAsync();
                    categoryCombobox.DisplayMember = "CategoryName";
                    categoryCombobox.ValueMember = "Id";
                    categoryCombobox.DataSource = Categories;

                    var Suppliers = await db.Suppliers.Select(sup => new { sup.Id, sup.Name }).ToListAsync();
                    supplierIdComboBox.DisplayMember = "Name";
                    supplierIdComboBox.ValueMember = "Id";
                    supplierIdComboBox.DataSource = Suppliers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading intake options: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

       

        private async void supplierIdComboBox_TextChanged(object sender, EventArgs e)
        {
            string supplierId = supplierIdComboBox.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(supplierId)) return;

            try
            {
                using (var db = new SportRoomContext())
                {
                    var result = await db.Suppliers.Where(sup => sup.Id == supplierId)
                        .Select(sup => new { sup.Name, sup.PhoneNumber }).ToListAsync();
                    supplierNameLabel.Text = result.FirstOrDefault()?.Name ?? "";
                    supplierPhoneLabel.Text = result.FirstOrDefault()?.PhoneNumber ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void supplyBtn_Click(object sender, EventArgs e)
        {
            if (currentIntakeList.Count == 0) return;
            if (supplierIdComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string supplierId = supplierIdComboBox.SelectedValue.ToString();
            DateTime selectedDate = dateTimePicker1.Value;

            try
            {
                using (var db = new SportRoomContext())
                {
                    foreach (var row in currentIntakeList)
                    {
                        if (row.HealthyQuantity < 0 || row.DamagedQuantity < 0)
                        {
                            MessageBox.Show($"Row for '{row.EquipmentName}' has negative quantities. Quantities must be 0 or positive.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Skip rows where the user didn't enter any quantities
                        if (row.HealthyQuantity == 0 && row.DamagedQuantity == 0) continue;

                        // 1. Update Master Equipment Stock
                        var equipment = await db.Equipments.FirstOrDefaultAsync(eq => eq.Id == row.EquipmentId);
                        if (equipment != null)
                        {
                            equipment.Quantity += row.HealthyQuantity;
                            equipment.BrokenQty += row.DamagedQuantity;
                        }

                        // 2. Add Intake History Log
                        IntakeItem newIntake = new IntakeItem()
                        {
                            EquipmentId = row.EquipmentId,
                            Quantity = row.HealthyQuantity + row.DamagedQuantity,
                            BrokenQty = row.DamagedQuantity,
                            SuppliedDate = selectedDate,
                            SupplierId = supplierId
                        };

                        await db.IntakeItems.AddAsync(newIntake);
                    }

                    await db.SaveChangesAsync();
                }

                MessageBox.Show("All intake items saved and stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the form for the next intake batch
                currentIntakeList.Clear();
                supplierIdComboBox.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving intake batch: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void enterBtn_Click(object sender, EventArgs e)
        {
            if (categoryCombobox.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentIntakeList.Clear();
            string selectedCategory = (string)categoryCombobox.SelectedValue;

            try
            {
                using (var db = new SportRoomContext())
                {
                    var categoryEquipment = await db.Equipments
                        .Where(eq => eq.CategoryId == selectedCategory)
                        .ToListAsync();

                    foreach (var eq in categoryEquipment)
                    {
                        // Prevent duplicate rows if they click Enter on the same category twice
                        currentIntakeList.Add(new IntakeRowDTO
                        {
                            EquipmentId = eq.Id,
                            EquipmentName = eq.Name,
                            CategoryId = eq.CategoryId,
                            HealthyQuantity = 0,
                            DamagedQuantity = 0
                        });
                    }
                }

                // Lock the supplier dropdown once the cart has items
                supplierIdComboBox.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment for category: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
