namespace SalaryCalculator
{
    partial class Form2
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
            this.boxUser = new System.Windows.Forms.GroupBox();
            this.btnQuickLoad = new System.Windows.Forms.Button();
            this.btnQuickSave = new System.Windows.Forms.Button();
            this.boxSite = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.Label();
            this.boxRate = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.Label();
            this.boxUserID = new System.Windows.Forms.TextBox();
            this.boxCompanyID = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxSalary = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.boxExtraTime = new System.Windows.Forms.TextBox();
            this.txtExtraTime = new System.Windows.Forms.Label();
            this.boxRegularTime = new System.Windows.Forms.TextBox();
            this.txtRegularHour = new System.Windows.Forms.Label();
            this.boxTotalPayment = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.Label();
            this.boxTotalTime = new System.Windows.Forms.TextBox();
            this.txtTotalTimeHH = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.boxUser.SuspendLayout();
            this.boxSalary.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxUser
            // 
            this.boxUser.Controls.Add(this.btnQuickLoad);
            this.boxUser.Controls.Add(this.btnQuickSave);
            this.boxUser.Controls.Add(this.boxSite);
            this.boxUser.Controls.Add(this.textBox2);
            this.boxUser.Controls.Add(this.txtSite);
            this.boxUser.Controls.Add(this.boxRate);
            this.boxUser.Controls.Add(this.txtRate);
            this.boxUser.Controls.Add(this.boxUserID);
            this.boxUser.Controls.Add(this.boxCompanyID);
            this.boxUser.Controls.Add(this.boxPassword);
            this.boxUser.Controls.Add(this.btnLogin);
            this.boxUser.Controls.Add(this.txtPassword);
            this.boxUser.Controls.Add(this.txtCompanyID);
            this.boxUser.Controls.Add(this.txtUserID);
            this.boxUser.Controls.Add(this.groupBox1);
            this.boxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUser.Location = new System.Drawing.Point(21, 38);
            this.boxUser.Name = "boxUser";
            this.boxUser.Size = new System.Drawing.Size(383, 413);
            this.boxUser.TabIndex = 0;
            this.boxUser.TabStop = false;
            this.boxUser.Text = "User Credentials";
            // 
            // btnQuickLoad
            // 
            this.btnQuickLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickLoad.Location = new System.Drawing.Point(224, 242);
            this.btnQuickLoad.Name = "btnQuickLoad";
            this.btnQuickLoad.Size = new System.Drawing.Size(134, 60);
            this.btnQuickLoad.TabIndex = 16;
            this.btnQuickLoad.Text = "Quick Load User Info";
            this.btnQuickLoad.UseVisualStyleBackColor = true;
            this.btnQuickLoad.Click += new System.EventHandler(this.btnQuickLoad_Click);
            // 
            // btnQuickSave
            // 
            this.btnQuickSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSave.Location = new System.Drawing.Point(10, 242);
            this.btnQuickSave.Name = "btnQuickSave";
            this.btnQuickSave.Size = new System.Drawing.Size(143, 60);
            this.btnQuickSave.TabIndex = 15;
            this.btnQuickSave.Text = "Quick Save User Info";
            this.btnQuickSave.UseVisualStyleBackColor = true;
            this.btnQuickSave.Click += new System.EventHandler(this.btnQuickSave_Click);
            // 
            // boxSite
            // 
            this.boxSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSite.Location = new System.Drawing.Point(198, 164);
            this.boxSite.Name = "boxSite";
            this.boxSite.Size = new System.Drawing.Size(160, 26);
            this.boxSite.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(661, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 26);
            this.textBox2.TabIndex = 14;
            // 
            // txtSite
            // 
            this.txtSite.AutoSize = true;
            this.txtSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(6, 167);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(37, 20);
            this.txtSite.TabIndex = 11;
            this.txtSite.Text = "Site";
            // 
            // boxRate
            // 
            this.boxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxRate.Location = new System.Drawing.Point(198, 206);
            this.boxRate.Name = "boxRate";
            this.boxRate.Size = new System.Drawing.Size(160, 26);
            this.boxRate.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.AutoSize = true;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(6, 209);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(44, 20);
            this.txtRate.TabIndex = 9;
            this.txtRate.Text = "Rate";
            // 
            // boxUserID
            // 
            this.boxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUserID.Location = new System.Drawing.Point(198, 84);
            this.boxUserID.Name = "boxUserID";
            this.boxUserID.Size = new System.Drawing.Size(160, 26);
            this.boxUserID.TabIndex = 2;
            // 
            // boxCompanyID
            // 
            this.boxCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCompanyID.Location = new System.Drawing.Point(198, 44);
            this.boxCompanyID.Name = "boxCompanyID";
            this.boxCompanyID.Size = new System.Drawing.Size(160, 26);
            this.boxCompanyID.TabIndex = 1;
            // 
            // boxPassword
            // 
            this.boxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPassword.Location = new System.Drawing.Point(198, 122);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(160, 26);
            this.boxPassword.TabIndex = 3;
            this.boxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(10, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(348, 69);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(6, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(78, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.AutoSize = true;
            this.txtCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyID.Location = new System.Drawing.Point(6, 47);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(97, 20);
            this.txtCompanyID.TabIndex = 3;
            this.txtCompanyID.Text = "Company ID";
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(6, 87);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(64, 20);
            this.txtUserID.TabIndex = 2;
            this.txtUserID.Text = "User ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(555, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Credentials";
            // 
            // boxSalary
            // 
            this.boxSalary.Controls.Add(this.label3);
            this.boxSalary.Controls.Add(this.label2);
            this.boxSalary.Controls.Add(this.progressBar1);
            this.boxSalary.Controls.Add(this.boxExtraTime);
            this.boxSalary.Controls.Add(this.txtExtraTime);
            this.boxSalary.Controls.Add(this.boxRegularTime);
            this.boxSalary.Controls.Add(this.txtRegularHour);
            this.boxSalary.Controls.Add(this.boxTotalPayment);
            this.boxSalary.Controls.Add(this.txtTotalPayment);
            this.boxSalary.Controls.Add(this.boxTotalTime);
            this.boxSalary.Controls.Add(this.txtTotalTimeHH);
            this.boxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSalary.Location = new System.Drawing.Point(435, 38);
            this.boxSalary.Name = "boxSalary";
            this.boxSalary.Size = new System.Drawing.Size(319, 376);
            this.boxSalary.TabIndex = 2;
            this.boxSalary.TabStop = false;
            this.boxSalary.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(87, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mission accomplished!";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 304);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(264, 29);
            this.progressBar1.TabIndex = 22;
            // 
            // boxExtraTime
            // 
            this.boxExtraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxExtraTime.Location = new System.Drawing.Point(146, 47);
            this.boxExtraTime.Name = "boxExtraTime";
            this.boxExtraTime.Size = new System.Drawing.Size(145, 26);
            this.boxExtraTime.TabIndex = 8;
            // 
            // txtExtraTime
            // 
            this.txtExtraTime.AutoSize = true;
            this.txtExtraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraTime.Location = new System.Drawing.Point(23, 50);
            this.txtExtraTime.Name = "txtExtraTime";
            this.txtExtraTime.Size = new System.Drawing.Size(84, 20);
            this.txtExtraTime.TabIndex = 20;
            this.txtExtraTime.Text = "Extra Time";
            // 
            // boxRegularTime
            // 
            this.boxRegularTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxRegularTime.Location = new System.Drawing.Point(146, 99);
            this.boxRegularTime.Name = "boxRegularTime";
            this.boxRegularTime.Size = new System.Drawing.Size(145, 26);
            this.boxRegularTime.TabIndex = 7;
            // 
            // txtRegularHour
            // 
            this.txtRegularHour.AutoSize = true;
            this.txtRegularHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularHour.Location = new System.Drawing.Point(23, 102);
            this.txtRegularHour.Name = "txtRegularHour";
            this.txtRegularHour.Size = new System.Drawing.Size(103, 20);
            this.txtRegularHour.TabIndex = 18;
            this.txtRegularHour.Text = "Regular Time";
            // 
            // boxTotalPayment
            // 
            this.boxTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTotalPayment.Location = new System.Drawing.Point(146, 203);
            this.boxTotalPayment.Name = "boxTotalPayment";
            this.boxTotalPayment.Size = new System.Drawing.Size(145, 26);
            this.boxTotalPayment.TabIndex = 9;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.AutoSize = true;
            this.txtTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayment.Location = new System.Drawing.Point(23, 206);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(110, 20);
            this.txtTotalPayment.TabIndex = 16;
            this.txtTotalPayment.Text = "Total Payment";
            // 
            // boxTotalTime
            // 
            this.boxTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTotalTime.Location = new System.Drawing.Point(146, 152);
            this.boxTotalTime.Name = "boxTotalTime";
            this.boxTotalTime.Size = new System.Drawing.Size(145, 26);
            this.boxTotalTime.TabIndex = 6;
            // 
            // txtTotalTimeHH
            // 
            this.txtTotalTimeHH.AutoSize = true;
            this.txtTotalTimeHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTimeHH.Location = new System.Drawing.Point(23, 155);
            this.txtTotalTimeHH.Name = "txtTotalTimeHH";
            this.txtTotalTimeHH.Size = new System.Drawing.Size(82, 20);
            this.txtTotalTimeHH.TabIndex = 13;
            this.txtTotalTimeHH.Text = "Total Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(93, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenu});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadMenu
            // 
            this.loadMenu.Name = "loadMenu";
            this.loadMenu.Size = new System.Drawing.Size(180, 22);
            this.loadMenu.Text = "User";
            this.loadMenu.Click += new System.EventHandler(this.user1ToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenu});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(180, 22);
            this.saveMenu.Text = "User";
            this.saveMenu.Click += new System.EventHandler(this.user1ToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "SalaryCalculator - Made by © Nitzan Miranda.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 468);
            this.Controls.Add(this.boxSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxUser);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.boxUser.ResumeLayout(false);
            this.boxUser.PerformLayout();
            this.boxSalary.ResumeLayout(false);
            this.boxSalary.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtSite;
        private System.Windows.Forms.TextBox boxRate;
        private System.Windows.Forms.Label txtRate;
        private System.Windows.Forms.TextBox boxUserID;
        private System.Windows.Forms.TextBox boxCompanyID;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label txtCompanyID;
        private System.Windows.Forms.Label txtUserID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox boxSalary;
        private System.Windows.Forms.TextBox boxTotalPayment;
        private System.Windows.Forms.Label txtTotalPayment;
        private System.Windows.Forms.TextBox boxTotalTime;
        private System.Windows.Forms.Label txtTotalTimeHH;
        private System.Windows.Forms.TextBox boxExtraTime;
        private System.Windows.Forms.Label txtExtraTime;
        private System.Windows.Forms.TextBox boxRegularTime;
        private System.Windows.Forms.Label txtRegularHour;
        private System.Windows.Forms.TextBox boxSite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.Button btnQuickLoad;
        private System.Windows.Forms.Button btnQuickSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
    }
}