namespace ATMProject
{
    partial class LoginHistoryControl
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
            this.dgvLoginHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoginHistory
            // 
            this.dgvLoginHistory.AllowUserToAddRows = false;
            this.dgvLoginHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoginHistory.Location = new System.Drawing.Point(140, 252);
            this.dgvLoginHistory.Name = "dgvLoginHistory";
            this.dgvLoginHistory.RowHeadersWidth = 72;
            this.dgvLoginHistory.RowTemplate.Height = 31;
            this.dgvLoginHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoginHistory.Size = new System.Drawing.Size(653, 958);
            this.dgvLoginHistory.TabIndex = 0;
            this.dgvLoginHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoginHistory_CellContentClick);
            // 
            // LoginHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMProject.Properties.Resources.lgnHitory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvLoginHistory);
            this.Name = "LoginHistoryControl";
            this.Size = new System.Drawing.Size(2356, 1265);
            this.Load += new System.EventHandler(this.LoginHistoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoginHistory;
    }
}
