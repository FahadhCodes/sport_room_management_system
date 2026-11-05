namespace Project_Sport_Room
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            borrowerBtn = new Button();
            newIntakebtn = new Button();
            inventorybtn = new Button();
            overviewbtn = new Button();
            label11 = new Label();
            MainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 86);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 27);
            label1.Name = "label1";
            label1.Size = new Size(274, 21);
            label1.TabIndex = 3;
            label1.Text = "Sport Room Management System";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(borrowerBtn);
            panel2.Controls.Add(newIntakebtn);
            panel2.Controls.Add(inventorybtn);
            panel2.Controls.Add(overviewbtn);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 531);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(4, 365);
            button1.Name = "button1";
            button1.Size = new Size(188, 48);
            button1.TabIndex = 13;
            button1.Text = "Suppliers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // borrowerBtn
            // 
            borrowerBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            borrowerBtn.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowerBtn.Location = new Point(5, 293);
            borrowerBtn.Name = "borrowerBtn";
            borrowerBtn.Size = new Size(188, 48);
            borrowerBtn.TabIndex = 12;
            borrowerBtn.Text = "Borrowers";
            borrowerBtn.UseVisualStyleBackColor = true;
            borrowerBtn.Click += borrowerBtn_Click;
            // 
            // newIntakebtn
            // 
            newIntakebtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            newIntakebtn.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newIntakebtn.Location = new Point(5, 215);
            newIntakebtn.Name = "newIntakebtn";
            newIntakebtn.Size = new Size(188, 48);
            newIntakebtn.TabIndex = 11;
            newIntakebtn.Text = "New Intakes";
            newIntakebtn.UseVisualStyleBackColor = true;
            newIntakebtn.Click += newIntakebtn_Click;
            // 
            // inventorybtn
            // 
            inventorybtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inventorybtn.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventorybtn.Location = new Point(5, 141);
            inventorybtn.Name = "inventorybtn";
            inventorybtn.Size = new Size(188, 48);
            inventorybtn.TabIndex = 10;
            inventorybtn.Text = "Inventory";
            inventorybtn.UseVisualStyleBackColor = true;
            inventorybtn.Click += inventorybtn_Click;
            // 
            // overviewbtn
            // 
            overviewbtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            overviewbtn.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            overviewbtn.Location = new Point(5, 62);
            overviewbtn.Name = "overviewbtn";
            overviewbtn.Size = new Size(188, 48);
            overviewbtn.TabIndex = 9;
            overviewbtn.Text = "Overview";
            overviewbtn.UseVisualStyleBackColor = true;
            overviewbtn.Click += overviewbtn_Click_1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(54, 10);
            label11.Name = "label11";
            label11.Size = new Size(97, 21);
            label11.TabIndex = 0;
            label11.Text = "Workspace";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ActiveBorder;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(206, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1036, 531);
            MainPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4881887F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.51181F));
            tableLayoutPanel1.Size = new Size(1251, 635);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.3052216F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.69478F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(MainPanel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 95);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1245, 537);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1251, 635);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Sport Room Managment System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button newIntakebtn;
        private Button inventorybtn;
        private Button overviewbtn;
        private Label label11;
        private Button borrowerBtn;
        private Panel MainPanel;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
