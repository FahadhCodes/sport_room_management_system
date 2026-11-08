using Project_Sport_Room.Models;
using Project_Sport_Room.Services;
using Project_Sport_Room.Theme;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_Sport_Room
{
    public partial class Form1 : Form
    {
        private void ApplyModernTheme()
        {
            // Rounded sidebar
            ThemeManager.ApplyRoundedPanel(panel2, 18);

            // Rounded content workspace
            ThemeManager.ApplyRoundedPanel(MainPanel, 18);
            // Main window
            this.BackColor = ThemeColors.PageBackground;

            // Sidebar
            panel2.BackColor = ThemeColors.SidebarBackground;

            tableLayoutPanel3.BackColor =
                ThemeColors.SidebarBackground;

            // Workspace heading
            label11.ForeColor = Color.White;
            label11.Font = ThemeManager.SectionTitleFont;

            // Main content background
            tableLayoutPanel1.BackColor = ThemeColors.PageBackground;

            tableLayoutPanel2.BackColor = ThemeColors.PageBackground;

            MainPanel.BackColor = ThemeColors.PageBackground;

            // Navigation buttons
            SetActiveNavigationButton(home);
        }

        private void SetActiveNavigationButton(Button activeButton)
        {
            Button[] navigationButtons =
            {
                home,
                overviewbtn,
                inventorybtn,
                newIntakebtn,
                button1,
                borrowerBtn
            };

            foreach (Button button in navigationButtons)
            {
                ThemeManager.StyleNavigationButton(
                    button,
                    button == activeButton
                );
            }
        }

        // 1. Declare single, reusable instances of your forms at the top
        private Project_Sport_Room.Forms.MainPanel? _homeForm;
        private OverviewForm? _overviewForm;
        private InventoryForm? _inventoryForm;
        private newIntake? _newIntakeForm;
        private BorrowerForm? _borrowerForm;
        private SupplierForm? _supplierForm;

        public Form1()
        {
            InitializeComponent();
            ThemeManager.StyleActionButton(restore, ActionButtonVariant.Primary);
            ThemeManager.StyleActionButton(backup, ActionButtonVariant.Primary);

            // Wire backup and restore actions
            backup.Click += backup_Click;
            restore.Click += restore_Click;
            this.FormClosing += Form1_FormClosing;
        }

        private void LoadFormIntoPanel(Form childForm)
        {
            // Clear current controls from workspace
            MainPanel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(childForm);

            // This line triggers VisibleChanged on the child form so it fetches fresh data
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyModernTheme();
            // Automatically load the Home dashboard when the application starts
            home_Click(sender, e);
        }

        private void home_Click(object sender, EventArgs e)
        {
            if (_homeForm == null) _homeForm = new Project_Sport_Room.Forms.MainPanel();
            LoadFormIntoPanel(_homeForm);
            SetActiveNavigationButton(home);
        }

        private void overviewbtn_Click_1(object sender, EventArgs e)
        {
            if (_overviewForm == null) _overviewForm = new OverviewForm();
            LoadFormIntoPanel(_overviewForm);
            SetActiveNavigationButton(overviewbtn);
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            if (_inventoryForm == null) _inventoryForm = new InventoryForm();
            LoadFormIntoPanel(_inventoryForm);
            SetActiveNavigationButton(inventorybtn);
        }

        private void newIntakebtn_Click(object sender, EventArgs e)
        {
            if (_newIntakeForm == null) _newIntakeForm = new newIntake();
            LoadFormIntoPanel(_newIntakeForm);
            SetActiveNavigationButton(newIntakebtn);
        }

        private void borrowerBtn_Click(object sender, EventArgs e)
        {
            if (_borrowerForm == null) _borrowerForm = new BorrowerForm();
            LoadFormIntoPanel(_borrowerForm);
            SetActiveNavigationButton(borrowerBtn);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_supplierForm == null) _supplierForm = new SupplierForm();
            LoadFormIntoPanel(_supplierForm);
            SetActiveNavigationButton(button1);
        }

        private async void backup_Click(object? sender, EventArgs e)
        {
            try
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Title = "Backup System Database";
                    sfd.Filter = "SQLite Database (*.db)|*.db|All Files (*.*)|*.*";
                    sfd.FileName = $"SportRoom_Backup_{DateTime.Now:yyyy-MM-dd_HHmm}.db";
                    sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        backup.Enabled = false;

                        await DatabaseBackupService.BackupDatabaseAsync(sfd.FileName);

                        MessageBox.Show(
                            $"Database successfully backed up to:\n\n{sfd.FileName}\n\nYou can keep this file safe on a USB drive, external disk, or cloud storage.",
                            "Backup Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating database backup: {ex.Message}", "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                backup.Enabled = true;
            }
        }

        private async void restore_Click(object? sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show(
                    "Restoring will replace the current system data with the selected backup file.\n\n" +
                    "Before restoring, an automatic safety copy of your current database will be saved in the 'Backups' folder.\n\n" +
                    "Are you sure you want to proceed with database restore?",
                    "Confirm Database Restore",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult != DialogResult.Yes) return;

                using (var ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select Backup Database File to Restore";
                    ofd.Filter = "SQLite Database (*.db)|*.db|All Files (*.*)|*.*";
                    ofd.InitialDirectory = DatabaseBackupService.GetDefaultBackupDirectory();

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        restore.Enabled = false;
                        backup.Enabled = false;

                        await DatabaseBackupService.RestoreDatabaseAsync(ofd.FileName);

                        // Invalidate cached child forms so they reload with restored data
                        _homeForm = null;
                        _overviewForm = null;
                        _inventoryForm = null;
                        _newIntakeForm = null;
                        _borrowerForm = null;
                        _supplierForm = null;

                        // Reload Home view to reflect fresh data immediately
                        home_Click(sender ?? this, e);

                        MessageBox.Show(
                            "Database has been successfully restored!\n\n" +
                            "A safety copy of your previous data was saved automatically in the 'Backups' folder.",
                            "Restore Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restoring database: {ex.Message}", "Restore Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                restore.Enabled = true;
                backup.Enabled = true;
            }
        }

        private async void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            try
            {
                await DatabaseBackupService.CreateAutoBackupAsync("auto_exit");
            }
            catch
            {
                // Silent catch on exit to avoid blocking application shutdown
            }
        }
    }
}
