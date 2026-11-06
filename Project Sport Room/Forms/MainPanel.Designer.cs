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
            lblNewArrivals = new Label();
            label15 = new Label();
            panel7 = new Panel();
            lblOverdueLoans = new Label();
            label13 = new Label();
            panel6 = new Panel();
            lblActiveLoans = new Label();
            label11 = new Label();
            panel5 = new Panel();
            lblCatalogTypes = new Label();
            lableSomething = new Label();
            panel4 = new Panel();
            lblDamagedStock = new Label();
            label7 = new Label();
            panel2 = new Panel();
            lblBorrowedStock = new Label();
            label5 = new Label();
            panel1 = new Panel();
            lblAvailableStock = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblTotalStock = new Label();
            label3 = new Label();
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
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)damageReportGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel15, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(damageReportGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(reportGen, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.44444F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5555553F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 215F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
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
            tableLayoutPanel15.Location = new Point(3, 231);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new Size(936, 36);
            tableLayoutPanel15.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(71, 33);
            label1.TabIndex = 28;
            label1.Text = "Search";
            // 
            // txtSearchDamage
            // 
            txtSearchDamage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchDamage.BorderStyle = BorderStyle.FixedSingle;
            txtSearchDamage.Font = new Font("Montserrat", 9F);
            txtSearchDamage.Location = new Point(80, 7);
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
            tableLayoutPanel2.Size = new Size(936, 222);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlLightLight;
            panel8.Controls.Add(lblNewArrivals);
            panel8.Controls.Add(label15);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(705, 114);
            panel8.Name = "panel8";
            panel8.Size = new Size(228, 105);
            panel8.TabIndex = 11;
            // 
            // lblNewArrivals
            // 
            lblNewArrivals.AutoSize = true;
            lblNewArrivals.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblNewArrivals.ForeColor = Color.Brown;
            lblNewArrivals.Location = new Point(9, 42);
            lblNewArrivals.Name = "lblNewArrivals";
            lblNewArrivals.Size = new Size(88, 47);
            lblNewArrivals.TabIndex = 4;
            lblNewArrivals.Text = "N/A";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Montserrat", 9F);
            label15.Location = new Point(9, 8);
            label15.Name = "label15";
            label15.Size = new Size(103, 21);
            label15.TabIndex = 4;
            label15.Text = "New Arrivals";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLightLight;
            panel7.Controls.Add(lblOverdueLoans);
            panel7.Controls.Add(label13);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(471, 114);
            panel7.Name = "panel7";
            panel7.Size = new Size(228, 105);
            panel7.TabIndex = 10;
            // 
            // lblOverdueLoans
            // 
            lblOverdueLoans.AutoSize = true;
            lblOverdueLoans.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblOverdueLoans.ForeColor = Color.Brown;
            lblOverdueLoans.Location = new Point(9, 42);
            lblOverdueLoans.Name = "lblOverdueLoans";
            lblOverdueLoans.Size = new Size(88, 47);
            lblOverdueLoans.TabIndex = 4;
            lblOverdueLoans.Text = "N/A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Montserrat", 9F);
            label13.Location = new Point(9, 8);
            label13.Name = "label13";
            label13.Size = new Size(123, 21);
            label13.TabIndex = 4;
            label13.Text = "Overdue Loans";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(lblActiveLoans);
            panel6.Controls.Add(label11);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(237, 114);
            panel6.Name = "panel6";
            panel6.Size = new Size(228, 105);
            panel6.TabIndex = 9;
            // 
            // lblActiveLoans
            // 
            lblActiveLoans.AutoSize = true;
            lblActiveLoans.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblActiveLoans.ForeColor = Color.Brown;
            lblActiveLoans.Location = new Point(9, 42);
            lblActiveLoans.Name = "lblActiveLoans";
            lblActiveLoans.Size = new Size(88, 47);
            lblActiveLoans.TabIndex = 4;
            lblActiveLoans.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 9F);
            label11.Location = new Point(9, 8);
            label11.Name = "label11";
            label11.Size = new Size(104, 21);
            label11.TabIndex = 4;
            label11.Text = "Active Loans";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(lblCatalogTypes);
            panel5.Controls.Add(lableSomething);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 114);
            panel5.Name = "panel5";
            panel5.Size = new Size(228, 105);
            panel5.TabIndex = 8;
            // 
            // lblCatalogTypes
            // 
            lblCatalogTypes.AutoSize = true;
            lblCatalogTypes.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblCatalogTypes.ForeColor = Color.Brown;
            lblCatalogTypes.Location = new Point(9, 42);
            lblCatalogTypes.Name = "lblCatalogTypes";
            lblCatalogTypes.Size = new Size(88, 47);
            lblCatalogTypes.TabIndex = 4;
            lblCatalogTypes.Text = "N/A";
            // 
            // lableSomething
            // 
            lableSomething.AutoSize = true;
            lableSomething.Font = new Font("Montserrat", 9F);
            lableSomething.Location = new Point(9, 8);
            lableSomething.Name = "lableSomething";
            lableSomething.Size = new Size(114, 21);
            lableSomething.TabIndex = 4;
            lableSomething.Text = "Catalog Types";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(lblDamagedStock);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(705, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 105);
            panel4.TabIndex = 7;
            // 
            // lblDamagedStock
            // 
            lblDamagedStock.AutoSize = true;
            lblDamagedStock.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblDamagedStock.ForeColor = Color.Brown;
            lblDamagedStock.Location = new Point(9, 42);
            lblDamagedStock.Name = "lblDamagedStock";
            lblDamagedStock.Size = new Size(88, 47);
            lblDamagedStock.TabIndex = 4;
            lblDamagedStock.Text = "N/A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 9F);
            label7.Location = new Point(9, 8);
            label7.Name = "label7";
            label7.Size = new Size(130, 21);
            label7.TabIndex = 4;
            label7.Text = "Damaged Stock";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(lblBorrowedStock);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(471, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 105);
            panel2.TabIndex = 6;
            // 
            // lblBorrowedStock
            // 
            lblBorrowedStock.AutoSize = true;
            lblBorrowedStock.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblBorrowedStock.ForeColor = Color.Brown;
            lblBorrowedStock.Location = new Point(9, 42);
            lblBorrowedStock.Name = "lblBorrowedStock";
            lblBorrowedStock.Size = new Size(88, 47);
            lblBorrowedStock.TabIndex = 4;
            lblBorrowedStock.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 9F);
            label5.Location = new Point(9, 8);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 4;
            label5.Text = "Borrowed Stock";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lblAvailableStock);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(237, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 105);
            panel1.TabIndex = 5;
            // 
            // lblAvailableStock
            // 
            lblAvailableStock.AutoSize = true;
            lblAvailableStock.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblAvailableStock.ForeColor = Color.Brown;
            lblAvailableStock.Location = new Point(9, 42);
            lblAvailableStock.Name = "lblAvailableStock";
            lblAvailableStock.Size = new Size(88, 47);
            lblAvailableStock.TabIndex = 4;
            lblAvailableStock.Text = "N/A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9F);
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 4;
            label2.Text = "Available Stock";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(lblTotalStock);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 105);
            panel3.TabIndex = 4;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Montserrat Black", 20F, FontStyle.Bold);
            lblTotalStock.ForeColor = Color.Brown;
            lblTotalStock.Location = new Point(9, 42);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(88, 47);
            lblTotalStock.TabIndex = 4;
            lblTotalStock.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 9F);
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "Total stock";
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
            damageReportGrid.Location = new Point(3, 273);
            damageReportGrid.Name = "damageReportGrid";
            damageReportGrid.RowHeadersVisible = false;
            damageReportGrid.RowHeadersWidth = 51;
            damageReportGrid.Size = new Size(936, 209);
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
            reportGen.Location = new Point(3, 488);
            reportGen.Name = "reportGen";
            reportGen.Size = new Size(936, 30);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}