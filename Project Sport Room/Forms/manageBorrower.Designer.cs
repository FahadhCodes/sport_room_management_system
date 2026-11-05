namespace Project_Sport_Room
{
    partial class manageBorrower
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
            updateBtn = new Button();
            borrwedEquipmentTB = new DataGridView();
            eqId = new DataGridViewTextBoxColumn();
            EquipmentName = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            BrokenQty = new DataGridViewTextBoxColumn();
            borrowalsTb = new DataGridView();
            ReceiptId = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            IssuedDate = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            ReturnedDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            email = new TextBox();
            nameCombobox = new ComboBox();
            department = new ComboBox();
            label7 = new Label();
            phoneNumber = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            roleComboBox = new ComboBox();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrwedEquipmentTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrowalsTb).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(updateBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(borrwedEquipmentTB, 0, 2);
            tableLayoutPanel1.Controls.Add(borrowalsTb, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.182724F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.817276F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 163F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Size = new Size(800, 522);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // updateBtn
            // 
            updateBtn.Dock = DockStyle.Right;
            updateBtn.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(703, 485);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 34);
            updateBtn.TabIndex = 23;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // borrwedEquipmentTB
            // 
            borrwedEquipmentTB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            borrwedEquipmentTB.BorderStyle = BorderStyle.None;
            borrwedEquipmentTB.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            borrwedEquipmentTB.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            borrwedEquipmentTB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            borrwedEquipmentTB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrwedEquipmentTB.Columns.AddRange(new DataGridViewColumn[] { eqId, EquipmentName, category, quantity, BrokenQty });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            borrwedEquipmentTB.DefaultCellStyle = dataGridViewCellStyle2;
            borrwedEquipmentTB.Dock = DockStyle.Fill;
            borrwedEquipmentTB.EnableHeadersVisualStyles = false;
            borrwedEquipmentTB.Location = new Point(3, 322);
            borrwedEquipmentTB.Name = "borrwedEquipmentTB";
            borrwedEquipmentTB.RowHeadersVisible = false;
            borrwedEquipmentTB.RowHeadersWidth = 51;
            borrwedEquipmentTB.Size = new Size(794, 157);
            borrwedEquipmentTB.TabIndex = 19;
            // 
            // eqId
            // 
            eqId.DataPropertyName = "eqId";
            eqId.HeaderText = "Equipment Id";
            eqId.MinimumWidth = 6;
            eqId.Name = "eqId";
            // 
            // EquipmentName
            // 
            EquipmentName.DataPropertyName = "EquipmentName";
            EquipmentName.HeaderText = "Equipment Name";
            EquipmentName.MinimumWidth = 6;
            EquipmentName.Name = "EquipmentName";
            // 
            // category
            // 
            category.DataPropertyName = "category";
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            // 
            // BrokenQty
            // 
            BrokenQty.DataPropertyName = "BrokenQty";
            BrokenQty.HeaderText = "Broken Quantity";
            BrokenQty.MinimumWidth = 6;
            BrokenQty.Name = "BrokenQty";
            // 
            // borrowalsTb
            // 
            borrowalsTb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            borrowalsTb.BorderStyle = BorderStyle.None;
            borrowalsTb.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            borrowalsTb.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            borrowalsTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            borrowalsTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowalsTb.Columns.AddRange(new DataGridViewColumn[] { ReceiptId, Qty, IssuedDate, DueDate, ReturnedDate, status });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            borrowalsTb.DefaultCellStyle = dataGridViewCellStyle4;
            borrowalsTb.Dock = DockStyle.Fill;
            borrowalsTb.EnableHeadersVisualStyles = false;
            borrowalsTb.Location = new Point(3, 147);
            borrowalsTb.Name = "borrowalsTb";
            borrowalsTb.RowHeadersVisible = false;
            borrowalsTb.RowHeadersWidth = 51;
            borrowalsTb.Size = new Size(794, 169);
            borrowalsTb.TabIndex = 18;
            // 
            // ReceiptId
            // 
            ReceiptId.DataPropertyName = "ReceiptId";
            ReceiptId.HeaderText = "Receipt Id";
            ReceiptId.MinimumWidth = 6;
            ReceiptId.Name = "ReceiptId";
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
            status.DataPropertyName = "Status";
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 138);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Borrower";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4365482F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4365463F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9746189F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.40609F));
            tableLayoutPanel2.Controls.Add(email, 1, 1);
            tableLayoutPanel2.Controls.Add(nameCombobox, 1, 0);
            tableLayoutPanel2.Controls.Add(department, 1, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(phoneNumber, 3, 1);
            tableLayoutPanel2.Controls.Add(label6, 2, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(roleComboBox, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.9629631F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.1851845F));
            tableLayoutPanel2.Size = new Size(788, 113);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Dock = DockStyle.Fill;
            email.Font = new Font("Montserrat", 9F);
            email.Location = new Point(100, 41);
            email.Name = "email";
            email.Size = new Size(288, 26);
            email.TabIndex = 31;
            // 
            // nameCombobox
            // 
            nameCombobox.Dock = DockStyle.Fill;
            nameCombobox.Font = new Font("Montserrat", 9F);
            nameCombobox.FormattingEnabled = true;
            nameCombobox.Location = new Point(100, 3);
            nameCombobox.Name = "nameCombobox";
            nameCombobox.Size = new Size(288, 29);
            nameCombobox.TabIndex = 30;
            // 
            // department
            // 
            department.Dock = DockStyle.Fill;
            department.Font = new Font("Montserrat", 9F);
            department.FormattingEnabled = true;
            department.Location = new Point(100, 76);
            department.Name = "department";
            department.Size = new Size(288, 29);
            department.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 73);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 8, 0, 0);
            label7.Size = new Size(91, 40);
            label7.TabIndex = 28;
            label7.Text = "Department";
            // 
            // phoneNumber
            // 
            phoneNumber.BorderStyle = BorderStyle.FixedSingle;
            phoneNumber.Dock = DockStyle.Fill;
            phoneNumber.Font = new Font("Montserrat", 9F);
            phoneNumber.Location = new Point(511, 41);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(274, 26);
            phoneNumber.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(394, 38);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 8, 0, 0);
            label6.Size = new Size(111, 35);
            label6.TabIndex = 26;
            label6.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 38);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 8, 0, 0);
            label5.Size = new Size(91, 35);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 8, 0, 0);
            label1.Size = new Size(91, 38);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(394, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 8, 0, 0);
            label3.Size = new Size(111, 38);
            label3.TabIndex = 18;
            label3.Text = "Role";
            // 
            // roleComboBox
            // 
            roleComboBox.Dock = DockStyle.Fill;
            roleComboBox.Font = new Font("Montserrat", 9F);
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(511, 3);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(274, 29);
            roleComboBox.TabIndex = 23;
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
            // manageBorrower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(tableLayoutPanel1);
            Name = "manageBorrower";
            Text = "Manage Borrower";
            Load += manageBorrower_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)borrwedEquipmentTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrowalsTb).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox department;
        private Label label7;
        private TextBox phoneNumber;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox roleComboBox;
        private Label label4;
        private DataGridView borrowalsTb;
        private DataGridView borrwedEquipmentTB;
        private ComboBox nameCombobox;
        private TextBox email;
        private DataGridViewTextBoxColumn eqId;
        private DataGridViewTextBoxColumn EquipmentName;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn BrokenQty;
        private DataGridViewTextBoxColumn ReceiptId;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn IssuedDate;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn ReturnedDate;
        private DataGridViewTextBoxColumn status;
        private Button updateBtn;
    }
}