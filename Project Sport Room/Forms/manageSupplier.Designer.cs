namespace Project_Sport_Room
{
    partial class manageSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageSupplier));
            groupBox4 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            supplierTBspecific = new DataGridView();
            Intake_Id = new DataGridViewTextBoxColumn();
            Equipment = new DataGridViewTextBoxColumn();
            SuppliedDate = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            BrokenCount = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            totalEq = new Label();
            label11 = new Label();
            panel4 = new Panel();
            brokenEq = new Label();
            label15 = new Label();
            panel5 = new Panel();
            healthyEq = new Label();
            label17 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            phoneNO = new TextBox();
            label3 = new Label();
            label2 = new Label();
            supplierIdComboBox = new ComboBox();
            updateBtn = new Button();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            endDatePicker = new DateTimePicker();
            filterBtn = new Button();
            bottomDeleteBtn = new Button();
            startDatePicker = new DateTimePicker();
            groupBox4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplierTBspecific).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel5);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(880, 611);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Edit Suppliers";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(supplierTBspecific, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel5.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 22);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2689075F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9435329F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 58.8342438F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel5.Size = new Size(874, 586);
            tableLayoutPanel5.TabIndex = 25;
            // 
            // supplierTBspecific
            // 
            supplierTBspecific.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supplierTBspecific.BackgroundColor = SystemColors.Control;
            supplierTBspecific.BorderStyle = BorderStyle.None;
            supplierTBspecific.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            supplierTBspecific.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            supplierTBspecific.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            supplierTBspecific.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            supplierTBspecific.Columns.AddRange(new DataGridViewColumn[] { Intake_Id, Equipment, SuppliedDate, qty, BrokenCount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            supplierTBspecific.DefaultCellStyle = dataGridViewCellStyle2;
            supplierTBspecific.Dock = DockStyle.Fill;
            supplierTBspecific.EnableHeadersVisualStyles = false;
            supplierTBspecific.GridColor = Color.Brown;
            supplierTBspecific.Location = new Point(3, 223);
            supplierTBspecific.Name = "supplierTBspecific";
            supplierTBspecific.RowHeadersVisible = false;
            supplierTBspecific.RowHeadersWidth = 51;
            supplierTBspecific.Size = new Size(868, 308);
            supplierTBspecific.TabIndex = 25;
            supplierTBspecific.CellContentClick += supplierTBspecific_CellContentClick;
            supplierTBspecific.EditingControlShowing += supplierTBspecific_EditingControlShowing;
            // 
            // Intake_Id
            // 
            Intake_Id.HeaderText = "Intake Id";
            Intake_Id.MinimumWidth = 6;
            Intake_Id.Name = "Intake_Id";
            // 
            // Equipment
            // 
            Equipment.HeaderText = "Equipment Name";
            Equipment.MinimumWidth = 6;
            Equipment.Name = "Equipment";
            // 
            // SuppliedDate
            // 
            SuppliedDate.HeaderText = "Supplied Date";
            SuppliedDate.MinimumWidth = 6;
            SuppliedDate.Name = "SuppliedDate";
            // 
            // qty
            // 
            qty.HeaderText = "Healthy Equipment";
            qty.MinimumWidth = 6;
            qty.Name = "qty";
            // 
            // BrokenCount
            // 
            BrokenCount.HeaderText = "Broken Equipment";
            BrokenCount.MinimumWidth = 6;
            BrokenCount.Name = "BrokenCount";
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
            tableLayoutPanel4.Size = new Size(868, 113);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(totalEq);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 107);
            panel3.TabIndex = 3;
            // 
            // totalEq
            // 
            totalEq.AutoSize = true;
            totalEq.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            totalEq.ForeColor = Color.Brown;
            totalEq.Location = new Point(9, 40);
            totalEq.Name = "totalEq";
            totalEq.Size = new Size(65, 35);
            totalEq.TabIndex = 4;
            totalEq.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(9, 8);
            label11.Name = "label11";
            label11.Size = new Size(139, 18);
            label11.TabIndex = 4;
            label11.Text = "Total Supplied Items";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(brokenEq);
            panel4.Controls.Add(label15);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(292, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 107);
            panel4.TabIndex = 5;
            // 
            // brokenEq
            // 
            brokenEq.AutoSize = true;
            brokenEq.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            brokenEq.ForeColor = Color.Brown;
            brokenEq.Location = new Point(9, 40);
            brokenEq.Name = "brokenEq";
            brokenEq.Size = new Size(65, 35);
            brokenEq.TabIndex = 4;
            brokenEq.Text = "N/A";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(9, 8);
            label15.Name = "label15";
            label15.Size = new Size(96, 18);
            label15.TabIndex = 4;
            label15.Text = "Broken Items";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(healthyEq);
            panel5.Controls.Add(label17);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(581, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 107);
            panel5.TabIndex = 6;
            // 
            // healthyEq
            // 
            healthyEq.AutoSize = true;
            healthyEq.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            healthyEq.ForeColor = Color.Brown;
            healthyEq.Location = new Point(9, 40);
            healthyEq.Name = "healthyEq";
            healthyEq.Size = new Size(65, 35);
            healthyEq.TabIndex = 4;
            healthyEq.Text = "N/A";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(9, 8);
            label17.Name = "label17";
            label17.Size = new Size(99, 18);
            label17.TabIndex = 4;
            label17.Text = "Healthy Items";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(868, 95);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update supplier";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.24041F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.95908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6470585F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(phoneNO, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(supplierIdComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(updateBtn, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(862, 70);
            tableLayoutPanel1.TabIndex = 22;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // phoneNO
            // 
            phoneNO.BorderStyle = BorderStyle.FixedSingle;
            phoneNO.Dock = DockStyle.Fill;
            phoneNO.Location = new Point(519, 3);
            phoneNO.Name = "phoneNO";
            phoneNO.Size = new Size(340, 26);
            phoneNO.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(367, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 7, 0, 0);
            label3.Size = new Size(146, 35);
            label3.TabIndex = 26;
            label3.Text = "Phone Number";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 7, 0, 0);
            label2.Size = new Size(134, 35);
            label2.TabIndex = 24;
            label2.Text = "Supplier Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // supplierIdComboBox
            // 
            supplierIdComboBox.Dock = DockStyle.Fill;
            supplierIdComboBox.FormattingEnabled = true;
            supplierIdComboBox.Location = new Point(143, 3);
            supplierIdComboBox.Name = "supplierIdComboBox";
            supplierIdComboBox.Size = new Size(218, 29);
            supplierIdComboBox.TabIndex = 25;
            supplierIdComboBox.SelectedValueChanged += supplierIdComboBox_SelectedValueChanged;
            // 
            // updateBtn
            // 
            updateBtn.Dock = DockStyle.Right;
            updateBtn.Location = new Point(765, 38);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 28;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.85451F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.14549F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.Controls.Add(endDatePicker, 1, 0);
            tableLayoutPanel2.Controls.Add(filterBtn, 2, 0);
            tableLayoutPanel2.Controls.Add(bottomDeleteBtn, 3, 0);
            tableLayoutPanel2.Controls.Add(startDatePicker, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 537);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(868, 46);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // endDatePicker
            // 
            endDatePicker.CalendarFont = new Font("Montserrat", 10F);
            endDatePicker.CustomFormat = "dd/MM/yyyy     hh:mm  tt";
            endDatePicker.Dock = DockStyle.Top;
            endDatePicker.Font = new Font("Montserrat", 8F);
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.Location = new Point(371, 3);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(323, 24);
            endDatePicker.TabIndex = 32;
            // 
            // filterBtn
            // 
            filterBtn.Dock = DockStyle.Top;
            filterBtn.Font = new Font("Montserrat", 8F);
            filterBtn.Location = new Point(700, 3);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(84, 25);
            filterBtn.TabIndex = 29;
            filterBtn.Text = "Filter";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += filterBtn_Click;
            // 
            // bottomDeleteBtn
            // 
            bottomDeleteBtn.Dock = DockStyle.Top;
            bottomDeleteBtn.Font = new Font("Montserrat", 8F);
            bottomDeleteBtn.Location = new Point(790, 3);
            bottomDeleteBtn.Name = "bottomDeleteBtn";
            bottomDeleteBtn.Size = new Size(75, 25);
            bottomDeleteBtn.TabIndex = 30;
            bottomDeleteBtn.Text = "Delete";
            bottomDeleteBtn.UseVisualStyleBackColor = true;
            bottomDeleteBtn.Click += bottomDeleteBtn_Click;
            // 
            // startDatePicker
            // 
            startDatePicker.CalendarFont = new Font("Montserrat", 10F);
            startDatePicker.CustomFormat = "dd/MM/yyyy     hh:mm  tt";
            startDatePicker.Dock = DockStyle.Top;
            startDatePicker.Font = new Font("Montserrat", 8F);
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(3, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(362, 24);
            startDatePicker.TabIndex = 31;
            // 
            // manageSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 611);
            Controls.Add(groupBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "manageSupplier";
            Text = "Manage Supplier";
            Load += manageSupplier_Load;
            groupBox4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)supplierTBspecific).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private Label totalEq;
        private Label label11;
        private Panel panel4;
        private Label brokenEq;
        private Label label15;
        private Panel panel5;
        private Label healthyEq;
        private Label label17;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label2;
        private DataGridView supplierTBspecific;
        private ComboBox supplierIdComboBox;
        private TextBox phoneNO;
        private Label label3;
        private Button updateBtn;
        private DataGridViewTextBoxColumn Intake_Id;
        private DataGridViewTextBoxColumn Equipment;
        private DataGridViewTextBoxColumn SuppliedDate;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn BrokenCount;
        private TableLayoutPanel tableLayoutPanel2;
        private Button filterBtn;
        private Button bottomDeleteBtn;
        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
    }
}