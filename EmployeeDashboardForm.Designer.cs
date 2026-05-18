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
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnVerifyAccount = new System.Windows.Forms.Button();
            this.btnViewTransactions = new System.Windows.Forms.Button();
            this.btnViewLoginHistory = new System.Windows.Forms.Button();
            this.btnCustomerSupport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Location = new System.Drawing.Point(29, 12);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(101, 60);
            this.btnViewCustomers.TabIndex = 0;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(29, 124);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(101, 63);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnVerifyAccount
            // 
            this.btnVerifyAccount.Location = new System.Drawing.Point(667, 350);
            this.btnVerifyAccount.Name = "btnVerifyAccount";
            this.btnVerifyAccount.Size = new System.Drawing.Size(108, 60);
            this.btnVerifyAccount.TabIndex = 2;
            this.btnVerifyAccount.Text = "Verify Account";
            this.btnVerifyAccount.UseVisualStyleBackColor = true;
            this.btnVerifyAccount.Click += new System.EventHandler(this.btnVerifyAccount_Click);
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.Location = new System.Drawing.Point(667, 234);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Size = new System.Drawing.Size(108, 69);
            this.btnViewTransactions.TabIndex = 3;
            this.btnViewTransactions.Text = "View Transactions";
            this.btnViewTransactions.UseVisualStyleBackColor = true;
            // 
            // btnViewLoginHistory
            // 
            this.btnViewLoginHistory.Location = new System.Drawing.Point(668, 12);
            this.btnViewLoginHistory.Name = "btnViewLoginHistory";
            this.btnViewLoginHistory.Size = new System.Drawing.Size(107, 60);
            this.btnViewLoginHistory.TabIndex = 4;
            this.btnViewLoginHistory.Text = "View Login History";
            this.btnViewLoginHistory.UseVisualStyleBackColor = true;
            // 
            // btnCustomerSupport
            // 
            this.btnCustomerSupport.Location = new System.Drawing.Point(668, 122);
            this.btnCustomerSupport.Name = "btnCustomerSupport";
            this.btnCustomerSupport.Size = new System.Drawing.Size(107, 65);
            this.btnCustomerSupport.TabIndex = 7;
            this.btnCustomerSupport.Text = "Customer Support";
            this.btnCustomerSupport.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(326, 372);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 51);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(22, 248);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(108, 55);
            this.btnViewProfile.TabIndex = 10;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(22, 372);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(108, 55);
            this.btnUpdateProfile.TabIndex = 11;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // EmployeeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCustomerSupport);
            this.Controls.Add(this.btnViewLoginHistory);
            this.Controls.Add(this.btnViewTransactions);
            this.Controls.Add(this.btnVerifyAccount);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnViewCustomers);
            this.Name = "EmployeeDashboardForm";
            this.Text = "Employee Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnVerifyAccount;
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.Button btnViewLoginHistory;
        private System.Windows.Forms.Button btnCustomerSupport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}