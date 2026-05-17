namespace ATMProject
{
    partial class LoanNotificationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewLoanStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(170, 112);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My loans Request";
            // 
            // dataGridViewLoanStatus
            // 
            this.dataGridViewLoanStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoanStatus.Location = new System.Drawing.Point(22, 166);
            this.dataGridViewLoanStatus.Name = "dataGridViewLoanStatus";
            this.dataGridViewLoanStatus.RowHeadersWidth = 72;
            this.dataGridViewLoanStatus.RowTemplate.Height = 31;
            this.dataGridViewLoanStatus.Size = new System.Drawing.Size(690, 366);
            this.dataGridViewLoanStatus.TabIndex = 1;
            // 
            // LoanNotificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewLoanStatus);
            this.Controls.Add(this.lblTitle);
            this.Name = "LoanNotificationControl";
            this.Size = new System.Drawing.Size(726, 551);
            this.Load += new System.EventHandler(this.LoanNotificationControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewLoanStatus;
    }
}
