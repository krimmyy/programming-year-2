namespace MathsTutor
{
    partial class frmMainMenu
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(214, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 74);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(61, 160);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(182, 109);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.Location = new System.Drawing.Point(335, 160);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(182, 109);
            this.btnVolume.TabIndex = 2;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Brown;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(112, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(351, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Area and Volume Calculator";
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.Brown;
            this.btnTitle.Location = new System.Drawing.Point(97, 32);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(375, 71);
            this.btnTitle.TabIndex = 4;
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(572, 386);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTitle;
    }
}