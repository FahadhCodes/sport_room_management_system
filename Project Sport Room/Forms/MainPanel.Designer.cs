namespace Project_Sport_Room.Forms
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel15 = new TableLayoutPanel();
            label1 = new Label();
            txtSearchDamage = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            tableLayoutPanel10 = new TableLayoutPanel();
            label15 = new Label();
            lblNewArrivals = new Label();
            panel7 = new Panel();
            tableLayoutPanel9 = new TableLayoutPanel();
            label13 = new Label();
            lblOverdueLoans = new Label();
            panel6 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label11 = new Label();
            lblActiveLoans = new Label();
            panel5 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            lableSomething = new Label();
            lblCatalogTypes = new Label();
            panel4 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label7 = new Label();
            lblDamagedStock = new Label();
            panel2 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label5 = new Label();
            lblBorrowedStock = new Label();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            lblAvailableStock = new Label();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            lblTotalStock = new Label();
            damageReportGrid = new DataGridView();
            EquipmentId = new DataGridViewTextBoxColumn();
            Equipment = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            healthyQty = new DataGridViewTextBoxColumn();
            BrokenQty = new DataGridViewTextBoxColumn();
            totQty = new DataGridViewTextBoxColumn();
            reportGen = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)damageReportGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel15, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(damageReportGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(reportGen, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.96353F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.293666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.4491348F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.293666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(942, 521);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.232711F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.76729F));
            tableLayoutPanel15.Controls.Add(label1, 0, 0);
            tableLayoutPanel15.Controls.Add(txtSearchDamage, 1, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 206);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel15.Size = new Size(936, 32);
            tableLayoutPanel15.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(71, 31);
            label1.TabIndex = 28;
            label1.Text = "Search";
            // 
            // txtSearchDamage
            // 
            txtSearchDamage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchDamage.BorderStyle = BorderStyle.FixedSingle;
            txtSearchDamage.Font = new Font("Montserrat", 9F);
            txtSearchDamage.Location = new Point(80, 3);
            txtSearchDamage.Name = "txtSearchDamage";
            txtSearchDamage.Size = new Size(853, 26);
            txtSearchDamage.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel8, 3, 1);
            tableLayoutPanel2.Controls.Add(panel7, 2, 1);
            tableLayoutPanel2.Controls.Add(panel6, 1, 1);
            tableLayoutPanel2.Controls.Add(panel5, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 3, 0);
            tableLayoutPanel2.Controls.Add(panel2, 2, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(936, 197);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlLightLight;
            panel8.Controls.Add(tableLayoutPanel10);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(709, 105);
            panel8.Margin = new Padding(7);
            panel8.Name = "panel8";
            panel8.Size = new Size(220, 85);
            panel8.TabIndex = 11;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label15, 0, 0);
            tableLayoutPanel10.Controls.Add(lblNewArrivals, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(0, 0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0454559F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9545441F));
            tableLayoutPanel10.Size = new Size(220, 85);
            tableLayoutPanel10.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Montserrat", 9F);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(214, 35);
            label15.TabIndex = 4;
            label15.Text = "New Arrivals";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNewArrivals
            // 
            lblNewArrivals.AutoSize = true;
            lblNewArrivals.Dock = DockStyle.Fill;
            lblNewArrivals.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblNewArrivals.ForeColor = Color.Brown;
            lblNewArrivals.Location = new Point(3, 35);
            lblNewArrivals.Name = "lblNewArrivals";
            lblNewArrivals.Size = new Size(214, 50);
            lblNewArrivals.TabIndex = 4;
            lblNewArrivals.Text = "N/A";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLightLight;
            panel7.Controls.Add(tableLayoutPanel9);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(475, 105);
            panel7.Margin = new Padding(7);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 85);
            panel7.TabIndex = 10;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(label13, 0, 0);
            tableLayoutPanel9.Controls.Add(lblOverdueLoans, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0454559F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9545441F));
            tableLayoutPanel9.Size = new Size(220, 85);
            tableLayoutPanel9.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Montserrat", 9F);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(214, 35);
            label13.TabIndex = 4;
            label13.Text = "Overdue Loans";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOverdueLoans
            // 
            lblOverdueLoans.AutoSize = true;
            lblOverdueLoans.Dock = DockStyle.Fill;
            lblOverdueLoans.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblOverdueLoans.ForeColor = Color.Brown;
            lblOverdueLoans.Location = new Point(3, 35);
            lblOverdueLoans.Name = "lblOverdueLoans";
            lblOverdueLoans.Size = new Size(214, 50);
            lblOverdueLoans.TabIndex = 4;
            lblOverdueLoans.Text = "N/A";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(tableLayoutPanel8);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(241, 105);
            panel6.Margin = new Padding(7);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 85);
            panel6.TabIndex = 9;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label11, 0, 0);
            tableLayoutPanel8.Controls.Add(lblActiveLoans, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0454559F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9545441F));
            tableLayoutPanel8.Size = new Size(220, 85);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Montserrat", 9F);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(214, 35);
            label11.TabIndex = 4;
            label11.Text = "Active Loans";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblActiveLoans
            // 
            lblActiveLoans.AutoSize = true;
            lblActiveLoans.Dock = DockStyle.Fill;
            lblActiveLoans.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblActiveLoans.ForeColor = Color.Brown;
            lblActiveLoans.Location = new Point(3, 35);
            lblActiveLoans.Name = "lblActiveLoans";
            lblActiveLoans.Size = new Size(214, 50);
            lblActiveLoans.TabIndex = 4;
            lblActiveLoans.Text = "N/A";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(tableLayoutPanel7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(7, 105);
            panel5.Margin = new Padding(7);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 85);
            panel5.TabIndex = 8;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(lableSomething, 0, 0);
            tableLayoutPanel7.Controls.Add(lblCatalogTypes, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0454559F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9545441F));
            tableLayoutPanel7.Size = new Size(220, 85);
            tableLayoutPanel7.TabIndex = 6;
            // 
            // lableSomething
            // 
            lableSomething.AutoSize = true;
            lableSomething.Dock = DockStyle.Fill;
            lableSomething.Font = new Font("Montserrat", 9F);
            lableSomething.Location = new Point(3, 0);
            lableSomething.Name = "lableSomething";
            lableSomething.Size = new Size(214, 35);
            lableSomething.TabIndex = 4;
            lableSomething.Text = "Catalog Types";
            lableSomething.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCatalogTypes
            // 
            lblCatalogTypes.AutoSize = true;
            lblCatalogTypes.Dock = DockStyle.Fill;
            lblCatalogTypes.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblCatalogTypes.ForeColor = Color.Brown;
            lblCatalogTypes.Location = new Point(3, 35);
            lblCatalogTypes.Name = "lblCatalogTypes";
            lblCatalogTypes.Size = new Size(214, 50);
            lblCatalogTypes.TabIndex = 4;
            lblCatalogTypes.Text = "N/A";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(tableLayoutPanel6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(709, 7);
            panel4.Margin = new Padding(7);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 84);
            panel4.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label7, 0, 0);
            tableLayoutPanel6.Controls.Add(lblDamagedStock, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0454559F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9545441F));
            tableLayoutPanel6.Size = new Size(220, 84);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Montserrat", 9F);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(214, 35);
            label7.TabIndex = 4;
            label7.Text = "Damaged Stock";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDamagedStock
            // 
            lblDamagedStock.AutoSize = true;
            lblDamagedStock.Dock = DockStyle.Fill;
            lblDamagedStock.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblDamagedStock.ForeColor = Color.Brown;
            lblDamagedStock.Location = new Point(3, 35);
            lblDamagedStock.Name = "lblDamagedStock";
            lblDamagedStock.Size = new Size(214, 49);
            lblDamagedStock.TabIndex = 4;
            lblDamagedStock.Text = "N/A";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(475, 7);
            panel2.Margin = new Padding(7);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 84);
            panel2.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(lblBorrowedStock, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0454559F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9545441F));
            tableLayoutPanel5.Size = new Size(220, 84);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Montserrat", 9F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 35);
            label5.TabIndex = 4;
            label5.Text = "Borrowed Stock";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBorrowedStock
            // 
            lblBorrowedStock.AutoSize = true;
            lblBorrowedStock.Dock = DockStyle.Fill;
            lblBorrowedStock.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblBorrowedStock.ForeColor = Color.Brown;
            lblBorrowedStock.Location = new Point(3, 35);
            lblBorrowedStock.Name = "lblBorrowedStock";
            lblBorrowedStock.Size = new Size(214, 49);
            lblBorrowedStock.TabIndex = 4;
            lblBorrowedStock.Text = "N/A";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(241, 7);
            panel1.Margin = new Padding(7);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 84);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(lblAvailableStock, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0454559F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9545441F));
            tableLayoutPanel4.Size = new Size(220, 84);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Montserrat", 9F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 35);
            label2.TabIndex = 4;
            label2.Text = "Available Stock";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAvailableStock
            // 
            lblAvailableStock.AutoSize = true;
            lblAvailableStock.Dock = DockStyle.Fill;
            lblAvailableStock.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblAvailableStock.ForeColor = Color.Brown;
            lblAvailableStock.Location = new Point(3, 35);
            lblAvailableStock.Name = "lblAvailableStock";
            lblAvailableStock.Size = new Size(214, 49);
            lblAvailableStock.TabIndex = 4;
            lblAvailableStock.Text = "N/A";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 5);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 88);
            panel3.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(lblTotalStock, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0454559F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9545441F));
            tableLayoutPanel3.Size = new Size(224, 88);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat", 9F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(218, 37);
            label3.TabIndex = 4;
            label3.Text = "Total stock";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Dock = DockStyle.Fill;
            lblTotalStock.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblTotalStock.ForeColor = Color.Brown;
            lblTotalStock.Location = new Point(3, 37);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(218, 51);
            lblTotalStock.TabIndex = 4;
            lblTotalStock.Text = "N/A";
            // 
            // damageReportGrid
            // 
            damageReportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            damageReportGrid.BackgroundColor = SystemColors.Control;
            damageReportGrid.BorderStyle = BorderStyle.None;
            damageReportGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            damageReportGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            damageReportGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            damageReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            damageReportGrid.Columns.AddRange(new DataGridViewColumn[] { EquipmentId, Equipment, Category, healthyQty, BrokenQty, totQty });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            damageReportGrid.DefaultCellStyle = dataGridViewCellStyle2;
            damageReportGrid.Dock = DockStyle.Fill;
            damageReportGrid.EnableHeadersVisualStyles = false;
            damageReportGrid.GridColor = Color.Brown;
            damageReportGrid.Location = new Point(3, 244);
            damageReportGrid.Name = "damageReportGrid";
            damageReportGrid.RowHeadersVisible = false;
            damageReportGrid.RowHeadersWidth = 51;
            damageReportGrid.Size = new Size(936, 236);
            damageReportGrid.TabIndex = 27;
            // 
            // EquipmentId
            // 
            EquipmentId.HeaderText = "Equipment Id";
            EquipmentId.MinimumWidth = 6;
            EquipmentId.Name = "EquipmentId";
            // 
            // Equipment
            // 
            Equipment.HeaderText = "Equipment";
            Equipment.MinimumWidth = 6;
            Equipment.Name = "Equipment";
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // healthyQty
            // 
            healthyQty.HeaderText = "Healthy";
            healthyQty.MinimumWidth = 6;
            healthyQty.Name = "healthyQty";
            // 
            // BrokenQty
            // 
            BrokenQty.HeaderText = "Damaged";
            BrokenQty.MinimumWidth = 6;
            BrokenQty.Name = "BrokenQty";
            // 
            // totQty
            // 
            totQty.HeaderText = "Total Quantity";
            totQty.MinimumWidth = 6;
            totQty.Name = "totQty";
            // 
            // reportGen
            // 
            reportGen.Dock = DockStyle.Fill;
            reportGen.Location = new Point(3, 486);
            reportGen.Name = "reportGen";
            reportGen.Size = new Size(936, 32);
            reportGen.TabIndex = 29;
            reportGen.Text = "Generate Summaries Damage Report";
            reportGen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(948, 547);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Home";
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 547);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPanel";
            Text = "Main Panel";
            Load += MainPanel_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            panel7.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            panel6.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)damageReportGrid).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private Panel panel8;
        private Label lblNewArrivals;
        private Label label15;
        private Panel panel7;
        private Label lblOverdueLoans;
        private Label label13;
        private Panel panel6;
        private Label lblActiveLoans;
        private Label label11;
        private Panel panel5;
        private Label lblCatalogTypes;
        private Label lableSomething;
        private Panel panel4;
        private Label lblDamagedStock;
        private Label label7;
        private Panel panel2;
        private Label lblBorrowedStock;
        private Label label5;
        private Panel panel1;
        private Label lblAvailableStock;
        private Label label2;
        private Panel panel3;
        private Label lblTotalStock;
        private Label label3;
        private DataGridView damageReportGrid;
        private DataGridViewTextBoxColumn EquipmentId;
        private DataGridViewTextBoxColumn Equipment;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn healthyQty;
        private DataGridViewTextBoxColumn BrokenQty;
        private DataGridViewTextBoxColumn totQty;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label1;
        private TextBox txtSearchDamage;
        private Button reportGen;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel8;
    }
}