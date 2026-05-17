namespace ATMProject
{
    partial class FastCashControl
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
            this.btn500 = new System.Windows.Forms.Button();
            this.btn5000 = new System.Windows.Forms.Button();
            this.btn2000 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn500.Location = new System.Drawing.Point(362, 442);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(227, 85);
            this.btn500.TabIndex = 0;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = false;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn5000
            // 
            this.btn5000.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5000.Location = new System.Drawing.Point(686, 597);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(227, 85);
            this.btn5000.TabIndex = 1;
            this.btn5000.Text = "5000";
            this.btn5000.UseVisualStyleBackColor = false;
            // 
            // btn2000
            // 
            this.btn2000.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2000.Location = new System.Drawing.Point(362, 608);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(227, 85);
            this.btn2000.TabIndex = 2;
            this.btn2000.Text = "2000";
            this.btn2000.UseVisualStyleBackColor = false;
            // 
            // btn1000
            // 
            this.btn1000.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1000.Location = new System.Drawing.Point(686, 442);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(227, 85);
            this.btn1000.TabIndex = 3;
            this.btn1000.Text = "1000";
            this.btn1000.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "FAST CASH";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(464, 605);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 25);
            this.lblMessage.TabIndex = 5;
            // 
            // FastCashControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMProject.Properties.Resources.atm_machine13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn2000);
            this.Controls.Add(this.btn5000);
            this.Controls.Add(this.btn500);
            this.Name = "FastCashControl";
            this.Size = new System.Drawing.Size(2551, 1312);
            this.Load += new System.EventHandler(this.FastCashControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn5000;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
    }
}
