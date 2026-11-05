namespace Project_Sport_Room
{
    partial class SupplierForm
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            supplierInfoTB = new DataGridView();
            IntakeId = new DataGridViewTextBoxColumn();
            SuppliedDate = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label9 = new Label();
            phoneNumaber = new Label();
            NameLable = new Label();
            suppIdLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            totLabel = new Label();
            button2 = new Button();
            panel2 = new Panel();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            label2 = new Label();
            applyDateFilterBtn = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            panel3 = new Panel();
            label11 = new Label();
            searchTextBox = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            button1 = new Button();
            suppliersTb = new DataGridView();
            SupplierList = new DataGridViewTextBoxColumn();
            tableLayoutPanel10 = new TableLayoutPanel();
            searchSupplier = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplierInfoTB).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliersTb).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1199, 597);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Supplier Panel";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0345421F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.9654541F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1193, 572);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(supplierInfoTB, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(242, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.6148415F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6077747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60.600708F));
            tableLayoutPanel2.Size = new Size(948, 566);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // supplierInfoTB
            // 
            supplierInfoTB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supplierInfoTB.BorderStyle = BorderStyle.None;
            supplierInfoTB.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            supplierInfoTB.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            supplierInfoTB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            supplierInfoTB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            supplierInfoTB.Columns.AddRange(new DataGridViewColumn[] { IntakeId, SuppliedDate, Supplier, Qty });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            supplierInfoTB.DefaultCellStyle = dataGridViewCellStyle2;
            supplierInfoTB.Dock = DockStyle.Fill;
            supplierInfoTB.EnableHeadersVisualStyles = false;
            supplierInfoTB.Location = new Point(3, 225);
            supplierInfoTB.Name = "supplierInfoTB";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            supplierInfoTB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            supplierInfoTB.RowHeadersVisible = false;
            supplierInfoTB.RowHeadersWidth = 51;
            supplierInfoTB.Size = new Size(942, 338);
            supplierInfoTB.TabIndex = 18;
            // 
            // IntakeId
            // 
            IntakeId.HeaderText = "Intake Id";
            IntakeId.MinimumWidth = 6;
            IntakeId.Name = "IntakeId";
            // 
            // SuppliedDate
            // 
            SuppliedDate.HeaderText = "Supplied Date";
            SuppliedDate.MinimumWidth = 6;
            SuppliedDate.Name = "SuppliedDate";
            // 
            // Supplier
            // 
            Supplier.HeaderText = "Supplier";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 2, 0);
            tableLayoutPanel3.Controls.Add(NameLable, 0, 0);
            tableLayoutPanel3.Controls.Add(suppIdLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Controls.Add(button2, 2, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 66.94215F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.05785F));
            tableLayoutPanel3.Size = new Size(942, 122);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(label9, 0, 0);
            tableLayoutPanel7.Controls.Add(phoneNumaber, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(630, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 45.20548F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 54.79452F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(308, 73);
            tableLayoutPanel7.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold);
            label9.ForeColor = Color.Brown;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 33);
            label9.TabIndex = 1;
            label9.Text = "Phone Number";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneNumaber
            // 
            phoneNumaber.AutoSize = true;
            phoneNumaber.Dock = DockStyle.Right;
            phoneNumaber.Font = new Font("Montserrat", 8F);
            phoneNumaber.ForeColor = Color.Black;
            phoneNumaber.Location = new Point(207, 33);
            phoneNumaber.Name = "phoneNumaber";
            phoneNumaber.Size = new Size(98, 40);
            phoneNumaber.TabIndex = 2;
            phoneNumaber.Text = "076XXXXXXX";
            phoneNumaber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLable
            // 
            NameLable.AutoSize = true;
            NameLable.Dock = DockStyle.Fill;
            NameLable.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLable.ForeColor = Color.Brown;
            NameLable.Location = new Point(4, 1);
            NameLable.Name = "NameLable";
            NameLable.Size = new Size(306, 79);
            NameLable.TabIndex = 0;
            NameLable.Text = "Name";
            NameLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // suppIdLabel
            // 
            suppIdLabel.AutoSize = true;
            suppIdLabel.Dock = DockStyle.Fill;
            suppIdLabel.Font = new Font("Montserrat", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suppIdLabel.ForeColor = Color.Black;
            suppIdLabel.Location = new Point(4, 81);
            suppIdLabel.Name = "suppIdLabel";
            suppIdLabel.Size = new Size(306, 40);
            suppIdLabel.TabIndex = 9;
            suppIdLabel.Text = "SUPP_001";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(totLabel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(317, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 43.8356171F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 56.1643829F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(306, 73);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 1;
            label3.Text = "Total Supplied Items";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totLabel
            // 
            totLabel.AutoSize = true;
            totLabel.Dock = DockStyle.Right;
            totLabel.Font = new Font("Montserrat", 8F);
            totLabel.ForeColor = Color.Black;
            totLabel.Location = new Point(285, 32);
            totLabel.Name = "totLabel";
            totLabel.Size = new Size(18, 41);
            totLabel.TabIndex = 2;
            totLabel.Text = "0";
            totLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(887, 84);
            button2.Name = "button2";
            button2.Size = new Size(51, 34);
            button2.TabIndex = 14;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel11);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 88);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 3;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.315099F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.13129F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.55361F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 2, 0);
            tableLayoutPanel11.Controls.Add(panel3, 0, 0);
            tableLayoutPanel11.Controls.Add(searchTextBox, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Size = new Size(942, 88);
            tableLayoutPanel11.TabIndex = 38;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Controls.Add(tableLayoutPanel14, 0, 0);
            tableLayoutPanel12.Controls.Add(tableLayoutPanel13, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(270, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(669, 82);
            tableLayoutPanel12.TabIndex = 36;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.16352F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.8364782F));
            tableLayoutPanel14.Controls.Add(label2, 0, 0);
            tableLayoutPanel14.Controls.Add(applyDateFilterBtn, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Size = new Size(663, 35);
            tableLayoutPanel14.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 7, 0, 0);
            label2.Size = new Size(565, 35);
            label2.TabIndex = 35;
            label2.Text = "Supplied Date Range";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // applyDateFilterBtn
            // 
            applyDateFilterBtn.Dock = DockStyle.Fill;
            applyDateFilterBtn.Font = new Font("Montserrat", 5F);
            applyDateFilterBtn.Location = new Point(574, 3);
            applyDateFilterBtn.Name = "applyDateFilterBtn";
            applyDateFilterBtn.Size = new Size(86, 29);
            applyDateFilterBtn.TabIndex = 34;
            applyDateFilterBtn.Text = "Apply";
            applyDateFilterBtn.UseVisualStyleBackColor = true;
            applyDateFilterBtn.Click += applyDateFilterBtn_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(startDatePicker, 0, 0);
            tableLayoutPanel13.Controls.Add(endDatePicker, 1, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 44);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Size = new Size(663, 35);
            tableLayoutPanel13.TabIndex = 31;
            // 
            // startDatePicker
            // 
            startDatePicker.CustomFormat = "dd/MM/yyyy hh:mm tt";
            startDatePicker.Dock = DockStyle.Fill;
            startDatePicker.Font = new Font("Montserrat", 9F);
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(3, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(325, 26);
            startDatePicker.TabIndex = 37;
            // 
            // endDatePicker
            // 
            endDatePicker.CustomFormat = "dd/MM/yyyy hh:mm tt";
            endDatePicker.Dock = DockStyle.Fill;
            endDatePicker.Font = new Font("Montserrat", 9F);
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.Location = new Point(334, 3);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(326, 26);
            endDatePicker.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(72, 82);
            panel3.TabIndex = 35;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 7, 0, 0);
            label11.Size = new Size(72, 82);
            label11.TabIndex = 28;
            label11.Text = "Search";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.Location = new Point(81, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(183, 26);
            searchTextBox.TabIndex = 27;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(button1, 0, 2);
            tableLayoutPanel8.Controls.Add(suppliersTb, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 7.047619F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 92.95238F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(233, 566);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 535);
            button1.Name = "button1";
            button1.Size = new Size(227, 28);
            button1.TabIndex = 18;
            button1.Text = "Add New Supplier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // suppliersTb
            // 
            suppliersTb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            suppliersTb.BorderStyle = BorderStyle.None;
            suppliersTb.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            suppliersTb.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            suppliersTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            suppliersTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliersTb.Columns.AddRange(new DataGridViewColumn[] { SupplierList });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            suppliersTb.DefaultCellStyle = dataGridViewCellStyle4;
            suppliersTb.Dock = DockStyle.Fill;
            suppliersTb.EnableHeadersVisualStyles = false;
            suppliersTb.Location = new Point(3, 40);
            suppliersTb.Name = "suppliersTb";
            suppliersTb.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            suppliersTb.RowHeadersVisible = false;
            suppliersTb.RowHeadersWidth = 51;
            suppliersTb.Size = new Size(227, 489);
            suppliersTb.TabIndex = 16;
            suppliersTb.CellClick += suppliersTb_CellClick;
            // 
            // SupplierList
            // 
            SupplierList.HeaderText = "Supplier List";
            SupplierList.MinimumWidth = 6;
            SupplierList.Name = "SupplierList";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.027523F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.97248F));
            tableLayoutPanel10.Controls.Add(searchSupplier, 1, 0);
            tableLayoutPanel10.Controls.Add(label12, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(227, 31);
            tableLayoutPanel10.TabIndex = 17;
            // 
            // searchSupplier
            // 
            searchSupplier.BorderStyle = BorderStyle.FixedSingle;
            searchSupplier.Dock = DockStyle.Fill;
            searchSupplier.Font = new Font("Montserrat", 9F);
            searchSupplier.Location = new Point(77, 3);
            searchSupplier.Multiline = true;
            searchSupplier.Name = "searchSupplier";
            searchSupplier.Size = new Size(147, 25);
            searchSupplier.TabIndex = 31;
            searchSupplier.TextChanged += searchSupplier_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 7, 0, 0);
            label12.Size = new Size(68, 31);
            label12.TabIndex = 29;
            label12.Text = "Search";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 597);
            Controls.Add(groupBox1);
            Name = "SupplierForm";
            Text = "Supplier Form";
            Load += SupplierForm_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)supplierInfoTB).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)suppliersTb).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel8;
        private DataGridView suppliersTb;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn SupplierList;
        private TableLayoutPanel tableLayoutPanel3;
        private Label NameLable;
        private Label suppIdLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label totLabel;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel14;
        private Button applyDateFilterBtn;
        private TableLayoutPanel tableLayoutPanel13;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Panel panel3;
        private Label label11;
        private TextBox searchTextBox;
        private DataGridView supplierInfoTB;
        private DataGridViewTextBoxColumn IntakeId;
        private DataGridViewTextBoxColumn SuppliedDate;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn Qty;
        private Label label2;
        private TextBox searchSupplier;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label9;
        private Label phoneNumaber;
        private Button button2;
        private Button button1;
    }
}