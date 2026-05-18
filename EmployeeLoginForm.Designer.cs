namespace ATMProject
{
    partial class EmployeeLoginForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtAccountNo = new System.Windows.Forms.RichTextBox();
            this.txtPin = new System.Windows.Forms.RichTextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(524, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 62);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(460, 250);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(455, 60);
            this.txtAccountNo.TabIndex = 2;
            this.txtAccountNo.Text = "";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(460, 348);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(455, 60);
            this.txtPin.TabIndex = 3;
            this.txtPin.Text = "";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(321, 274);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(96, 20);
            this.lblAccountNo.TabIndex = 4;
            this.lblAccountNo.Text = "Account No.";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(352, 365);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(35, 20);
            this.lblPin.TabIndex = 5;
            this.lblPin.Text = "PIN";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(751, 452);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 62);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // EmployeeLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMProject.Properties.Resources.Image__3_;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.btnBack);
            this.Name = "EmployeeLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox txtAccountNo;
        private System.Windows.Forms.RichTextBox txtPin;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Button btnLogin;
    }
}