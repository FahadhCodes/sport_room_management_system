namespace Project_Sport_Room
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            supplierPhoneNumber = new TextBox();
            supplierName = new TextBox();
            label3 = new Label();
            addSupplierBtn1 = new Button();
            label4 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            label7 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            categoryName = new TextBox();
            addNewCategorybtn = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            equipmentName = new TextBox();
            label8 = new Label();
            categoryCombobox = new ComboBox();
            addNewEquipmentbtn = new Button();
            label9 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            totalSuppliers = new Label();
            label11 = new Label();
            panel4 = new Panel();
            totalEquipmentTypes = new Label();
            label15 = new Label();
            panel5 = new Panel();
            totalCategory = new Label();
            label17 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 109);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding new supplier";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(supplierPhoneNumber, 3, 0);
            tableLayoutPanel1.Controls.Add(supplierName, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(addSupplierBtn1, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(954, 84);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(89, 42);
            label1.TabIndex = 17;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // supplierPhoneNumber
            // 
            supplierPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            supplierPhoneNumber.Dock = DockStyle.Fill;
            supplierPhoneNumber.Location = new Point(574, 3);
            supplierPhoneNumber.Name = "supplierPhoneNumber";
            supplierPhoneNumber.Size = new Size(377, 26);
            supplierPhoneNumber.TabIndex = 21;
            // 
            // supplierName
            // 
            supplierName.BorderStyle = BorderStyle.FixedSingle;
            supplierName.Dock = DockStyle.Fill;
            supplierName.Location = new Point(98, 3);
            supplierName.Name = "supplierName";
            supplierName.Size = new Size(280, 26);
            supplierName.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(384, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 7, 0, 0);
            label3.Size = new Size(184, 42);
            label3.TabIndex = 18;
            label3.Text = "Phone Number";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // addSupplierBtn1
            // 
            addSupplierBtn1.Dock = DockStyle.Right;
            addSupplierBtn1.Location = new Point(857, 45);
            addSupplierBtn1.Name = "addSupplierBtn1";
            addSupplierBtn1.Size = new Size(94, 36);
            addSupplierBtn1.TabIndex = 22;
            addSupplierBtn1.Text = "Add";
            addSupplierBtn1.UseVisualStyleBackColor = true;
            addSupplierBtn1.Click += addSupplierBtn1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(0, 18);
            label4.TabIndex = 19;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 128);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 19;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(categoryName, 1, 0);
            tableLayoutPanel2.Controls.Add(addNewCategorybtn, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(954, 85);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 7, 0, 0);
            label5.Size = new Size(153, 42);
            label5.TabIndex = 17;
            label5.Text = "Name";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // categoryName
            // 
            categoryName.BorderStyle = BorderStyle.FixedSingle;
            categoryName.Dock = DockStyle.Fill;
            categoryName.Location = new Point(162, 3);
            categoryName.Name = "categoryName";
            categoryName.Size = new Size(789, 26);
            categoryName.TabIndex = 20;
            // 
            // addNewCategorybtn
            // 
            addNewCategorybtn.Dock = DockStyle.Right;
            addNewCategorybtn.Location = new Point(857, 45);
            addNewCategorybtn.Name = "addNewCategorybtn";
            addNewCategorybtn.Size = new Size(94, 37);
            addNewCategorybtn.TabIndex = 24;
            addNewCategorybtn.Text = "Add";
            addNewCategorybtn.UseVisualStyleBackColor = true;
            addNewCategorybtn.Click += addNewCategorybtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Controls.Add(label7);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 326);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(960, 110);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adding New Equipment Category Type";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Controls.Add(label9);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 442);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(960, 111);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Adding new Equipment Type";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(equipmentName, 1, 0);
            tableLayoutPanel3.Controls.Add(label8, 2, 0);
            tableLayoutPanel3.Controls.Add(categoryCombobox, 3, 0);
            tableLayoutPanel3.Controls.Add(addNewEquipmentbtn, 3, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(954, 86);
            tableLayoutPanel3.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 7, 0, 0);
            label6.Size = new Size(184, 43);
            label6.TabIndex = 17;
            label6.Text = "Name";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // equipmentName
            // 
            equipmentName.BorderStyle = BorderStyle.FixedSingle;
            equipmentName.Dock = DockStyle.Fill;
            equipmentName.Location = new Point(193, 3);
            equipmentName.Name = "equipmentName";
            equipmentName.Size = new Size(280, 26);
            equipmentName.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(479, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 7, 0, 0);
            label8.Size = new Size(184, 43);
            label8.TabIndex = 18;
            label8.Text = "Category";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // categoryCombobox
            // 
            categoryCombobox.Dock = DockStyle.Fill;
            categoryCombobox.FormattingEnabled = true;
            categoryCombobox.Location = new Point(669, 3);
            categoryCombobox.Name = "categoryCombobox";
            categoryCombobox.Size = new Size(282, 29);
            categoryCombobox.TabIndex = 21;
            // 
            // addNewEquipmentbtn
            // 
            addNewEquipmentbtn.Dock = DockStyle.Right;
            addNewEquipmentbtn.Location = new Point(857, 46);
            addNewEquipmentbtn.Name = "addNewEquipmentbtn";
            addNewEquipmentbtn.Size = new Size(94, 37);
            addNewEquipmentbtn.TabIndex = 25;
            addNewEquipmentbtn.Text = "Add";
            addNewEquipmentbtn.UseVisualStyleBackColor = true;
            addNewEquipmentbtn.Click += addNewEquipmentbtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 128);
            label9.Name = "label9";
            label9.Size = new Size(0, 18);
            label9.TabIndex = 19;
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Controls.Add(panel4, 1, 0);
            tableLayoutPanel4.Controls.Add(panel5, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(960, 202);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(totalSuppliers);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 196);
            panel3.TabIndex = 3;
            // 
            // totalSuppliers
            // 
            totalSuppliers.AutoSize = true;
            totalSuppliers.Font = new Font("Montserrat Black", 18F, FontStyle.Bold);
            totalSuppliers.ForeColor = Color.Brown;
            totalSuppliers.Location = new Point(9, 81);
            totalSuppliers.Name = "totalSuppliers";
            totalSuppliers.Size = new Size(78, 41);
            totalSuppliers.TabIndex = 4;
            totalSuppliers.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 9F);
            label11.Location = new Point(9, 8);
            label11.Name = "label11";
            label11.Size = new Size(112, 21);
            label11.TabIndex = 4;
            label11.Text = "Total Supplier";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(totalEquipmentTypes);
            panel4.Controls.Add(label15);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(322, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(313, 196);
            panel4.TabIndex = 5;
            // 
            // totalEquipmentTypes
            // 
            totalEquipmentTypes.AutoSize = true;
            totalEquipmentTypes.Font = new Font("Montserrat Black", 18F, FontStyle.Bold);
            totalEquipmentTypes.ForeColor = Color.Brown;
            totalEquipmentTypes.Location = new Point(9, 81);
            totalEquipmentTypes.Name = "totalEquipmentTypes";
            totalEquipmentTypes.Size = new Size(78, 41);
            totalEquipmentTypes.TabIndex = 4;
            totalEquipmentTypes.Text = "N/A";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Montserrat", 9F);
            label15.Location = new Point(9, 8);
            label15.Name = "label15";
            label15.Size = new Size(181, 21);
            label15.TabIndex = 4;
            label15.Text = "Total Equipment Types";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(totalCategory);
            panel5.Controls.Add(label17);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(641, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(316, 196);
            panel5.TabIndex = 6;
            // 
            // totalCategory
            // 
            totalCategory.AutoSize = true;
            totalCategory.Font = new Font("Montserrat Black", 18F, FontStyle.Bold);
            totalCategory.ForeColor = Color.Brown;
            totalCategory.Location = new Point(9, 81);
            totalCategory.Name = "totalCategory";
            totalCategory.Size = new Size(78, 41);
            totalCategory.TabIndex = 4;
            totalCategory.Text = "N/A";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Montserrat", 9F);
            label17.Location = new Point(9, 8);
            label17.Name = "label17";
            label17.Size = new Size(219, 21);
            label17.TabIndex = 4;
            label17.Text = "Total Equipment Categories";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel5.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel5.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel5.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 22);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 37.44589F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20.77922F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20.99567F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20.56277F));
            tableLayoutPanel5.Size = new Size(966, 556);
            tableLayoutPanel5.TabIndex = 25;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel5);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(972, 581);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add New Componets";
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 581);
            Controls.Add(groupBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add";
            Text = "Add New Componets";
            Load += Add_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label label4;
        private Label label3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox supplierName;
        private TextBox supplierPhoneNumber;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TextBox categoryName;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private TextBox equipmentName;
        private Label label8;
        private Label label9;
        private ComboBox categoryCombobox;
        private Button addSupplierBtn1;
        private Button addNewCategorybtn;
        private Button addNewEquipmentbtn;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private Label totalSuppliers;
        private Label label11;
        private Panel panel4;
        private Label totalEquipmentTypes;
        private Label label15;
        private Panel panel5;
        private Label totalCategory;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox4;
    }
}