namespace ATMProject
{
    partial class DashboardForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblLoanStatus = new System.Windows.Forms.Label();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnRequestLoan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnATM = new System.Windows.Forms.Button();
            this.btnLoginHistory = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.SteelBlue;
            this.panelContent.BackgroundImage = global::ATMProject.Properties.Resources.dashboard_4;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(269, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(2005, 1199);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblWelcome.Location = new System.Drawing.Point(395, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(345, 55);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "\"WELCOME, \" ";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.BackgroundImage = global::ATMProject.Properties.Resources.User_DashBoard2;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.lblLoanStatus);
            this.panelMenu.Controls.Add(this.btnNotifications);
            this.panelMenu.Controls.Add(this.btnRequestLoan);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnATM);
            this.panelMenu.Controls.Add(this.btnLoginHistory);
            this.panelMenu.Controls.Add(this.btnTransactions);
            this.panelMenu.Controls.Add(this.btnEditProfile);
            this.panelMenu.Controls.Add(this.btnUserProfile);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(269, 1199);
            this.panelMenu.TabIndex = 0;
            // 
            // lblLoanStatus
            // 
            this.lblLoanStatus.AutoSize = true;
            this.lblLoanStatus.Location = new System.Drawing.Point(143, 979);
            this.lblLoanStatus.Name = "lblLoanStatus";
            this.lblLoanStatus.Size = new System.Drawing.Size(0, 25);
            this.lblLoanStatus.TabIndex = 8;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Location = new System.Drawing.Point(101, 1110);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(171, 58);
            this.btnNotifications.TabIndex = 7;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnRequestLoan
            // 
            this.btnRequestLoan.Location = new System.Drawing.Point(101, 990);
            this.btnRequestLoan.Name = "btnRequestLoan";
            this.btnRequestLoan.Size = new System.Drawing.Size(171, 58);
            this.btnRequestLoan.TabIndex = 6;
            this.btnRequestLoan.Text = "Request Loan";
            this.btnRequestLoan.UseVisualStyleBackColor = true;
            this.btnRequestLoan.Click += new System.EventHandler(this.btnRequestLoan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(101, 888);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 58);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnATM
            // 
            this.btnATM.Location = new System.Drawing.Point(101, 773);
            this.btnATM.Name = "btnATM";
            this.btnATM.Size = new System.Drawing.Size(171, 58);
            this.btnATM.TabIndex = 4;
            this.btnATM.Text = "ATM";
            this.btnATM.UseVisualStyleBackColor = true;
            this.btnATM.Click += new System.EventHandler(this.btnATM_Click);
            // 
            // btnLoginHistory
            // 
            this.btnLoginHistory.Location = new System.Drawing.Point(101, 654);
            this.btnLoginHistory.Name = "btnLoginHistory";
            this.btnLoginHistory.Size = new System.Drawing.Size(171, 58);
            this.btnLoginHistory.TabIndex = 3;
            this.btnLoginHistory.Text = "Login History";
            this.btnLoginHistory.UseVisualStyleBackColor = true;
            this.btnLoginHistory.Click += new System.EventHandler(this.btnLoginHistory_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(101, 523);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(171, 58);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(101, 413);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(171, 58);
            this.btnEditProfile.TabIndex = 1;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Location = new System.Drawing.Point(101, 298);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUserProfile.Size = new System.Drawing.Size(171, 58);
            this.btnUserProfile.TabIndex = 0;
            this.btnUserProfile.Text = "User Profile";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click_1);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2274, 1199);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnATM;
        private System.Windows.Forms.Button btnLoginHistory;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnRequestLoan;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Label lblLoanStatus;
    }
}