using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sport_Room.Forms
{
    public partial class equipmentEdit : Form
    {
        private readonly string? _equipmentId;
        private int _currentlyBorrowed = 0;
        private readonly ToolTip _toolTip = new ToolTip();

        // Parameterless constructor for WinForms designer support
        public equipmentEdit()
        {
            InitializeComponent();
            SetupForm();
        }

        // Main constructor used by InventoryForm when an equipment row is clicked
        public equipmentEdit(string selectedEquipmentId) : this()
        {
            _equipmentId = selectedEquipmentId;
        }

        private void SetupForm()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Support larger quantities without throwing ArgumentOutOfRangeException
            healthyQty.Minimum = 0;
            healthyQty.Maximum = 100000;
            dmg.Minimum = 0;
            dmg.Maximum = 100000;

            // Wire Enter and Escape keys for quick ergonomics
            this.AcceptButton = saveBtn;
            this.CancelButton = cancelBtn;

            // Wire events
            healthyQty.ValueChanged += (s, e) => UpdateTotalDisplay();
            healthyQty.KeyUp += (s, e) => UpdateTotalDisplay();
            dmg.ValueChanged += (s, e) => UpdateTotalDisplay();
            dmg.KeyUp += (s, e) => UpdateTotalDisplay();

            saveBtn.Click += saveBtn_Click;
            cancelBtn.Click += cancelBtn_Click;

            this.Load += equipmentEdit_Load;
        }

        private async void equipmentEdit_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_equipmentId)) return;

            try
            {
                using (var db = new SportRoomContext())
                {
                    var equipment = await db.Equipments
                        .Include(eq => eq.Category)
                        .FirstOrDefaultAsync(eq => eq.Id == _equipmentId);

                    if (equipment == null)
                    {
                        MessageBox.Show($"Equipment with ID '{_equipmentId}' was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                        return;
                    }

                    // Count items actively borrowed (unreturned loans)
                    _currentlyBorrowed = await db.BorrowedCombinations
                        .Where(bc => bc.EquipmentId == _equipmentId && bc.BorrowReceipt.ReturnedDate == null)
                        .SumAsync(bc => (int?)bc.Qty) ?? 0;

                    // Display details
                    equipmentId.Text = equipment.Id;
                    equipmentName.Text = equipment.Name;
                    equipmentCate.Text = equipment.Category?.CategoryName ?? "General";

                    // Set healthy and damaged stock values
                    int safeHealthy = Math.Max(0, equipment.Quantity);
                    int safeDamaged = Math.Max(0, equipment.BrokenQty);

                    healthyQty.Value = Math.Min(healthyQty.Maximum, safeHealthy);
                    dmg.Value = Math.Min(dmg.Maximum, safeDamaged);

                    UpdateTotalDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalDisplay()
        {
            int healthy = (int)healthyQty.Value;
            int damaged = (int)dmg.Value;
            int total = healthy + damaged + _currentlyBorrowed;

            if (_currentlyBorrowed > 0)
            {
                totQty.Text = $"{total} ({_currentlyBorrowed} borrowed)";
                _toolTip.SetToolTip(totQty, $"Available Healthy: {healthy}\nDamaged: {damaged}\nCurrently Borrowed: {_currentlyBorrowed}\nTotal Physical Stock: {total}");
            }
            else
            {
                totQty.Text = total.ToString();
                _toolTip.SetToolTip(totQty, $"Available Healthy: {healthy}\nDamaged: {damaged}\nTotal Physical Stock: {total}");
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            // Flush any typed text in the numeric up-down controls into .Value
            this.ValidateChildren();

            if (string.IsNullOrWhiteSpace(_equipmentId))
            {
                MessageBox.Show("No equipment is selected for editing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newHealthy = (int)healthyQty.Value;
            int newDamaged = (int)dmg.Value;

            if (newHealthy < 0 || newDamaged < 0)
            {
                MessageBox.Show("Quantities cannot be negative numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveBtn.Enabled = false;
            try
            {
                using (var db = new SportRoomContext())
                {
                    var equipment = await db.Equipments.FirstOrDefaultAsync(eq => eq.Id == _equipmentId);
                    if (equipment == null)
                    {
                        MessageBox.Show("Equipment record could not be found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    equipment.Quantity = newHealthy;
                    equipment.BrokenQty = newDamaged;

                    await db.SaveChangesAsync();
                }

                MessageBox.Show("Equipment quantities updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving equipment stock: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                saveBtn.Enabled = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
