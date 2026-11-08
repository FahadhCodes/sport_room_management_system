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
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            home = new Button();
            label11 = new Label();
            borrowerBtn = new Button();
            button1 = new Button();
            newIntakebtn = new Button();
            inventorybtn = new Button();
            overviewbtn = new Button();
            MainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            backup = new Button();
            restore = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 98);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.16009665F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.8399048F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1243, 96);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 1);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(84, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 65.38461F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 34.6153831F));
            tableLayoutPanel5.Size = new Size(1052, 90);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(1046, 32);
            label2.TabIndex = 6;
            label2.Text = "Department of Sport Sciences and Physical Education";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Montserrat Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1046, 58);
            label1.TabIndex = 5;
            label1.Text = "SPORT ROOM MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 602);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(home, 0, 1);
            tableLayoutPanel3.Controls.Add(label11, 0, 0);
            tableLayoutPanel3.Controls.Add(borrowerBtn, 0, 6);
            tableLayoutPanel3.Controls.Add(button1, 0, 5);
            tableLayoutPanel3.Controls.Add(newIntakebtn, 0, 4);
            tableLayoutPanel3.Controls.Add(inventorybtn, 0, 3);
            tableLayoutPanel3.Controls.Add(overviewbtn, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881613F));
            tableLayoutPanel3.Size = new Size(196, 602);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // home
            // 
            home.BackColor = Color.Brown;
            home.Dock = DockStyle.Fill;
            home.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            home.ForeColor = Color.White;
            home.Location = new Point(10, 90);
            home.Margin = new Padding(10, 5, 10, 5);
            home.Name = "home";
            home.Size = new Size(176, 75);
            home.TabIndex = 14;
            home.Text = "Home";
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Montserrat", 15F, FontStyle.Bold);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(190, 85);
            label11.TabIndex = 0;
            label11.Text = "Workspace";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // borrowerBtn
            // 
            borrowerBtn.BackColor = Color.Brown;
            borrowerBtn.Dock = DockStyle.Fill;
            borrowerBtn.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            borrowerBtn.ForeColor = Color.White;
            borrowerBtn.Location = new Point(10, 515);
            borrowerBtn.Margin = new Padding(10, 5, 10, 5);
            borrowerBtn.Name = "borrowerBtn";
            borrowerBtn.Size = new Size(176, 82);
            borrowerBtn.TabIndex = 12;
            borrowerBtn.Text = "Borrowers";
            borrowerBtn.UseVisualStyleBackColor = false;
            borrowerBtn.Click += borrowerBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 430);
            button1.Margin = new Padding(10, 5, 10, 5);
            button1.Name = "button1";
            button1.Size = new Size(176, 75);
            button1.TabIndex = 13;
            button1.Text = "Suppliers";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // newIntakebtn
            // 
            newIntakebtn.BackColor = Color.Brown;
            newIntakebtn.Dock = DockStyle.Fill;
            newIntakebtn.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            newIntakebtn.ForeColor = Color.White;
            newIntakebtn.Location = new Point(10, 345);
            newIntakebtn.Margin = new Padding(10, 5, 10, 5);
            newIntakebtn.Name = "newIntakebtn";
            newIntakebtn.Size = new Size(176, 75);
            newIntakebtn.TabIndex = 11;
            newIntakebtn.Text = "New Intakes";
            newIntakebtn.UseVisualStyleBackColor = false;
            newIntakebtn.Click += newIntakebtn_Click;
            // 
            // inventorybtn
            // 
            inventorybtn.BackColor = Color.Brown;
            inventorybtn.Dock = DockStyle.Fill;
            inventorybtn.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            inventorybtn.ForeColor = Color.White;
            inventorybtn.Location = new Point(10, 260);
            inventorybtn.Margin = new Padding(10, 5, 10, 5);
            inventorybtn.Name = "inventorybtn";
            inventorybtn.Size = new Size(176, 75);
            inventorybtn.TabIndex = 10;
            inventorybtn.Text = "Inventory";
            inventorybtn.UseVisualStyleBackColor = false;
            inventorybtn.Click += inventorybtn_Click;
            // 
            // overviewbtn
            // 
            overviewbtn.BackColor = Color.Brown;
            overviewbtn.Dock = DockStyle.Fill;
            overviewbtn.Font = new Font("Montserrat ExtraBold", 9F, FontStyle.Bold);
            overviewbtn.ForeColor = Color.White;
            overviewbtn.Location = new Point(10, 175);
            overviewbtn.Margin = new Padding(10, 5, 10, 5);
            overviewbtn.Name = "overviewbtn";
            overviewbtn.Size = new Size(176, 75);
            overviewbtn.TabIndex = 9;
            overviewbtn.Text = "Overview";
            overviewbtn.UseVisualStyleBackColor = false;
            overviewbtn.Click += overviewbtn_Click_1;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ActiveBorder;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(205, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1037, 602);
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
            tableLayoutPanel1.Size = new Size(1251, 718);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.30522F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.69478F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(MainPanel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 107);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1245, 608);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(restore, 0, 1);
            tableLayoutPanel6.Controls.Add(backup, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(1142, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(98, 90);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // backup
            // 
            backup.Dock = DockStyle.Fill;
            backup.Location = new Point(3, 3);
            backup.Name = "backup";
            backup.Size = new Size(92, 39);
            backup.TabIndex = 0;
            backup.Text = "Backup";
            backup.UseVisualStyleBackColor = true;
            // 
            // restore
            // 
            restore.Dock = DockStyle.Fill;
            restore.Location = new Point(3, 48);
            restore.Name = "restore";
            restore.Size = new Size(92, 39);
            restore.TabIndex = 1;
            restore.Text = "Restore";
            restore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1251, 718);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sport Room Managment System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button newIntakebtn;
        private Button inventorybtn;
        private Button overviewbtn;
        private Label label11;
        private Button borrowerBtn;
        private Panel MainPanel;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private Label label1;
        private Button home;
        private TableLayoutPanel tableLayoutPanel6;
        private Button restore;
        private Button backup;
    }
}
