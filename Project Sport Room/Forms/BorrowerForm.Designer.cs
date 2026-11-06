namespace Project_Sport_Room
{
    partial class BorrowerForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            borrowerInfoTB = new DataGridView();
            borrName = new DataGridViewTextBoxColumn();
            borrowedItems = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            IssuedDate = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            ReturnedDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            BorrowReceipt = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            label1 = new Label();
            brrPhoneNumber = new Label();
            panel1 = new Panel();
            button2 = new Button();
            brrName = new Label();
            brrId = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            label2 = new Label();
            brrRole = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            brrEmail = new Label();
            label7 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            brrDept = new Label();
            label13 = new Label();
            tableLayoutPanel14 = new TableLayoutPanel();
            ItemsToReturn = new Label();
            label3 = new Label();
            panel2 = new Panel();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            filterableDates = new ComboBox();
            applyButton = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            label16 = new Label();
            tableLayoutPanel15 = new TableLayoutPanel();
            label11 = new Label();
            brrSearchfromData = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            reciptsData = new DataGridView();
            recipts = new DataGridViewTextBoxColumn();
            Returned = new DataGridViewCheckBoxColumn();
            borrList = new DataGridView();
            BorrowersList = new DataGridViewTextBoxColumn();
            tableLayoutPanel10 = new TableLayoutPanel();
            borrSearchFromList = new TextBox();
            label12 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowerInfoTB).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reciptsData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrList).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1153, 582);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(borrowerInfoTB, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel15, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(233, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.9523811F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9047623F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.1428566F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.Size = new Size(917, 576);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // borrowerInfoTB
            // 
            borrowerInfoTB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            borrowerInfoTB.BackgroundColor = SystemColors.Control;
            borrowerInfoTB.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            borrowerInfoTB.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            borrowerInfoTB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            borrowerInfoTB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowerInfoTB.Columns.AddRange(new DataGridViewColumn[] { borrName, borrowedItems, Qty, IssuedDate, DueDate, ReturnedDate, status, BorrowReceipt });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            borrowerInfoTB.DefaultCellStyle = dataGridViewCellStyle2;
            borrowerInfoTB.Dock = DockStyle.Fill;
            borrowerInfoTB.EnableHeadersVisualStyles = false;
            borrowerInfoTB.GridColor = Color.Brown;
            borrowerInfoTB.Location = new Point(3, 211);
            borrowerInfoTB.Name = "borrowerInfoTB";
            borrowerInfoTB.RowHeadersVisible = false;
            borrowerInfoTB.RowHeadersWidth = 51;
            borrowerInfoTB.Size = new Size(911, 323);
            borrowerInfoTB.TabIndex = 17;
            borrowerInfoTB.CellDoubleClick += borrowerInfoTB_CellDoubleClick;
            // 
            // borrName
            // 
            borrName.DataPropertyName = "borrName";
            borrName.HeaderText = "Borrower Name";
            borrName.MinimumWidth = 6;
            borrName.Name = "borrName";
            // 
            // borrowedItems
            // 
            borrowedItems.DataPropertyName = "borrowedItems";
            borrowedItems.HeaderText = "Borrowed Items";
            borrowedItems.MinimumWidth = 6;
            borrowedItems.Name = "borrowedItems";
            // 
            // Qty
            // 
            Qty.DataPropertyName = "Qty";
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            // 
            // IssuedDate
            // 
            IssuedDate.DataPropertyName = "IssuedDate";
            IssuedDate.HeaderText = "Issued Date";
            IssuedDate.MinimumWidth = 6;
            IssuedDate.Name = "IssuedDate";
            // 
            // DueDate
            // 
            DueDate.DataPropertyName = "DueDate";
            DueDate.HeaderText = "Due Date";
            DueDate.MinimumWidth = 6;
            DueDate.Name = "DueDate";
            // 
            // ReturnedDate
            // 
            ReturnedDate.DataPropertyName = "ReturnedDate";
            ReturnedDate.HeaderText = "Returned Date";
            ReturnedDate.MinimumWidth = 6;
            ReturnedDate.Name = "ReturnedDate";
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // BorrowReceipt
            // 
            BorrowReceipt.HeaderText = "BorrowReceipt";
            BorrowReceipt.MinimumWidth = 6;
            BorrowReceipt.Name = "BorrowReceipt";
            BorrowReceipt.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 2, 1);
            tableLayoutPanel3.Controls.Add(panel1, 2, 0);
            tableLayoutPanel3.Controls.Add(brrName, 0, 0);
            tableLayoutPanel3.Controls.Add(brrId, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 2, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel14, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(911, 106);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(label1, 0, 0);
            tableLayoutPanel9.Controls.Add(brrPhoneNumber, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(610, 38);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(297, 27);
            tableLayoutPanel9.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat SemiBold", 8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 27);
            label1.TabIndex = 2;
            label1.Text = "Phone";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brrPhoneNumber
            // 
            brrPhoneNumber.AutoSize = true;
            brrPhoneNumber.Dock = DockStyle.Fill;
            brrPhoneNumber.Font = new Font("Montserrat", 8F);
            brrPhoneNumber.ForeColor = Color.Black;
            brrPhoneNumber.Location = new Point(114, 0);
            brrPhoneNumber.Name = "brrPhoneNumber";
            brrPhoneNumber.Size = new Size(180, 27);
            brrPhoneNumber.TabIndex = 2;
            brrPhoneNumber.Text = "076XXXXXXX";
            brrPhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(610, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 27);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(209, 0);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 12;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // brrName
            // 
            brrName.AutoSize = true;
            brrName.Dock = DockStyle.Fill;
            brrName.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brrName.ForeColor = Color.Brown;
            brrName.Location = new Point(4, 1);
            brrName.Name = "brrName";
            brrName.Size = new Size(296, 33);
            brrName.TabIndex = 0;
            brrName.Text = "Name";
            brrName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // brrId
            // 
            brrId.AutoSize = true;
            brrId.Dock = DockStyle.Fill;
            brrId.Font = new Font("Montserrat", 7F);
            brrId.ForeColor = Color.Black;
            brrId.Location = new Point(4, 35);
            brrId.Name = "brrId";
            brrId.Size = new Size(296, 33);
            brrId.TabIndex = 9;
            brrId.Text = "BRR_001";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(label2, 0, 0);
            tableLayoutPanel7.Controls.Add(brrRole, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(610, 72);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(297, 30);
            tableLayoutPanel7.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Brown;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Montserrat SemiBold", 8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 2;
            label2.Text = "Role";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brrRole
            // 
            brrRole.AutoSize = true;
            brrRole.Dock = DockStyle.Fill;
            brrRole.Font = new Font("Montserrat", 8F);
            brrRole.ForeColor = Color.Black;
            brrRole.Location = new Point(114, 0);
            brrRole.Name = "brrRole";
            brrRole.Size = new Size(180, 30);
            brrRole.TabIndex = 2;
            brrRole.Text = "Student";
            brrRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(brrEmail, 1, 0);
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(307, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(296, 27);
            tableLayoutPanel4.TabIndex = 12;
            // 
            // brrEmail
            // 
            brrEmail.AutoSize = true;
            brrEmail.Dock = DockStyle.Fill;
            brrEmail.Font = new Font("Montserrat", 8F);
            brrEmail.ForeColor = Color.Black;
            brrEmail.Location = new Point(70, 0);
            brrEmail.Name = "brrEmail";
            brrEmail.Size = new Size(223, 27);
            brrEmail.TabIndex = 2;
            brrEmail.Text = "example@gmail.com";
            brrEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Brown;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Montserrat SemiBold", 8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 27);
            label7.TabIndex = 1;
            label7.Text = "Email";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(brrDept, 1, 0);
            tableLayoutPanel6.Controls.Add(label13, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(307, 38);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(296, 27);
            tableLayoutPanel6.TabIndex = 15;
            // 
            // brrDept
            // 
            brrDept.AutoSize = true;
            brrDept.Dock = DockStyle.Fill;
            brrDept.Font = new Font("Montserrat", 8F);
            brrDept.ForeColor = Color.Black;
            brrDept.Location = new Point(113, 0);
            brrDept.Name = "brrDept";
            brrDept.Size = new Size(180, 27);
            brrDept.TabIndex = 2;
            brrDept.Text = "PST";
            brrDept.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Brown;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Montserrat SemiBold", 8F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(104, 27);
            label13.TabIndex = 1;
            label13.Text = "Department";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.9729729F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.0270271F));
            tableLayoutPanel14.Controls.Add(ItemsToReturn, 1, 0);
            tableLayoutPanel14.Controls.Add(label3, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(307, 72);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(296, 30);
            tableLayoutPanel14.TabIndex = 13;
            // 
            // ItemsToReturn
            // 
            ItemsToReturn.AutoSize = true;
            ItemsToReturn.Dock = DockStyle.Fill;
            ItemsToReturn.Font = new Font("Montserrat", 8F);
            ItemsToReturn.ForeColor = Color.Black;
            ItemsToReturn.Location = new Point(145, 0);
            ItemsToReturn.Name = "ItemsToReturn";
            ItemsToReturn.Size = new Size(148, 30);
            ItemsToReturn.TabIndex = 3;
            ItemsToReturn.Text = "0";
            ItemsToReturn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Brown;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat SemiBold", 8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 2;
            label3.Text = "Borrowed Items";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel11);
            panel2.Controls.Add(label16);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(911, 90);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel11.Size = new Size(911, 90);
            tableLayoutPanel11.TabIndex = 36;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Controls.Add(filterableDates, 0, 0);
            tableLayoutPanel12.Controls.Add(applyButton, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2527466F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(905, 35);
            tableLayoutPanel12.TabIndex = 36;
            // 
            // filterableDates
            // 
            filterableDates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filterableDates.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterableDates.FormattingEnabled = true;
            filterableDates.Items.AddRange(new object[] { "Issued Date", "Due Date", "Returned Date" });
            filterableDates.Location = new Point(3, 3);
            filterableDates.Name = "filterableDates";
            filterableDates.Size = new Size(757, 29);
            filterableDates.TabIndex = 37;
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            applyButton.Font = new Font("Montserrat", 8F);
            applyButton.Location = new Point(766, 3);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(136, 29);
            applyButton.TabIndex = 36;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.80663F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.19337F));
            tableLayoutPanel13.Controls.Add(startDate, 0, 0);
            tableLayoutPanel13.Controls.Add(endDate, 1, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 44);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Size = new Size(905, 43);
            tableLayoutPanel13.TabIndex = 37;
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            startDate.CustomFormat = "dd/MM/yyyy     hh:mm tt";
            startDate.Font = new Font("Montserrat", 9F);
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(3, 3);
            startDate.Name = "startDate";
            startDate.Size = new Size(490, 26);
            startDate.TabIndex = 37;
            // 
            // endDate
            // 
            endDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            endDate.CustomFormat = "dd/MM/yyyy     hh:mm tt";
            endDate.Font = new Font("Montserrat", 9F);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(499, 3);
            endDate.Name = "endDate";
            endDate.Size = new Size(403, 26);
            endDate.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(264, 116);
            label16.Name = "label16";
            label16.Size = new Size(0, 21);
            label16.TabIndex = 30;
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.232711F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.76729F));
            tableLayoutPanel15.Controls.Add(label11, 0, 0);
            tableLayoutPanel15.Controls.Add(brrSearchfromData, 1, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 540);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new Size(911, 33);
            tableLayoutPanel15.TabIndex = 18;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 7, 0, 0);
            label11.Size = new Size(68, 33);
            label11.TabIndex = 28;
            label11.Text = "Search";
            // 
            // brrSearchfromData
            // 
            brrSearchfromData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            brrSearchfromData.BorderStyle = BorderStyle.FixedSingle;
            brrSearchfromData.Font = new Font("Montserrat", 9F);
            brrSearchfromData.Location = new Point(77, 4);
            brrSearchfromData.Name = "brrSearchfromData";
            brrSearchfromData.Size = new Size(831, 26);
            brrSearchfromData.TabIndex = 27;
            brrSearchfromData.TextChanged += brrSearchfromData_TextChanged;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(reciptsData, 0, 2);
            tableLayoutPanel8.Controls.Add(borrList, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel8.Controls.Add(button1, 0, 3);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0136986F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 86.9863F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 164F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(224, 576);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // reciptsData
            // 
            reciptsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reciptsData.BackgroundColor = SystemColors.Control;
            reciptsData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            reciptsData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            reciptsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            reciptsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reciptsData.Columns.AddRange(new DataGridViewColumn[] { recipts, Returned });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            reciptsData.DefaultCellStyle = dataGridViewCellStyle4;
            reciptsData.Dock = DockStyle.Fill;
            reciptsData.EnableHeadersVisualStyles = false;
            reciptsData.GridColor = Color.Brown;
            reciptsData.Location = new Point(3, 382);
            reciptsData.Name = "reciptsData";
            reciptsData.RowHeadersVisible = false;
            reciptsData.RowHeadersWidth = 51;
            reciptsData.Size = new Size(218, 158);
            reciptsData.TabIndex = 19;
            reciptsData.CellClick += reciptsData_CellClick;
            reciptsData.CellContentClick += reciptsData_CellContentClick;
            // 
            // recipts
            // 
            recipts.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            recipts.DataPropertyName = "recipts";
            recipts.HeaderText = "Recipts";
            recipts.MinimumWidth = 6;
            recipts.Name = "recipts";
            recipts.ReadOnly = true;
            // 
            // Returned
            // 
            Returned.DataPropertyName = "Returned";
            Returned.HeaderText = "Returned";
            Returned.MinimumWidth = 6;
            Returned.Name = "Returned";
            // 
            // borrList
            // 
            borrList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            borrList.BackgroundColor = SystemColors.Control;
            borrList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            borrList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle5.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Brown;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            borrList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            borrList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrList.Columns.AddRange(new DataGridViewColumn[] { BorrowersList });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            borrList.DefaultCellStyle = dataGridViewCellStyle6;
            borrList.Dock = DockStyle.Fill;
            borrList.EnableHeadersVisualStyles = false;
            borrList.GridColor = Color.Brown;
            borrList.Location = new Point(3, 52);
            borrList.Name = "borrList";
            borrList.ReadOnly = true;
            borrList.RowHeadersVisible = false;
            borrList.RowHeadersWidth = 51;
            borrList.Size = new Size(218, 324);
            borrList.TabIndex = 16;
            borrList.CellClick += borrList_CellClick;
            // 
            // BorrowersList
            // 
            BorrowersList.DataPropertyName = "borrnames";
            BorrowersList.HeaderText = "Borrower List";
            BorrowersList.MinimumWidth = 6;
            BorrowersList.Name = "BorrowersList";
            BorrowersList.ReadOnly = true;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.90909F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.09091F));
            tableLayoutPanel10.Controls.Add(borrSearchFromList, 1, 0);
            tableLayoutPanel10.Controls.Add(label12, 0, 0);
            tableLayoutPanel10.Location = new Point(3, 15);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(218, 31);
            tableLayoutPanel10.TabIndex = 17;
            // 
            // borrSearchFromList
            // 
            borrSearchFromList.BorderStyle = BorderStyle.FixedSingle;
            borrSearchFromList.Dock = DockStyle.Fill;
            borrSearchFromList.Font = new Font("Montserrat", 9F);
            borrSearchFromList.Location = new Point(70, 3);
            borrSearchFromList.Multiline = true;
            borrSearchFromList.Name = "borrSearchFromList";
            borrSearchFromList.Size = new Size(145, 25);
            borrSearchFromList.TabIndex = 30;
            borrSearchFromList.TextChanged += borrSearchFromList_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 7, 0, 0);
            label12.Size = new Size(61, 31);
            label12.TabIndex = 29;
            label12.Text = "Search";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 546);
            button1.Name = "button1";
            button1.Size = new Size(218, 27);
            button1.TabIndex = 18;
            button1.Text = "Borrow Equipments";
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
            groupBox1.Size = new Size(1159, 607);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borrowers";
            // 
            // BorrowerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 607);
            Controls.Add(groupBox1);
            Name = "BorrowerForm";
            Text = "BorrowerForm";
            Load += BorrowerForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)borrowerInfoTB).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reciptsData).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrList).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label brrName;
        private Label label7;
        private Label brrEmail;
        private Label brrId;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private DataGridView borrowerInfoTB;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel8;
        private DataGridView borrList;
        private TableLayoutPanel tableLayoutPanel10;
        private TextBox borrSearchFromList;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox brrSearchfromData;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel12;
        private GroupBox groupBox1;
        private Button button1;
        private DataGridViewTextBoxColumn BorrowersList;
        private DataGridView reciptsData;
        private TableLayoutPanel tableLayoutPanel15;
        private ComboBox filterableDates;
        private Button applyButton;
        private TableLayoutPanel tableLayoutPanel13;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private DataGridViewTextBoxColumn borrName;
        private DataGridViewTextBoxColumn borrowedItems;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn IssuedDate;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn ReturnedDate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn BorrowReceipt;
        private DataGridViewTextBoxColumn recipts;
        private DataGridViewCheckBoxColumn Returned;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel14;
        private Label ItemsToReturn;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label brrDept;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label1;
        private Label brrPhoneNumber;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label2;
        private Label brrRole;
    }
}