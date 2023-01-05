namespace Go_Smart_Application
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNavi = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnJadwal = new System.Windows.Forms.Button();
            this.btnKelasku = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlFormLeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.pnlNavi);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnJadwal);
            this.panel1.Controls.Add(this.btnKelasku);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 540);
            this.panel1.TabIndex = 0;
            // 
            // pnlNavi
            // 
            this.pnlNavi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlNavi.Location = new System.Drawing.Point(0, 134);
            this.pnlNavi.Name = "pnlNavi";
            this.pnlNavi.Size = new System.Drawing.Size(6, 100);
            this.pnlNavi.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSettings.Image = global::Go_Smart_Application.Properties.Resources.Icon_Settings;
            this.btnSettings.Location = new System.Drawing.Point(0, 478);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 43);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnJadwal
            // 
            this.btnJadwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJadwal.FlatAppearance.BorderSize = 0;
            this.btnJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJadwal.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJadwal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJadwal.Image = global::Go_Smart_Application.Properties.Resources.Icon_Calender;
            this.btnJadwal.Location = new System.Drawing.Point(0, 204);
            this.btnJadwal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJadwal.Name = "btnJadwal";
            this.btnJadwal.Size = new System.Drawing.Size(186, 52);
            this.btnJadwal.TabIndex = 1;
            this.btnJadwal.Text = "Jadwal     ";
            this.btnJadwal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnJadwal.UseVisualStyleBackColor = true;
            this.btnJadwal.Click += new System.EventHandler(this.btnJadwal_Click);
            this.btnJadwal.Leave += new System.EventHandler(this.btnJadwal_Leave);
            // 
            // btnKelasku
            // 
            this.btnKelasku.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKelasku.FlatAppearance.BorderSize = 0;
            this.btnKelasku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelasku.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKelasku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKelasku.Image = global::Go_Smart_Application.Properties.Resources.Icon_Class;
            this.btnKelasku.Location = new System.Drawing.Point(0, 159);
            this.btnKelasku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKelasku.Name = "btnKelasku";
            this.btnKelasku.Size = new System.Drawing.Size(186, 45);
            this.btnKelasku.TabIndex = 1;
            this.btnKelasku.Text = "Kelasku    ";
            this.btnKelasku.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKelasku.UseVisualStyleBackColor = true;
            this.btnKelasku.Click += new System.EventHandler(this.btnKelasku_Click);
            this.btnKelasku.Leave += new System.EventHandler(this.btnKelasku_Leave);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::Go_Smart_Application.Properties.Resources.Icon_Home;
            this.btnHome.Location = new System.Drawing.Point(0, 119);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Dashboard";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 119);
            this.panel2.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlNav.Location = new System.Drawing.Point(0, 154);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 80);
            this.pnlNav.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(83, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "XII IPA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(83, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chindy\r\nPutri\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Go_Smart_Application.Properties.Resources.Icon_User;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(206, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(609, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Pencarian...";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(926, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlFormLeader
            // 
            this.pnlFormLeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLeader.Location = new System.Drawing.Point(186, 63);
            this.pnlFormLeader.Name = "pnlFormLeader";
            this.pnlFormLeader.Size = new System.Drawing.Size(765, 477);
            this.pnlFormLeader.TabIndex = 4;
            this.pnlFormLeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormLeader_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 540);
            this.Controls.Add(this.pnlFormLeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnSettings;
        private Button btnJadwal;
        private Button btnKelasku;
        private Button btnHome;
        private Panel pnlNav;
        private Label lblTitle;
        private TextBox textBox1;
        private Button button1;
        private Panel pnlFormLeader;
        private Panel pnlNavi;
    }
}