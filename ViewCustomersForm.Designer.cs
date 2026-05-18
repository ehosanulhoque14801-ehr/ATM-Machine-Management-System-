namespace ATMProject
{
    partial class ViewCustomersForm
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
            this.lblCustomerRecords = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnVerifyAccount = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerRecords
            // 
            this.lblCustomerRecords.AutoSize = true;
            this.lblCustomerRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRecords.Location = new System.Drawing.Point(24, 76);
            this.lblCustomerRecords.Name = "lblCustomerRecords";
            this.lblCustomerRecords.Size = new System.Drawing.Size(230, 29);
            this.lblCustomerRecords.TabIndex = 0;
            this.lblCustomerRecords.Text = "Customer Records";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerID,
            this.colName,
            this.colAccountNumber,
            this.colBalance});
            this.dgvCustomers.Location = new System.Drawing.Point(260, 28);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(475, 225);
            this.dgvCustomers.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(798, 90);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 58);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // colCustomerID
            // 
            this.colCustomerID.HeaderText = "Customer ID";
            this.colCustomerID.MinimumWidth = 8;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.HeaderText = "Account Number";
            this.colAccountNumber.MinimumWidth = 8;
            this.colAccountNumber.Name = "colAccountNumber";
            this.colAccountNumber.Width = 150;
            // 
            // colBalance
            // 
            this.colBalance.HeaderText = "Balance";
            this.colBalance.MinimumWidth = 8;
            this.colBalance.Name = "colBalance";
            this.colBalance.Width = 150;
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.Location = new System.Drawing.Point(40, 322);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(470, 29);
            this.lblSearchCustomer.TabIndex = 3;
            this.lblSearchCustomer.Text = "Search Customer (Name / Account No.)";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(768, 313);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(114, 44);
            this.btnSearchCustomer.TabIndex = 5;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnVerifyAccount
            // 
            this.btnVerifyAccount.Location = new System.Drawing.Point(579, 380);
            this.btnVerifyAccount.Name = "btnVerifyAccount";
            this.btnVerifyAccount.Size = new System.Drawing.Size(110, 51);
            this.btnVerifyAccount.TabIndex = 8;
            this.btnVerifyAccount.Text = "Verify Account";
            this.btnVerifyAccount.UseVisualStyleBackColor = true;
            this.btnVerifyAccount.Click += new System.EventHandler(this.btnVerifyAccount_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(528, 322);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(217, 26);
            this.txtSearchCustomer.TabIndex = 9;
            // 
            // ViewCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1025, 522);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnVerifyAccount);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblCustomerRecords);
            this.Name = "ViewCustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCustomersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerRecords;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnVerifyAccount;
        private System.Windows.Forms.TextBox txtSearchCustomer;
    }
}