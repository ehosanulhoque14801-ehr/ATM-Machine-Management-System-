namespace ATMProject
{
    partial class ReceiptControl
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
            this.lblReceipt = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReceipt
            // 
            this.lblReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceipt.Location = new System.Drawing.Point(0, 0);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(2359, 1265);
            this.lblReceipt.TabIndex = 0;
            this.lblReceipt.Text = "\"\"";
            this.lblReceipt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReceipt.Click += new System.EventHandler(this.lblReceipt_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(782, 442);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(162, 70);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(322, 220);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(17, 25);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = ".";
            // 
            // ReceiptControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblReceipt);
            this.Name = "ReceiptControl";
            this.Size = new System.Drawing.Size(2359, 1265);
            this.Load += new System.EventHandler(this.ReceiptControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblMessage;
    }
}
