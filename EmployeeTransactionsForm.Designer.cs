namespace ATMProject
{
    partial class EmployeeTransactionsForm
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
            this.lblEmployeeRecords = new System.Windows.Forms.Label();
            this.dgvEmployeeRecords = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeRecords
            // 
            this.lblEmployeeRecords.AutoSize = true;
            this.lblEmployeeRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeRecords.Location = new System.Drawing.Point(226, 38);
            this.lblEmployeeRecords.Name = "lblEmployeeRecords";
            this.lblEmployeeRecords.Size = new System.Drawing.Size(307, 29);
            this.lblEmployeeRecords.TabIndex = 0;
            this.lblEmployeeRecords.Text = "Employee Login Records";
            // 
            // dgvEmployeeRecords
            // 
            this.dgvEmployeeRecords.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvEmployeeRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeRecords.Location = new System.Drawing.Point(125, 91);
            this.dgvEmployeeRecords.Name = "dgvEmployeeRecords";
            this.dgvEmployeeRecords.RowHeadersWidth = 62;
            this.dgvEmployeeRecords.RowTemplate.Height = 28;
            this.dgvEmployeeRecords.Size = new System.Drawing.Size(509, 253);
            this.dgvEmployeeRecords.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(332, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 61);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EmployeeTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvEmployeeRecords);
            this.Controls.Add(this.lblEmployeeRecords);
            this.Name = "EmployeeTransactionsForm";
            this.Text = "EmployeeTransactionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeRecords;
        private System.Windows.Forms.DataGridView dgvEmployeeRecords;
        private System.Windows.Forms.Button btnBack;
    }
}