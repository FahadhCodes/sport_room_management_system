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
    public partial class Add : Form
    { 
        //Design
        private void ApplyKpiCardStyles()
        {
            Panel[] kpiCards =
            {
             panel3,
             panel4,
             panel5
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
        public Add()
        {
            InitializeComponent();
            //Design
            ApplyKpiCardStyles();
            ThemeManager.StyleActionButton(addSupplierBtn1, ActionButtonVariant.Primary);
            ThemeManager.StyleActionButton(addNewCategorybtn, ActionButtonVariant.Primary);
            ThemeManager.StyleActionButton(addNewEquipmentbtn, ActionButtonVariant.Primary);
        }

        private async void Add_Load(object sender, EventArgs e)
        {
           await UpdateUI();
        }
        private async Task UpdateUI()
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    var totalTypes = await db.Equipments.CountAsync();
                    totalEquipmentTypes.Text = totalTypes.ToString();

                    var total_category = await db.Categories.CountAsync();
                    totalCategory.Text = total_category.ToString();

                    var total_suppliers = await db.Suppliers.CountAsync();
                    totalSuppliers.Text = total_suppliers.ToString();

                    // --------- Category Combobox ------------------------------------
                    var Categories = await db.Categories.Select(cat => new { cat.Id, cat.CategoryName }).ToListAsync();

                    categoryCombobox.DisplayMember = "CategoryName";
                    categoryCombobox.ValueMember = "Id";
                    categoryCombobox.DataSource = Categories;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading catalog data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void addSupplierBtn1_Click(object sender, EventArgs e)
        {
            // VALIDATION: Prevent empty supplier fields
            if (string.IsNullOrWhiteSpace(supplierName.Text) || string.IsNullOrWhiteSpace(supplierPhoneNumber.Text))
            {
                MessageBox.Show("Please enter both the Supplier Name and Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Create the C# object
            Supplier newSupplier = new Supplier() { Name = supplierName.Text, PhoneNumber = supplierPhoneNumber.Text };

            try
            {
                // 2. Open the database connection
                using (var db = new SportRoomContext())
                {
                    // 3. Tell EF Core to track the new item
                    await db.Suppliers.AddAsync(newSupplier);

                    // 4. Actually save it to SQLite (using await so the UI doesn't freeze!)
                    await db.SaveChangesAsync();
                    await UpdateUI();
                }

                MessageBox.Show("New Supplier added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void addNewCategorybtn_Click(object sender, EventArgs e)
        {
            // VALIDATION: Prevent empty category names
            if (string.IsNullOrWhiteSpace(categoryName.Text))
            {
                MessageBox.Show("Please enter a Category Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Create the C# object
            Category newCategory = new Category() { CategoryName = categoryName.Text };

            try
            {
                // 2. Open the database connection
                using (var db = new SportRoomContext())
                {
                    // 3. Tell EF Core to track the new item
                    await db.Categories.AddAsync(newCategory);

                    // 4. Actually save it to SQLite (using await so the UI doesn't freeze!)
                    await db.SaveChangesAsync();
                    await UpdateUI();
                }

                MessageBox.Show("New Category added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding category: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void addNewEquipmentbtn_Click(object sender, EventArgs e)
        {
            // VALIDATION: Prevent empty equipment names and missing categories
            if (string.IsNullOrWhiteSpace(equipmentName.Text))
            {
                MessageBox.Show("Please enter an Equipment Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (categoryCombobox.SelectedValue == null)
            {
                MessageBox.Show("Please select a Category from the dropdown list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Create the C# object
            Equipment newEquipment = new Equipment()
            {
                Name = equipmentName.Text,
                CategoryId = (string)categoryCombobox.SelectedValue
            };

            try
            {
                // 2. Open the database connection
                using (var db = new SportRoomContext())
                {
                    // 3. Tell EF Core to track the new item
                    await db.Equipments.AddAsync(newEquipment);

                    // 4. Actually save it to SQLite (using await so the UI doesn't freeze!)
                    await db.SaveChangesAsync();
                    await UpdateUI();
                }

                MessageBox.Show("New Equipment added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding equipment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
