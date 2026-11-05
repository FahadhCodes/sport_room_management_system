using Project_Sport_Room.Models;
using System;
using System.Windows.Forms;

namespace Project_Sport_Room
{
    public partial class Form1 : Form
    {
        // 1. Declare single, reusable instances of your forms at the top
        private OverviewForm _overviewForm;
        private InventoryForm _inventoryForm;
        private newIntake _newIntakeForm;
        private BorrowerForm _borrowerForm;
        private SupplierForm _supplierForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFormIntoPanel(Form childForm)
        {
            // 2. We don't need to destroy the forms anymore, just clear them from view
            MainPanel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(childForm);

            // 3. THIS line right here is what triggers the VisibleChanged event 
            // on your dashboards so they fetch fresh data!
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Automatically load the Overview screen when the app starts
            overviewbtn_Click_1(sender, e);
        }

        private void overviewbtn_Click_1(object sender, EventArgs e)
        {
            // Only create the form if it doesn't exist yet
            if (_overviewForm == null) _overviewForm = new OverviewForm();
            LoadFormIntoPanel(_overviewForm);
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            if (_inventoryForm == null) _inventoryForm = new InventoryForm();
            LoadFormIntoPanel(_inventoryForm);
        }

        private void newIntakebtn_Click(object sender, EventArgs e)
        {
            if (_newIntakeForm == null) _newIntakeForm = new newIntake();
            LoadFormIntoPanel(_newIntakeForm);
        }

        private void borrowerBtn_Click(object sender, EventArgs e)
        {
            if (_borrowerForm == null) _borrowerForm = new BorrowerForm();
            LoadFormIntoPanel(_borrowerForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_supplierForm == null) _supplierForm = new SupplierForm();
            LoadFormIntoPanel(_supplierForm);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}