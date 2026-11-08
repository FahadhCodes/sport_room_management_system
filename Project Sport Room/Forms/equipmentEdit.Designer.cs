namespace Project_Sport_Room.Forms
{
    partial class equipmentEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipmentEdit));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            equipmentCate = new Label();
            equipmentName = new Label();
            equipmentId = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            dmg = new NumericUpDown();
            label1 = new Label();
            healthyQty = new NumericUpDown();
            tableLayoutPanel4 = new TableLayoutPanel();
            cancelBtn = new Button();
            label3 = new Label();
            totQty = new Label();
            saveBtn = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dmg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)healthyQty).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Equipment Quantity";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.22944F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7489185F));
            tableLayoutPanel1.Size = new Size(621, 257);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(equipmentCate, 2, 0);
            tableLayoutPanel2.Controls.Add(equipmentName, 1, 0);
            tableLayoutPanel2.Controls.Add(equipmentId, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(615, 89);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // equipmentCate
            // 
            equipmentCate.AutoSize = true;
            equipmentCate.Dock = DockStyle.Fill;
            equipmentCate.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            equipmentCate.ForeColor = Color.Brown;
            equipmentCate.Location = new Point(413, 0);
            equipmentCate.Name = "equipmentCate";
            equipmentCate.Size = new Size(199, 89);
            equipmentCate.TabIndex = 2;
            equipmentCate.Text = "Equipment Category";
            equipmentCate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equipmentName
            // 
            equipmentName.AutoSize = true;
            equipmentName.Dock = DockStyle.Fill;
            equipmentName.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            equipmentName.ForeColor = Color.Brown;
            equipmentName.Location = new Point(208, 0);
            equipmentName.Name = "equipmentName";
            equipmentName.Size = new Size(199, 89);
            equipmentName.TabIndex = 1;
            equipmentName.Text = "Equipment Name";
            equipmentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equipmentId
            // 
            equipmentId.AutoSize = true;
            equipmentId.Dock = DockStyle.Fill;
            equipmentId.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            equipmentId.ForeColor = Color.Brown;
            equipmentId.Location = new Point(3, 0);
            equipmentId.Name = "equipmentId";
            equipmentId.Size = new Size(199, 89);
            equipmentId.TabIndex = 0;
            equipmentId.Text = "Equipment Id";
            equipmentId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(label2, 2, 0);
            tableLayoutPanel3.Controls.Add(dmg, 3, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(healthyQty, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 98);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(615, 110);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(309, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 7);
            label2.Size = new Size(147, 110);
            label2.TabIndex = 3;
            label2.Text = "Damage";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // dmg
            // 
            dmg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dmg.Font = new Font("Montserrat", 9F);
            dmg.Location = new Point(462, 81);
            dmg.Name = "dmg";
            dmg.Size = new Size(150, 26);
            dmg.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 7);
            label1.Size = new Size(147, 110);
            label1.TabIndex = 1;
            label1.Text = "Healthy";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // healthyQty
            // 
            healthyQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            healthyQty.Font = new Font("Montserrat", 9F);
            healthyQty.Location = new Point(156, 81);
            healthyQty.Name = "healthyQty";
            healthyQty.Size = new Size(147, 26);
            healthyQty.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(cancelBtn, 3, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(totQty, 1, 0);
            tableLayoutPanel4.Controls.Add(saveBtn, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 214);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(615, 40);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.Dock = DockStyle.Fill;
            cancelBtn.Font = new Font("Montserrat", 9F);
            cancelBtn.Location = new Point(462, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 34);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 40);
            label3.TabIndex = 1;
            label3.Text = "Total Quantity";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totQty
            // 
            totQty.AutoSize = true;
            totQty.Dock = DockStyle.Fill;
            totQty.Font = new Font("Montserrat", 9F);
            totQty.Location = new Point(156, 0);
            totQty.Name = "totQty";
            totQty.Size = new Size(147, 40);
            totQty.TabIndex = 2;
            totQty.Text = "0";
            totQty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveBtn
            // 
            saveBtn.Dock = DockStyle.Fill;
            saveBtn.Font = new Font("Montserrat", 9F);
            saveBtn.Location = new Point(309, 3);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(147, 34);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // equipmentEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 282);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "equipmentEdit";
            Text = "Equipment Edit";
            Load += equipmentEdit_Load_1;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dmg).EndInit();
            ((System.ComponentModel.ISupportInitialize)healthyQty).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label equipmentName;
        private Label equipmentId;
        private Label equipmentCate;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private NumericUpDown dmg;
        private Label label1;
        private NumericUpDown healthyQty;
        private TableLayoutPanel tableLayoutPanel4;
        private Button cancelBtn;
        private Label label3;
        private Label totQty;
        private Button saveBtn;
    }
}