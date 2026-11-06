namespace Project_Sport_Room
{
    partial class addBorrowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBorrowers));
            label2 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            borrowingList = new DataGridView();
            EquipmentName = new DataGridViewComboBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            BrokenQty = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            dueDatepicker = new DateTimePicker();
            dueDate = new Label();
            issuedDate = new Label();
            label5 = new Label();
            email = new TextBox();
            label3 = new Label();
            brrRoleCombobox = new ComboBox();
            brrName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            brrId = new TextBox();
            label6 = new Label();
            phoneNumber = new TextBox();
            label7 = new Label();
            departmentComboBox = new ComboBox();
            issueDatepicker = new DateTimePicker();
            addBtn = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowingList).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(913, 464);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding New Borrower";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(borrowingList, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(addBtn, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 39.2059555F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60.7940445F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(907, 439);
            tableLayoutPanel2.TabIndex = 24;
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
            borrowingList.Columns.AddRange(new DataGridViewColumn[] { EquipmentName, Qty, BrokenQty });
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
            borrowingList.Location = new Point(3, 161);
            borrowingList.Name = "borrowingList";
            borrowingList.RowHeadersVisible = false;
            borrowingList.RowHeadersWidth = 51;
            borrowingList.Size = new Size(901, 239);
            borrowingList.TabIndex = 24;
            borrowingList.DefaultValuesNeeded += borrowingList_DefaultValuesNeeded;
            borrowingList.EditingControlShowing += borrowingList_EditingControlShowing;
            // 
            // EquipmentName
            // 
            EquipmentName.HeaderText = "Equipment Name";
            EquipmentName.MinimumWidth = 6;
            EquipmentName.Name = "EquipmentName";
            EquipmentName.Resizable = DataGridViewTriState.True;
            EquipmentName.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Qty
            // 
            Qty.HeaderText = "Quantity";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            // 
            // BrokenQty
            // 
            BrokenQty.HeaderText = "Damaged";
            BrokenQty.MinimumWidth = 6;
            BrokenQty.Name = "BrokenQty";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.7658157F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.17869F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.6514988F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.6259727F));
            tableLayoutPanel1.Controls.Add(dueDatepicker, 3, 3);
            tableLayoutPanel1.Controls.Add(dueDate, 2, 3);
            tableLayoutPanel1.Controls.Add(issuedDate, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(email, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(brrRoleCombobox, 1, 1);
            tableLayoutPanel1.Controls.Add(brrName, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(brrId, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(phoneNumber, 3, 2);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(departmentComboBox, 3, 1);
            tableLayoutPanel1.Controls.Add(issueDatepicker, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0357132F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(901, 152);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // dueDatepicker
            // 
            dueDatepicker.CustomFormat = "dd/MM/yyyy  hh : mm tt";
            dueDatepicker.Dock = DockStyle.Fill;
            dueDatepicker.Font = new Font("Montserrat", 9F);
            dueDatepicker.Format = DateTimePickerFormat.Custom;
            dueDatepicker.Location = new Point(573, 115);
            dueDatepicker.Name = "dueDatepicker";
            dueDatepicker.Size = new Size(325, 26);
            dueDatepicker.TabIndex = 36;
            // 
            // dueDate
            // 
            dueDate.AutoSize = true;
            dueDate.Dock = DockStyle.Fill;
            dueDate.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDate.Location = new Point(451, 112);
            dueDate.Name = "dueDate";
            dueDate.Padding = new Padding(0, 8, 0, 0);
            dueDate.Size = new Size(116, 40);
            dueDate.TabIndex = 34;
            dueDate.Text = "Due Date";
            // 
            // issuedDate
            // 
            issuedDate.AutoSize = true;
            issuedDate.Dock = DockStyle.Fill;
            issuedDate.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issuedDate.Location = new Point(3, 112);
            issuedDate.Name = "issuedDate";
            issuedDate.Padding = new Padding(0, 8, 0, 0);
            issuedDate.Size = new Size(90, 40);
            issuedDate.TabIndex = 32;
            issuedDate.Text = "Issued Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 77);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 8, 0, 0);
            label5.Size = new Size(90, 35);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Dock = DockStyle.Fill;
            email.Font = new Font("Montserrat", 9F);
            email.Location = new Point(99, 80);
            email.Name = "email";
            email.Size = new Size(346, 26);
            email.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 8, 0, 0);
            label3.Size = new Size(90, 37);
            label3.TabIndex = 18;
            label3.Text = "Role";
            // 
            // brrRoleCombobox
            // 
            brrRoleCombobox.Dock = DockStyle.Fill;
            brrRoleCombobox.Font = new Font("Montserrat", 9F);
            brrRoleCombobox.FormattingEnabled = true;
            brrRoleCombobox.Items.AddRange(new object[] { "Student", "Staff" });
            brrRoleCombobox.Location = new Point(99, 43);
            brrRoleCombobox.Name = "brrRoleCombobox";
            brrRoleCombobox.Size = new Size(346, 29);
            brrRoleCombobox.TabIndex = 23;
            // 
            // brrName
            // 
            brrName.BorderStyle = BorderStyle.FixedSingle;
            brrName.Dock = DockStyle.Fill;
            brrName.Font = new Font("Montserrat", 9F);
            brrName.Location = new Point(573, 3);
            brrName.Name = "brrName";
            brrName.Size = new Size(325, 26);
            brrName.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(451, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 8, 0, 0);
            label1.Size = new Size(116, 40);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 8, 0, 0);
            label8.Size = new Size(90, 40);
            label8.TabIndex = 30;
            label8.Text = "Id";
            // 
            // brrId
            // 
            brrId.BorderStyle = BorderStyle.FixedSingle;
            brrId.Dock = DockStyle.Fill;
            brrId.Font = new Font("Montserrat", 9F);
            brrId.Location = new Point(99, 3);
            brrId.Name = "brrId";
            brrId.Size = new Size(346, 26);
            brrId.TabIndex = 31;
            brrId.Leave += brrId_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(451, 77);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 8, 0, 0);
            label6.Size = new Size(116, 35);
            label6.TabIndex = 26;
            label6.Text = "Phone Number";
            // 
            // phoneNumber
            // 
            phoneNumber.BorderStyle = BorderStyle.FixedSingle;
            phoneNumber.Dock = DockStyle.Fill;
            phoneNumber.Font = new Font("Montserrat", 9F);
            phoneNumber.Location = new Point(573, 80);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(325, 26);
            phoneNumber.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(451, 40);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 8, 0, 0);
            label7.Size = new Size(116, 37);
            label7.TabIndex = 28;
            label7.Text = "Department";
            // 
            // departmentComboBox
            // 
            departmentComboBox.Dock = DockStyle.Fill;
            departmentComboBox.Font = new Font("Montserrat", 8F);
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(573, 43);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(325, 26);
            departmentComboBox.TabIndex = 29;
            // 
            // issueDatepicker
            // 
            issueDatepicker.CustomFormat = "dd/MM/yyyy   hh : mm tt";
            issueDatepicker.Dock = DockStyle.Fill;
            issueDatepicker.Font = new Font("Montserrat", 9F);
            issueDatepicker.Format = DateTimePickerFormat.Custom;
            issueDatepicker.Location = new Point(99, 115);
            issueDatepicker.Name = "issueDatepicker";
            issueDatepicker.Size = new Size(346, 26);
            issueDatepicker.TabIndex = 35;
            // 
            // addBtn
            // 
            addBtn.Dock = DockStyle.Right;
            addBtn.Font = new Font("Montserrat", 9F);
            addBtn.Location = new Point(831, 406);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(73, 30);
            addBtn.TabIndex = 23;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
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
            // addBorrowers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 464);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addBorrowers";
            Text = "Add Borrowers";
            Load += addBorrowers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)borrowingList).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox brrName;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox phoneNumber;
        private Label label6;
        private TextBox email;
        private Label label5;
        private ComboBox brrRoleCombobox;
        private ComboBox departmentComboBox;
        private TextBox brrId;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private Button addBtn;
        private DataGridView borrowingList;
        private DataGridViewComboBoxColumn EquipmentName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn BrokenQty;
        private Label issuedDate;
        private Label dueDate;
        private DateTimePicker dueDatepicker;
        private DateTimePicker issueDatepicker;
    }
}