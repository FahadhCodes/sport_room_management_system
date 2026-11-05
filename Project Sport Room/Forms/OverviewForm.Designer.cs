namespace Project_Sport_Room
{
    partial class OverviewForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            totalEquipments = new Label();
            label3 = new Label();
            panel6 = new Panel();
            avalableEq = new Label();
            label10 = new Label();
            panel4 = new Panel();
            newlyArrived = new Label();
            label6 = new Label();
            panel5 = new Panel();
            borrowedEq = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ReceiptId = new DataGridViewTextBoxColumn();
            BorrowerName = new DataGridViewTextBoxColumn();
            Borrower_Id = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Equipment = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label11 = new Label();
            departmentComboBox = new ComboBox();
            label1 = new Label();
            searchAll = new TextBox();
            brrStatus = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            statusComboBox = new ComboBox();
            adorableFilter = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 3, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(978, 142);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(totalEquipments);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 136);
            panel3.TabIndex = 3;
            // 
            // totalEquipments
            // 
            totalEquipments.AutoSize = true;
            totalEquipments.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            totalEquipments.ForeColor = Color.Brown;
            totalEquipments.Location = new Point(9, 66);
            totalEquipments.Name = "totalEquipments";
            totalEquipments.Size = new Size(65, 35);
            totalEquipments.TabIndex = 4;
            totalEquipments.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 4;
            label3.Text = "Total Equipment";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(avalableEq);
            panel6.Controls.Add(label10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(735, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(240, 136);
            panel6.TabIndex = 7;
            // 
            // avalableEq
            // 
            avalableEq.AutoSize = true;
            avalableEq.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            avalableEq.ForeColor = Color.Brown;
            avalableEq.Location = new Point(9, 66);
            avalableEq.Name = "avalableEq";
            avalableEq.Size = new Size(65, 35);
            avalableEq.TabIndex = 4;
            avalableEq.Text = "N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 8);
            label10.Name = "label10";
            label10.Size = new Size(66, 18);
            label10.TabIndex = 4;
            label10.Text = "Available";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(newlyArrived);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(247, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 136);
            panel4.TabIndex = 5;
            // 
            // newlyArrived
            // 
            newlyArrived.AutoSize = true;
            newlyArrived.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            newlyArrived.ForeColor = Color.Brown;
            newlyArrived.Location = new Point(9, 66);
            newlyArrived.Name = "newlyArrived";
            newlyArrived.Size = new Size(65, 35);
            newlyArrived.TabIndex = 4;
            newlyArrived.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 8);
            label6.Name = "label6";
            label6.Size = new Size(97, 18);
            label6.TabIndex = 4;
            label6.Text = "Newly Arrived";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(borrowedEq);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(491, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(238, 136);
            panel5.TabIndex = 6;
            // 
            // borrowedEq
            // 
            borrowedEq.AutoSize = true;
            borrowedEq.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            borrowedEq.ForeColor = Color.Brown;
            borrowedEq.Location = new Point(9, 66);
            borrowedEq.Name = "borrowedEq";
            borrowedEq.Size = new Size(65, 35);
            borrowedEq.TabIndex = 4;
            borrowedEq.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 8);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 4;
            label8.Text = "Borrowed";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ReceiptId, BorrowerName, Borrower_Id, Department, Equipment, Qty, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(978, 347);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ReceiptId
            // 
            ReceiptId.DataPropertyName = "ReceiptId";
            ReceiptId.HeaderText = "Receipt Id";
            ReceiptId.MinimumWidth = 6;
            ReceiptId.Name = "ReceiptId";
            // 
            // BorrowerName
            // 
            BorrowerName.DataPropertyName = "BorrowerName";
            BorrowerName.HeaderText = "Borrower Name";
            BorrowerName.MinimumWidth = 6;
            BorrowerName.Name = "BorrowerName";
            // 
            // Borrower_Id
            // 
            Borrower_Id.DataPropertyName = "Borrower_Id";
            Borrower_Id.HeaderText = "Borrower Id";
            Borrower_Id.MinimumWidth = 6;
            Borrower_Id.Name = "Borrower_Id";
            Borrower_Id.Visible = false;
            // 
            // Department
            // 
            Department.DataPropertyName = "Department";
            Department.HeaderText = "Department";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            // 
            // Equipment
            // 
            Equipment.DataPropertyName = "Equipment";
            Equipment.HeaderText = "Equipment";
            Equipment.MinimumWidth = 6;
            Equipment.Name = "Equipment";
            // 
            // Qty
            // 
            Qty.DataPropertyName = "Qty";
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(230, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 7, 0, 0);
            label11.Size = new Size(98, 39);
            label11.TabIndex = 22;
            label11.Text = "Department";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // departmentComboBox
            // 
            departmentComboBox.Dock = DockStyle.Fill;
            departmentComboBox.Font = new Font("Montserrat", 7F);
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(334, 3);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(341, 24);
            departmentComboBox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(72, 39);
            label1.TabIndex = 20;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // searchAll
            // 
            searchAll.BorderStyle = BorderStyle.FixedSingle;
            searchAll.Dock = DockStyle.Fill;
            searchAll.Location = new Point(81, 3);
            searchAll.Name = "searchAll";
            searchAll.Size = new Size(143, 26);
            searchAll.TabIndex = 19;
            // 
            // brrStatus
            // 
            brrStatus.AutoSize = true;
            brrStatus.Dock = DockStyle.Fill;
            brrStatus.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brrStatus.Location = new Point(681, 0);
            brrStatus.Name = "brrStatus";
            brrStatus.Padding = new Padding(0, 7, 0, 0);
            brrStatus.Size = new Size(82, 39);
            brrStatus.TabIndex = 24;
            brrStatus.Text = "Status";
            brrStatus.TextAlign = ContentAlignment.TopRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2351742F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6339464F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.48057F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.997955F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4171782F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.Controls.Add(statusComboBox, 5, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(searchAll, 1, 0);
            tableLayoutPanel2.Controls.Add(brrStatus, 4, 0);
            tableLayoutPanel2.Controls.Add(label11, 2, 0);
            tableLayoutPanel2.Controls.Add(departmentComboBox, 3, 0);
            tableLayoutPanel2.Controls.Add(adorableFilter, 6, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 151);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(978, 39);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // statusComboBox
            // 
            statusComboBox.Dock = DockStyle.Fill;
            statusComboBox.Font = new Font("Montserrat", 7F);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Overdue", "Returned", "Borrowed", "Returned Late" });
            statusComboBox.Location = new Point(769, 3);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(135, 24);
            statusComboBox.TabIndex = 27;
            // 
            // adorableFilter
            // 
            adorableFilter.Dock = DockStyle.Top;
            adorableFilter.Font = new Font("Montserrat", 7F);
            adorableFilter.Location = new Point(910, 3);
            adorableFilter.Name = "adorableFilter";
            adorableFilter.Size = new Size(65, 28);
            adorableFilter.TabIndex = 26;
            adorableFilter.Text = "Apply";
            adorableFilter.UseVisualStyleBackColor = true;
            adorableFilter.Click += adorableFilter_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 27.130434F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.424909F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 64.4688644F));
            tableLayoutPanel3.Size = new Size(984, 546);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(990, 571);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Overview";
            // 
            // OverviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 571);
            Controls.Add(groupBox1);
            Name = "OverviewForm";
            Text = "OverviewForm";
            Load += OverviewForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label totalEquipments;
        private Label label3;
        private Panel panel6;
        private Label avalableEq;
        private Label label10;
        private Panel panel4;
        private Label newlyArrived;
        private Label label6;
        private Panel panel5;
        private Label borrowedEq;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label11;
        private ComboBox departmentComboBox;
        private Label label1;
        private TextBox searchAll;
        private Label brrStatus;
        private TableLayoutPanel tableLayoutPanel2;
        private Button adorableFilter;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private ComboBox statusComboBox;
        private DataGridViewTextBoxColumn ReceiptId;
        private DataGridViewTextBoxColumn BorrowerName;
        private DataGridViewTextBoxColumn Borrower_Id;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Equipment;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Status;
    }
}