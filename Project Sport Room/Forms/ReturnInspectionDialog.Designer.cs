namespace Project_Sport_Room
{
    partial class ReturnInspectionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnInspectionDialog));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            lost = new Label();
            label8 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            dmgs = new Label();
            label14 = new Label();
            tableLayoutPanel14 = new TableLayoutPanel();
            healthy = new Label();
            label16 = new Label();
            tableLayoutPanel15 = new TableLayoutPanel();
            label17 = new Label();
            summary = new Label();
            borrowingList = new DataGridView();
            EquipmentName = new DataGridViewComboBoxColumn();
            brrQty = new DataGridViewTextBoxColumn();
            BrokenQty = new DataGridViewTextBoxColumn();
            ReturnedQty = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            returnedDate = new Label();
            label6 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            dueDate = new Label();
            label5 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            issuedDate = new Label();
            label4 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            departmentLbl = new Label();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            role = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            borrowerName = new Label();
            genDmgReport = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowingList).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(973, 568);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Process Loan Return & Damage Inspection";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 0, 2);
            tableLayoutPanel1.Controls.Add(borrowingList, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(genDmgReport, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9034748F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.8400764F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1753368F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.707129F));
            tableLayoutPanel1.Size = new Size(967, 543);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 4;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 3, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel13, 2, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel14, 1, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel15, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 443);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(961, 54);
            tableLayoutPanel9.TabIndex = 26;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.12752F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8724823F));
            tableLayoutPanel10.Controls.Add(lost, 1, 0);
            tableLayoutPanel10.Controls.Add(label8, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(723, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(235, 48);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // lost
            // 
            lost.AutoSize = true;
            lost.Dock = DockStyle.Fill;
            lost.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lost.Location = new Point(165, 0);
            lost.Name = "lost";
            lost.Size = new Size(67, 48);
            lost.TabIndex = 3;
            lost.Text = "label7";
            lost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Brown;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 48);
            label8.TabIndex = 2;
            label8.Text = "Lost";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.12752F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8724823F));
            tableLayoutPanel13.Controls.Add(dmgs, 1, 0);
            tableLayoutPanel13.Controls.Add(label14, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(483, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(234, 48);
            tableLayoutPanel13.TabIndex = 2;
            // 
            // dmgs
            // 
            dmgs.AutoSize = true;
            dmgs.Dock = DockStyle.Fill;
            dmgs.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dmgs.Location = new Point(164, 0);
            dmgs.Name = "dmgs";
            dmgs.Size = new Size(67, 48);
            dmgs.TabIndex = 3;
            dmgs.Text = "label7";
            dmgs.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Brown;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(155, 48);
            label14.TabIndex = 2;
            label14.Text = "Damaged";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7860069F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2139931F));
            tableLayoutPanel14.Controls.Add(healthy, 1, 0);
            tableLayoutPanel14.Controls.Add(label16, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(243, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(234, 48);
            tableLayoutPanel14.TabIndex = 1;
            // 
            // healthy
            // 
            healthy.AutoSize = true;
            healthy.Dock = DockStyle.Fill;
            healthy.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            healthy.Location = new Point(152, 0);
            healthy.Name = "healthy";
            healthy.Size = new Size(79, 48);
            healthy.TabIndex = 2;
            healthy.Text = "label7";
            healthy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Brown;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(143, 48);
            label16.TabIndex = 1;
            label16.Text = "Healthy";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.78189F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.2181072F));
            tableLayoutPanel15.Controls.Add(label17, 0, 0);
            tableLayoutPanel15.Controls.Add(summary, 1, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 3);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new Size(234, 48);
            tableLayoutPanel15.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Brown;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label17.ForeColor = Color.White;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(159, 48);
            label17.TabIndex = 0;
            label17.Text = "Summary";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // summary
            // 
            summary.AutoSize = true;
            summary.Dock = DockStyle.Fill;
            summary.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            summary.Location = new Point(168, 0);
            summary.Name = "summary";
            summary.Size = new Size(63, 48);
            summary.TabIndex = 1;
            summary.Text = "label7";
            summary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // borrowingList
            // 
            borrowingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            borrowingList.BackgroundColor = SystemColors.Control;
            borrowingList.BorderStyle = BorderStyle.None;
            borrowingList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            borrowingList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            borrowingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            borrowingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowingList.Columns.AddRange(new DataGridViewColumn[] { EquipmentName, brrQty, BrokenQty, ReturnedQty });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            borrowingList.DefaultCellStyle = dataGridViewCellStyle2;
            borrowingList.Dock = DockStyle.Fill;
            borrowingList.EnableHeadersVisualStyles = false;
            borrowingList.GridColor = Color.Brown;
            borrowingList.Location = new Point(3, 137);
            borrowingList.Name = "borrowingList";
            borrowingList.RowHeadersVisible = false;
            borrowingList.RowHeadersWidth = 51;
            borrowingList.Size = new Size(961, 300);
            borrowingList.TabIndex = 25;
            // 
            // EquipmentName
            // 
            EquipmentName.HeaderText = "Equipment Name";
            EquipmentName.MinimumWidth = 6;
            EquipmentName.Name = "EquipmentName";
            EquipmentName.Resizable = DataGridViewTriState.True;
            EquipmentName.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // brrQty
            // 
            brrQty.HeaderText = "Borrowed Quantity";
            brrQty.MinimumWidth = 6;
            brrQty.Name = "brrQty";
            // 
            // BrokenQty
            // 
            BrokenQty.HeaderText = "Damaged Quantity";
            BrokenQty.MinimumWidth = 6;
            BrokenQty.Name = "BrokenQty";
            // 
            // ReturnedQty
            // 
            ReturnedQty.HeaderText = "Returned Quantity";
            ReturnedQty.MinimumWidth = 6;
            ReturnedQty.Name = "ReturnedQty";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 291F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 2, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(961, 128);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.46853F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.53147F));
            tableLayoutPanel8.Controls.Add(returnedDate, 1, 0);
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(673, 67);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(285, 58);
            tableLayoutPanel8.TabIndex = 5;
            // 
            // returnedDate
            // 
            returnedDate.AutoSize = true;
            returnedDate.Dock = DockStyle.Fill;
            returnedDate.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnedDate.Location = new Point(92, 0);
            returnedDate.Name = "returnedDate";
            returnedDate.Size = new Size(190, 58);
            returnedDate.TabIndex = 3;
            returnedDate.Text = "label7";
            returnedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Brown;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 58);
            label6.TabIndex = 2;
            label6.Text = "Returned";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.6301365F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.3698654F));
            tableLayoutPanel7.Controls.Add(dueDate, 1, 0);
            tableLayoutPanel7.Controls.Add(label5, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(338, 67);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(329, 58);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // dueDate
            // 
            dueDate.AutoSize = true;
            dueDate.Dock = DockStyle.Fill;
            dueDate.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDate.Location = new Point(80, 0);
            dueDate.Name = "dueDate";
            dueDate.Size = new Size(246, 58);
            dueDate.TabIndex = 3;
            dueDate.Text = "label7";
            dueDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Brown;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 58);
            label5.TabIndex = 2;
            label5.Text = "Due";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8493156F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.15069F));
            tableLayoutPanel6.Controls.Add(issuedDate, 1, 0);
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 67);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(329, 58);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // issuedDate
            // 
            issuedDate.AutoSize = true;
            issuedDate.Dock = DockStyle.Fill;
            issuedDate.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issuedDate.Location = new Point(107, 0);
            issuedDate.Name = "issuedDate";
            issuedDate.Size = new Size(219, 58);
            issuedDate.TabIndex = 3;
            issuedDate.Text = "label7";
            issuedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Brown;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 58);
            label4.TabIndex = 2;
            label4.Text = "Issued";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.23077F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.76923F));
            tableLayoutPanel5.Controls.Add(departmentLbl, 1, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(673, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(285, 58);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // departmentLbl
            // 
            departmentLbl.AutoSize = true;
            departmentLbl.Dock = DockStyle.Fill;
            departmentLbl.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentLbl.Location = new Point(57, 0);
            departmentLbl.Name = "departmentLbl";
            departmentLbl.Size = new Size(225, 58);
            departmentLbl.TabIndex = 3;
            departmentLbl.Text = "label7";
            departmentLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Brown;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 58);
            label3.TabIndex = 2;
            label3.Text = "Dept";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.287672F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.712326F));
            tableLayoutPanel4.Controls.Add(role, 1, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(338, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(329, 58);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Dock = DockStyle.Fill;
            role.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            role.Location = new Point(79, 0);
            role.Name = "role";
            role.Size = new Size(247, 58);
            role.TabIndex = 2;
            role.Text = "label7";
            role.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Brown;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 58);
            label2.TabIndex = 1;
            label2.Text = "Role";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8493156F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.15069F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(borrowerName, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(329, 58);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 58);
            label1.TabIndex = 0;
            label1.Text = "Borrower";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // borrowerName
            // 
            borrowerName.AutoSize = true;
            borrowerName.Dock = DockStyle.Fill;
            borrowerName.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowerName.Location = new Point(107, 0);
            borrowerName.Name = "borrowerName";
            borrowerName.Size = new Size(219, 58);
            borrowerName.TabIndex = 1;
            borrowerName.Text = "label7";
            borrowerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genDmgReport
            // 
            genDmgReport.Dock = DockStyle.Fill;
            genDmgReport.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genDmgReport.Location = new Point(3, 503);
            genDmgReport.Name = "genDmgReport";
            genDmgReport.Size = new Size(961, 37);
            genDmgReport.TabIndex = 27;
            genDmgReport.Text = "Generate Damage report";
            genDmgReport.UseVisualStyleBackColor = true;
            // 
            // ReturnInspectionDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 568);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReturnInspectionDialog";
            Text = "Return Inspection Dialog";
            Load += ReturnInspectionDialog_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)borrowingList).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Label label1;
        private Label returnedDate;
        private Label dueDate;
        private Label issuedDate;
        private Label departmentLbl;
        private Label role;
        private Label borrowerName;
        private DataGridView borrowingList;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel13;
        private Label dmgs;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel14;
        private Label healthy;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label17;
        private Label summary;
        private DataGridViewComboBoxColumn EquipmentName;
        private DataGridViewTextBoxColumn brrQty;
        private DataGridViewTextBoxColumn BrokenQty;
        private DataGridViewTextBoxColumn ReturnedQty;
        private TableLayoutPanel tableLayoutPanel10;
        private Label lost;
        private Label label8;
        private Button genDmgReport;
    }
}