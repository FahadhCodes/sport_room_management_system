namespace Project_Sport_Room
{
    partial class addNewIntake
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
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            supplierIdComboBox = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Equipment_Id = new DataGridViewTextBoxColumn();
            Equipment_Name = new DataGridViewTextBoxColumn();
            Qty_healthy = new DataGridViewTextBoxColumn();
            Qty_damaged = new DataGridViewTextBoxColumn();
            label3 = new Label();
            categoryCombobox = new ComboBox();
            supplyBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            supplierPhoneLabel = new Label();
            supplierNameLabel = new Label();
            Date = new Label();
            dateTimePicker1 = new DateTimePicker();
            enterBtn = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem1 = new ToolStripMenuItem();
            equipmentToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // supplierIdComboBox
            // 
            supplierIdComboBox.Dock = DockStyle.Fill;
            supplierIdComboBox.FlatStyle = FlatStyle.System;
            supplierIdComboBox.Font = new Font("Montserrat", 9F);
            supplierIdComboBox.FormattingEnabled = true;
            supplierIdComboBox.Location = new Point(165, 3);
            supplierIdComboBox.Name = "supplierIdComboBox";
            supplierIdComboBox.Size = new Size(288, 29);
            supplierIdComboBox.TabIndex = 16;
            supplierIdComboBox.TextChanged += supplierIdComboBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat", 9F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(156, 34);
            label1.TabIndex = 17;
            label1.Text = "Supplier Id";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Equipment_Id, Equipment_Name, Qty_healthy, Qty_damaged });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(972, 301);
            dataGridView1.TabIndex = 18;
            // 
            // Equipment_Id
            // 
            Equipment_Id.HeaderText = "Equipment Id";
            Equipment_Id.MinimumWidth = 6;
            Equipment_Id.Name = "Equipment_Id";
            Equipment_Id.ReadOnly = true;
            // 
            // Equipment_Name
            // 
            Equipment_Name.HeaderText = "Equipment Name";
            Equipment_Name.MinimumWidth = 6;
            Equipment_Name.Name = "Equipment_Name";
            Equipment_Name.ReadOnly = true;
            // 
            // Qty_healthy
            // 
            Qty_healthy.HeaderText = "Healthy";
            Qty_healthy.MinimumWidth = 6;
            Qty_healthy.Name = "Qty_healthy";
            // 
            // Qty_damaged
            // 
            Qty_damaged.HeaderText = "Damaged";
            Qty_damaged.MinimumWidth = 6;
            Qty_damaged.Name = "Qty_damaged";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat", 9F);
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 7, 0, 0);
            label3.Size = new Size(156, 34);
            label3.TabIndex = 20;
            label3.Text = "Category";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // categoryCombobox
            // 
            categoryCombobox.Dock = DockStyle.Fill;
            categoryCombobox.Font = new Font("Montserrat", 9F);
            categoryCombobox.FormattingEnabled = true;
            categoryCombobox.Location = new Point(165, 37);
            categoryCombobox.Name = "categoryCombobox";
            categoryCombobox.Size = new Size(288, 29);
            categoryCombobox.TabIndex = 19;
            // 
            // supplyBtn
            // 
            supplyBtn.Dock = DockStyle.Right;
            supplyBtn.Font = new Font("Montserrat", 9F);
            supplyBtn.Location = new Point(825, 419);
            supplyBtn.Name = "supplyBtn";
            supplyBtn.Size = new Size(150, 32);
            supplyBtn.TabIndex = 24;
            supplyBtn.Text = "Supply";
            supplyBtn.UseVisualStyleBackColor = true;
            supplyBtn.Click += supplyBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2469139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.8024693F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9341564F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.4773664F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(supplierIdComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(categoryCombobox, 1, 1);
            tableLayoutPanel1.Controls.Add(supplierPhoneLabel, 5, 0);
            tableLayoutPanel1.Controls.Add(supplierNameLabel, 4, 0);
            tableLayoutPanel1.Controls.Add(Date, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 2);
            tableLayoutPanel1.Controls.Add(enterBtn, 5, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(972, 103);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // supplierPhoneLabel
            // 
            supplierPhoneLabel.AutoSize = true;
            supplierPhoneLabel.Dock = DockStyle.Fill;
            supplierPhoneLabel.Font = new Font("Montserrat", 9F);
            supplierPhoneLabel.Location = new Point(811, 0);
            supplierPhoneLabel.Name = "supplierPhoneLabel";
            supplierPhoneLabel.Size = new Size(158, 34);
            supplierPhoneLabel.TabIndex = 28;
            supplierPhoneLabel.Text = "[Phone_number]";
            supplierPhoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Dock = DockStyle.Fill;
            supplierNameLabel.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierNameLabel.ForeColor = Color.Brown;
            supplierNameLabel.Location = new Point(680, 0);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new Size(125, 34);
            supplierNameLabel.TabIndex = 27;
            supplierNameLabel.Text = "Name";
            supplierNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Dock = DockStyle.Fill;
            Date.Font = new Font("Montserrat", 9F);
            Date.Location = new Point(3, 68);
            Date.Name = "Date";
            Date.Padding = new Padding(0, 7, 0, 0);
            Date.Size = new Size(156, 35);
            Date.TabIndex = 29;
            Date.Text = "Date";
            Date.TextAlign = ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy  |   hh:mm tt";
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Montserrat", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(165, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 26);
            dateTimePicker1.TabIndex = 30;
            dateTimePicker1.Value = new DateTime(2026, 10, 31, 17, 22, 0, 0);
            // 
            // enterBtn
            // 
            enterBtn.Dock = DockStyle.Fill;
            enterBtn.Font = new Font("Montserrat", 9F);
            enterBtn.Location = new Point(811, 71);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(158, 29);
            enterBtn.TabIndex = 31;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 479);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Intake";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(supplyBtn, 0, 2);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.2019234F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 73.79808F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.Size = new Size(978, 454);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.2734375F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 94.72656F));
            tableLayoutPanel3.Size = new Size(990, 512);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addNewToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(990, 27);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(53, 23);
            addNewToolStripMenuItem.Text = "New";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { supplierToolStripMenuItem1, equipmentToolStripMenuItem1 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 23);
            editToolStripMenuItem.Text = "Edit";
            // 
            // supplierToolStripMenuItem1
            // 
            supplierToolStripMenuItem1.Name = "supplierToolStripMenuItem1";
            supplierToolStripMenuItem1.Size = new Size(164, 26);
            supplierToolStripMenuItem1.Text = "Supplier";
            supplierToolStripMenuItem1.Click += supplierToolStripMenuItem1_Click;
            // 
            // equipmentToolStripMenuItem1
            // 
            equipmentToolStripMenuItem1.Name = "equipmentToolStripMenuItem1";
            equipmentToolStripMenuItem1.Size = new Size(164, 26);
            equipmentToolStripMenuItem1.Text = "Equipment";
            // 
            // addNewIntake
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 512);
            Controls.Add(tableLayoutPanel3);
            MainMenuStrip = menuStrip1;
            Name = "addNewIntake";
            Text = "New Intake";
            Load += addNewIntake_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private ComboBox supplierIdComboBox;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox categoryCombobox;
        private Button supplyBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label supplierPhoneLabel;
        private Label supplierNameLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem1;
        private ToolStripMenuItem equipmentToolStripMenuItem1;
        private DataGridViewTextBoxColumn Equipment_Id;
        private DataGridViewTextBoxColumn Equipment_Name;
        private DataGridViewTextBoxColumn Qty_healthy;
        private DataGridViewTextBoxColumn Qty_damaged;
        private Label Date;
        private DateTimePicker dateTimePicker1;
        private Button enterBtn;
    }
}