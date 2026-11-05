namespace Project_Sport_Room
{
    partial class newIntake
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            intakeTable = new DataGridView();
            IntakeId = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            SuppliedEquipment = new DataGridViewTextBoxColumn();
            SuppliedDate = new DataGridViewTextBoxColumn();
            supplierTable = new DataGridView();
            Supplier_Id = new DataGridViewTextBoxColumn();
            Supplier_Name = new DataGridViewTextBoxColumn();
            SuppliedEquipQty = new DataGridViewTextBoxColumn();
            TotalIntakes = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)intakeTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierTable).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(intakeTable, 0, 1);
            tableLayoutPanel1.Controls.Add(supplierTable, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1009, 507);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // intakeTable
            // 
            intakeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            intakeTable.BorderStyle = BorderStyle.None;
            intakeTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            intakeTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            intakeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            intakeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            intakeTable.Columns.AddRange(new DataGridViewColumn[] { IntakeId, SupplierName, SuppliedEquipment, SuppliedDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            intakeTable.DefaultCellStyle = dataGridViewCellStyle2;
            intakeTable.Dock = DockStyle.Fill;
            intakeTable.EnableHeadersVisualStyles = false;
            intakeTable.Location = new Point(3, 256);
            intakeTable.Name = "intakeTable";
            intakeTable.RowHeadersVisible = false;
            intakeTable.RowHeadersWidth = 51;
            intakeTable.Size = new Size(902, 248);
            intakeTable.TabIndex = 17;
            // 
            // IntakeId
            // 
            IntakeId.HeaderText = "Intake Id";
            IntakeId.MinimumWidth = 6;
            IntakeId.Name = "IntakeId";
            // 
            // SupplierName
            // 
            SupplierName.HeaderText = "Supplier Name";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            // 
            // SuppliedEquipment
            // 
            SuppliedEquipment.HeaderText = "Supplied Equipment";
            SuppliedEquipment.MinimumWidth = 6;
            SuppliedEquipment.Name = "SuppliedEquipment";
            // 
            // SuppliedDate
            // 
            SuppliedDate.HeaderText = "Supplied Date";
            SuppliedDate.MinimumWidth = 6;
            SuppliedDate.Name = "SuppliedDate";
            // 
            // supplierTable
            // 
            supplierTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supplierTable.BorderStyle = BorderStyle.None;
            supplierTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            supplierTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            supplierTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            supplierTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            supplierTable.Columns.AddRange(new DataGridViewColumn[] { Supplier_Id, Supplier_Name, SuppliedEquipQty, TotalIntakes });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            supplierTable.DefaultCellStyle = dataGridViewCellStyle4;
            supplierTable.Dock = DockStyle.Fill;
            supplierTable.EnableHeadersVisualStyles = false;
            supplierTable.Location = new Point(3, 3);
            supplierTable.Name = "supplierTable";
            supplierTable.RowHeadersVisible = false;
            supplierTable.RowHeadersWidth = 51;
            supplierTable.Size = new Size(902, 247);
            supplierTable.TabIndex = 15;
            supplierTable.CellClick += supplierTable_CellClick;
            // 
            // Supplier_Id
            // 
            Supplier_Id.HeaderText = "Supplier Id";
            Supplier_Id.MinimumWidth = 6;
            Supplier_Id.Name = "Supplier_Id";
            // 
            // Supplier_Name
            // 
            Supplier_Name.HeaderText = "Supplier Name";
            Supplier_Name.MinimumWidth = 6;
            Supplier_Name.Name = "Supplier_Name";
            // 
            // SuppliedEquipQty
            // 
            SuppliedEquipQty.HeaderText = "Total Supplied Equipments";
            SuppliedEquipQty.MinimumWidth = 6;
            SuppliedEquipQty.Name = "SuppliedEquipQty";
            // 
            // TotalIntakes
            // 
            TotalIntakes.HeaderText = "Total Intakes";
            TotalIntakes.MinimumWidth = 6;
            TotalIntakes.Name = "TotalIntakes";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(911, 256);
            button2.Name = "button2";
            button2.Size = new Size(95, 248);
            button2.TabIndex = 18;
            button2.Text = "New Intake";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(911, 3);
            button1.Name = "button1";
            button1.Size = new Size(95, 247);
            button1.TabIndex = 16;
            button1.Text = "New Componets";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1015, 532);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Equipment Intake";
            // 
            // newIntake
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 532);
            Controls.Add(groupBox1);
            Name = "newIntake";
            Text = "newIntake";
            Load += newIntake_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)intakeTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierTable).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView supplierTable;
        private Button button1;
        private DataGridView intakeTable;
        private DataGridViewTextBoxColumn Supplier_Id;
        private DataGridViewTextBoxColumn Supplier_Name;
        private DataGridViewTextBoxColumn SuppliedEquipQty;
        private Button button2;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn TotalIntakes;
        private DataGridViewTextBoxColumn IntakeId;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn SuppliedEquipment;
        private DataGridViewTextBoxColumn SuppliedDate;
    }
}