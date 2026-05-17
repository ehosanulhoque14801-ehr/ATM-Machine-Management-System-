namespace ATMProject
{
    partial class BalanceControl
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.dataGridViewBalance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(469, 647);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(26, 25);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "\"\"";
            this.lblMessage.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(544, 382);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 25);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Balance Inquiry: ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.Color.Red;
            this.lblBalance.Location = new System.Drawing.Point(284, 241);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 25);
            this.lblBalance.TabIndex = 13;
            this.lblBalance.Visible = false;
            // 
            // dataGridViewBalance
            // 
            this.dataGridViewBalance.AllowUserToAddRows = false;
            this.dataGridViewBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBalance.Location = new System.Drawing.Point(273, 464);
            this.dataGridViewBalance.Name = "dataGridViewBalance";
            this.dataGridViewBalance.ReadOnly = true;
            this.dataGridViewBalance.RowHeadersWidth = 72;
            this.dataGridViewBalance.RowTemplate.Height = 31;
            this.dataGridViewBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBalance.Size = new System.Drawing.Size(537, 104);
            this.dataGridViewBalance.TabIndex = 14;
            this.dataGridViewBalance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBalance_CellContentClick);
            // 
            // BalanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ATMProject.Properties.Resources.atm_machine14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridViewBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Name = "BalanceControl";
            this.Size = new System.Drawing.Size(2347, 1265);
            this.Load += new System.EventHandler(this.BalanceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridView dataGridViewBalance;
    }
}
