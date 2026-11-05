namespace Project_Sport_Room
{
    partial class InventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            EquipmentDataTable = new DataGridView();
            Equipment_Id = new DataGridViewTextBoxColumn();
            Equipment_Name = new DataGridViewTextBoxColumn();
            Equipment_Category = new DataGridViewTextBoxColumn();
            Qty_healthy = new DataGridViewTextBoxColumn();
            Qty_damaged = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            damagedEquipments = new Label();
            label8 = new Label();
            panel3 = new Panel();
            totalEquipmentTypes = new Label();
            label3 = new Label();
            panel6 = new Panel();
            TotQuantity = new Label();
            label10 = new Label();
            panel4 = new Panel();
            healthyEquipments = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            categoryCombobox = new ComboBox();
            label11 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)EquipmentDataTable).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EquipmentDataTable
            // 
            EquipmentDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EquipmentDataTable.BorderStyle = BorderStyle.None;
            EquipmentDataTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EquipmentDataTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EquipmentDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EquipmentDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EquipmentDataTable.Columns.AddRange(new DataGridViewColumn[] { Equipment_Id, Equipment_Name, Equipment_Category, Qty_healthy, Qty_damaged });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EquipmentDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            EquipmentDataTable.Dock = DockStyle.Fill;
            EquipmentDataTable.EnableHeadersVisualStyles = false;
            EquipmentDataTable.Location = new Point(3, 194);
            EquipmentDataTable.Name = "EquipmentDataTable";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            EquipmentDataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            EquipmentDataTable.RowHeadersVisible = false;
            EquipmentDataTable.RowHeadersWidth = 51;
            EquipmentDataTable.Size = new Size(990, 356);
            EquipmentDataTable.TabIndex = 14;
            // 
            // Equipment_Id
            // 
            Equipment_Id.HeaderText = "Equipment Id";
            Equipment_Id.MinimumWidth = 6;
            Equipment_Id.Name = "Equipment_Id";
            // 
            // Equipment_Name
            // 
            Equipment_Name.HeaderText = "Equipment Name";
            Equipment_Name.MinimumWidth = 6;
            Equipment_Name.Name = "Equipment_Name";
            // 
            // Equipment_Category
            // 
            Equipment_Category.HeaderText = "Equipment Category";
            Equipment_Category.MinimumWidth = 6;
            Equipment_Category.Name = "Equipment_Category";
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel5, 3, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(990, 144);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(damagedEquipments);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(744, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 138);
            panel5.TabIndex = 9;
            // 
            // damagedEquipments
            // 
            damagedEquipments.AutoSize = true;
            damagedEquipments.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            damagedEquipments.ForeColor = Color.Brown;
            damagedEquipments.Location = new Point(9, 66);
            damagedEquipments.Name = "damagedEquipments";
            damagedEquipments.Size = new Size(65, 35);
            damagedEquipments.TabIndex = 4;
            damagedEquipments.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 8);
            label8.Name = "label8";
            label8.Size = new Size(159, 18);
            label8.TabIndex = 4;
            label8.Text = "Damaged Equipments";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(totalEquipmentTypes);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 138);
            panel3.TabIndex = 3;
            // 
            // totalEquipmentTypes
            // 
            totalEquipmentTypes.AutoSize = true;
            totalEquipmentTypes.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            totalEquipmentTypes.ForeColor = Color.Brown;
            totalEquipmentTypes.Location = new Point(9, 66);
            totalEquipmentTypes.Name = "totalEquipmentTypes";
            totalEquipmentTypes.Size = new Size(65, 35);
            totalEquipmentTypes.TabIndex = 4;
            totalEquipmentTypes.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(123, 18);
            label3.TabIndex = 4;
            label3.Text = "Equipment Types";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(TotQuantity);
            panel6.Controls.Add(label10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(250, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(241, 138);
            panel6.TabIndex = 7;
            // 
            // TotQuantity
            // 
            TotQuantity.AutoSize = true;
            TotQuantity.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            TotQuantity.ForeColor = Color.Brown;
            TotQuantity.Location = new Point(9, 66);
            TotQuantity.Name = "TotQuantity";
            TotQuantity.Size = new Size(65, 35);
            TotQuantity.TabIndex = 4;
            TotQuantity.Text = "N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 8);
            label10.Name = "label10";
            label10.Size = new Size(182, 18);
            label10.TabIndex = 4;
            label10.Text = "Total Equipments Quantity";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(healthyEquipments);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(497, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 138);
            panel4.TabIndex = 8;
            // 
            // healthyEquipments
            // 
            healthyEquipments.AutoSize = true;
            healthyEquipments.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            healthyEquipments.ForeColor = Color.Brown;
            healthyEquipments.Location = new Point(9, 66);
            healthyEquipments.Name = "healthyEquipments";
            healthyEquipments.Size = new Size(65, 35);
            healthyEquipments.TabIndex = 4;
            healthyEquipments.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 8);
            label6.Name = "label6";
            label6.Size = new Size(143, 18);
            label6.TabIndex = 4;
            label6.Text = "Healthy Equipments";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Montserrat", 9F);
            textBox1.Location = new Point(112, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 26);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(103, 35);
            label1.TabIndex = 16;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // categoryCombobox
            // 
            categoryCombobox.Dock = DockStyle.Fill;
            categoryCombobox.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryCombobox.FormattingEnabled = true;
            categoryCombobox.Items.AddRange(new object[] { "Category 1", "Category 2", "Category 3", "Category 4", "Category 5" });
            categoryCombobox.Location = new Point(698, 3);
            categoryCombobox.Name = "categoryCombobox";
            categoryCombobox.Size = new Size(289, 29);
            categoryCombobox.TabIndex = 17;
            categoryCombobox.TextChanged += categoryCombobox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ImageAlign = ContentAlignment.TopCenter;
            label11.Location = new Point(494, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 7, 0, 0);
            label11.Size = new Size(198, 35);
            label11.TabIndex = 18;
            label11.Text = "Equipment Category";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.89899F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.7474747F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.58586F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.666666F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(categoryCombobox, 3, 0);
            tableLayoutPanel2.Controls.Add(label11, 2, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 153);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(990, 35);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Controls.Add(EquipmentDataTable, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7.594937F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65.28029F));
            tableLayoutPanel3.Size = new Size(996, 553);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1002, 578);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Equipment Invetory";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 578);
            Controls.Add(groupBox1);
            Name = "InventoryForm";
            Text = "InventoryForm";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)EquipmentDataTable).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView EquipmentDataTable;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label totalEquipmentTypes;
        private Label label3;
        private Panel panel6;
        private Label TotQuantity;
        private Label label10;
        private TextBox textBox1;
        private Label label1;
        private ComboBox categoryCombobox;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Equipment_Id;
        private DataGridViewTextBoxColumn Equipment_Name;
        private DataGridViewTextBoxColumn Equipment_Category;
        private DataGridViewTextBoxColumn Qty_healthy;
        private DataGridViewTextBoxColumn Qty_damaged;
        private Panel panel5;
        private Label damagedEquipments;
        private Label label8;
        private Panel panel4;
        private Label healthyEquipments;
        private Label label6;
    }
}