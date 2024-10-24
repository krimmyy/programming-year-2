namespace PasswordChecker
{
    partial class Form1
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
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(105, 41);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(137, 13);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Please enter your password";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(122, 76);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(100, 20);
            this.txtPassword1.TabIndex = 1;
            this.txtPassword1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(92, 123);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(166, 13);
            this.lblInfo2.TabIndex = 2;
            this.lblInfo2.Text = "Please enter your password again";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(122, 157);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(100, 20);
            this.txtPassword2.TabIndex = 3;
            this.txtPassword2.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(119, 199);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 339);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.lblInfo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblMessage;
    }
}

