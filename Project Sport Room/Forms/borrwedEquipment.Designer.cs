namespace Project_Sport_Room
{
    partial class borrwedEquipment
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
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            Equipments = new DataGridViewTextBoxColumn();
            IssuedDate = new DataGridViewTextBoxColumn();
            Due = new DataGridViewTextBoxColumn();
            ReturnedDate = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            BrokenCount = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dataGridView2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.77778F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.22222F));
            tableLayoutPanel1.Size = new Size(790, 455);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Equipments, IssuedDate, Due, ReturnedDate, qty, BrokenCount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(3, 174);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(784, 278);
            dataGridView2.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 165);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borrwed Equipment";
            groupBox1.Enter += groupBox1_Enter;
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
            // Equipments
            // 
            Equipments.HeaderText = "Equipment";
            Equipments.MinimumWidth = 6;
            Equipments.Name = "Equipments";
            // 
            // IssuedDate
            // 
            IssuedDate.HeaderText = "Issued Date";
            IssuedDate.MinimumWidth = 6;
            IssuedDate.Name = "IssuedDate";
            // 
            // Due
            // 
            Due.HeaderText = "Due Date";
            Due.MinimumWidth = 6;
            Due.Name = "Due";
            // 
            // ReturnedDate
            // 
            ReturnedDate.HeaderText = "Returned Date";
            ReturnedDate.MinimumWidth = 6;
            ReturnedDate.Name = "ReturnedDate";
            // 
            // qty
            // 
            qty.HeaderText = "Qty";
            qty.MinimumWidth = 6;
            qty.Name = "qty";
            // 
            // BrokenCount
            // 
            BrokenCount.HeaderText = "Broken Count";
            BrokenCount.MinimumWidth = 6;
            BrokenCount.Name = "BrokenCount";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel6, 3, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Controls.Add(panel5, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(778, 140);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 134);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(9, 66);
            label1.Name = "label1";
            label1.Size = new Size(59, 35);
            label1.TabIndex = 4;
            label1.Text = "160";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(156, 18);
            label3.TabIndex = 4;
            label3.Text = "Borrowed Equipments";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(585, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(190, 134);
            panel6.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            label9.ForeColor = Color.Brown;
            label9.Location = new Point(9, 66);
            label9.Name = "label9";
            label9.Size = new Size(42, 35);
            label9.TabIndex = 4;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 8);
            label10.Name = "label10";
            label10.Size = new Size(56, 18);
            label10.TabIndex = 4;
            label10.Text = "Broken";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(197, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(188, 134);
            panel4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(9, 66);
            label5.Name = "label5";
            label5.Size = new Size(42, 35);
            label5.TabIndex = 4;
            label5.Text = "10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 8);
            label6.Name = "label6";
            label6.Size = new Size(148, 18);
            label6.TabIndex = 4;
            label6.Text = "Returned Equipment";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(391, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(188, 134);
            panel5.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat Black", 15F, FontStyle.Bold);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(9, 66);
            label7.Name = "label7";
            label7.Size = new Size(42, 35);
            label7.TabIndex = 4;
            label7.Text = "10";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 8);
            label8.Name = "label8";
            label8.Size = new Size(142, 18);
            label8.TabIndex = 4;
            label8.Text = "Pending Equipment";
            // 
            // borrwedEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 455);
            Controls.Add(tableLayoutPanel1);
            Name = "borrwedEquipment";
            Text = "Borrwed Equipment";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private Label label4;
        private DataGridViewTextBoxColumn Equipments;
        private DataGridViewTextBoxColumn IssuedDate;
        private DataGridViewTextBoxColumn Due;
        private DataGridViewTextBoxColumn ReturnedDate;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn BrokenCount;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private Panel panel6;
        private Label label9;
        private Label label10;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private Label label8;
    }
}