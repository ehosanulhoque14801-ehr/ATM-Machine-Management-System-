namespace ATMProject
{
    partial class EmployeeDashboardForm
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
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnViewTransactions = new System.Windows.Forms.Button();
            this.btnViewLoginHistory = new System.Windows.Forms.Button();
            this.btnCustomerSupport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Location = new System.Drawing.Point(17, 30);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(113, 70);
            this.btnViewCustomers.TabIndex = 0;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.Location = new System.Drawing.Point(19, 402);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Size = new System.Drawing.Size(108, 73);
            this.btnViewTransactions.TabIndex = 3;
            this.btnViewTransactions.Text = "View Transactions";
            this.btnViewTransactions.UseVisualStyleBackColor = true;
            this.btnViewTransactions.Click += new System.EventHandler(this.btnViewTransactions_Click);
            // 
            // btnViewLoginHistory
            // 
            this.btnViewLoginHistory.Location = new System.Drawing.Point(18, 146);
            this.btnViewLoginHistory.Name = "btnViewLoginHistory";
            this.btnViewLoginHistory.Size = new System.Drawing.Size(112, 75);
            this.btnViewLoginHistory.TabIndex = 4;
            this.btnViewLoginHistory.Text = "View Login History";
            this.btnViewLoginHistory.UseVisualStyleBackColor = true;
            this.btnViewLoginHistory.Click += new System.EventHandler(this.btnViewLoginHistory_Click);
            // 
            // btnCustomerSupport
            // 
            this.btnCustomerSupport.Location = new System.Drawing.Point(583, 30);
            this.btnCustomerSupport.Name = "btnCustomerSupport";
            this.btnCustomerSupport.Size = new System.Drawing.Size(123, 71);
            this.btnCustomerSupport.TabIndex = 7;
            this.btnCustomerSupport.Text = "Customer Support";
            this.btnCustomerSupport.UseVisualStyleBackColor = true;
            this.btnCustomerSupport.Click += new System.EventHandler(this.btnCustomerSupport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(19, 535);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 71);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(18, 273);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(109, 77);
            this.btnViewProfile.TabIndex = 10;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // EmployeeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMProject.Properties.Resources.EmployeeDashboard;
            this.ClientSize = new System.Drawing.Size(895, 663);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCustomerSupport);
            this.Controls.Add(this.btnViewLoginHistory);
            this.Controls.Add(this.btnViewTransactions);
            this.Controls.Add(this.btnViewCustomers);
            this.Name = "EmployeeDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.Button btnViewLoginHistory;
        private System.Windows.Forms.Button btnCustomerSupport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewProfile;
    }
}