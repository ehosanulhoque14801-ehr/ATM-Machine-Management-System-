namespace ATMProject
{
    partial class AdminPanelForm
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
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.dataGridLoans = new System.Windows.Forms.DataGridView();
            this.btnApproveLoan = new System.Windows.Forms.Button();
            this.btnRejectLoan = new System.Windows.Forms.Button();
            this.btnRefreshLoans = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtFullNameEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.txtPhoneEdit = new System.Windows.Forms.TextBox();
            this.txtIsAdminEdit = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(113, 350);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersWidth = 72;
            this.dataGridUsers.RowTemplate.Height = 31;
            this.dataGridUsers.Size = new System.Drawing.Size(601, 209);
            this.dataGridUsers.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(321, 317);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(508, 320);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(549, 567);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(71, 25);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.Location = new System.Drawing.Point(627, 568);
            this.btnRefreshUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(87, 25);
            this.btnRefreshUsers.TabIndex = 4;
            this.btnRefreshUsers.Text = "Refresh User";
            this.btnRefreshUsers.UseVisualStyleBackColor = true;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // dataGridLoans
            // 
            this.dataGridLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLoans.Location = new System.Drawing.Point(113, 34);
            this.dataGridLoans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridLoans.Name = "dataGridLoans";
            this.dataGridLoans.RowHeadersWidth = 72;
            this.dataGridLoans.RowTemplate.Height = 31;
            this.dataGridLoans.Size = new System.Drawing.Size(601, 204);
            this.dataGridLoans.TabIndex = 5;
            // 
            // btnApproveLoan
            // 
            this.btnApproveLoan.Location = new System.Drawing.Point(724, 42);
            this.btnApproveLoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApproveLoan.Name = "btnApproveLoan";
            this.btnApproveLoan.Size = new System.Drawing.Size(105, 25);
            this.btnApproveLoan.TabIndex = 6;
            this.btnApproveLoan.Text = "Loan Approve";
            this.btnApproveLoan.UseVisualStyleBackColor = true;
            this.btnApproveLoan.Click += new System.EventHandler(this.btnApproveLoan_Click);
            // 
            // btnRejectLoan
            // 
            this.btnRejectLoan.Location = new System.Drawing.Point(724, 78);
            this.btnRejectLoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRejectLoan.Name = "btnRejectLoan";
            this.btnRejectLoan.Size = new System.Drawing.Size(105, 25);
            this.btnRejectLoan.TabIndex = 7;
            this.btnRejectLoan.Text = "Loan Rejected";
            this.btnRejectLoan.UseVisualStyleBackColor = true;
            this.btnRejectLoan.Click += new System.EventHandler(this.btnRejectLoan_Click);
            // 
            // btnRefreshLoans
            // 
            this.btnRefreshLoans.Location = new System.Drawing.Point(724, 108);
            this.btnRefreshLoans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshLoans.Name = "btnRefreshLoans";
            this.btnRefreshLoans.Size = new System.Drawing.Size(105, 25);
            this.btnRefreshLoans.TabIndex = 8;
            this.btnRefreshLoans.Text = "Loan Refresh";
            this.btnRefreshLoans.UseVisualStyleBackColor = true;
            this.btnRefreshLoans.Click += new System.EventHandler(this.btnRefreshLoans_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1162, 262);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(66, 25);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // txtFullNameEdit
            // 
            this.txtFullNameEdit.Location = new System.Drawing.Point(841, 350);
            this.txtFullNameEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFullNameEdit.Multiline = true;
            this.txtFullNameEdit.Name = "txtFullNameEdit";
            this.txtFullNameEdit.Size = new System.Drawing.Size(276, 39);
            this.txtFullNameEdit.TabIndex = 10;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(841, 415);
            this.txtEmailEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailEdit.Multiline = true;
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(276, 39);
            this.txtEmailEdit.TabIndex = 11;
            // 
            // txtPhoneEdit
            // 
            this.txtPhoneEdit.Location = new System.Drawing.Point(841, 480);
            this.txtPhoneEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneEdit.Multiline = true;
            this.txtPhoneEdit.Name = "txtPhoneEdit";
            this.txtPhoneEdit.Size = new System.Drawing.Size(276, 39);
            this.txtPhoneEdit.TabIndex = 12;
            // 
            // txtIsAdminEdit
            // 
            this.txtIsAdminEdit.Location = new System.Drawing.Point(841, 543);
            this.txtIsAdminEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIsAdminEdit.Multiline = true;
            this.txtIsAdminEdit.Name = "txtIsAdminEdit";
            this.txtIsAdminEdit.Size = new System.Drawing.Size(276, 39);
            this.txtIsAdminEdit.TabIndex = 13;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(1148, 555);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(71, 25);
            this.btnUpdateUser.TabIndex = 14;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search User By Account Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer Loan Requests: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Update: ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 570);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout1
            // 
            this.btnLogout1.Location = new System.Drawing.Point(93, 570);
            this.btnLogout1.Name = "btnLogout1";
            this.btnLogout1.Size = new System.Drawing.Size(75, 23);
            this.btnLogout1.TabIndex = 19;
            this.btnLogout1.Text = "Log Out";
            this.btnLogout1.UseVisualStyleBackColor = true;
            this.btnLogout1.Click += new System.EventHandler(this.btnLogout1_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMProject.Properties.Resources.admin1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 626);
            this.Controls.Add(this.btnLogout1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.txtIsAdminEdit);
            this.Controls.Add(this.txtPhoneEdit);
            this.Controls.Add(this.txtEmailEdit);
            this.Controls.Add(this.txtFullNameEdit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRefreshLoans);
            this.Controls.Add(this.btnRejectLoan);
            this.Controls.Add(this.btnApproveLoan);
            this.Controls.Add(this.dataGridLoans);
            this.Controls.Add(this.btnRefreshUsers);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridUsers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.DataGridView dataGridLoans;
        private System.Windows.Forms.Button btnApproveLoan;
        private System.Windows.Forms.Button btnRejectLoan;
        private System.Windows.Forms.Button btnRefreshLoans;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtFullNameEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.TextBox txtPhoneEdit;
        private System.Windows.Forms.TextBox txtIsAdminEdit;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout1;
    }
}