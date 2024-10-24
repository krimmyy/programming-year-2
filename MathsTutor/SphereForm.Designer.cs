namespace MathsTutor
{
    partial class frmSphere
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
            this.btnVolume = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.Location = new System.Drawing.Point(141, 102);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(120, 56);
            this.btnVolume.TabIndex = 0;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(210, 63);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(78, 70);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(66, 13);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius (cm):";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(78, 176);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(78, 239);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(51, 13);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.Text = "Volume =";
            // 
            // frmSphere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(448, 293);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnVolume);
            this.Name = "frmSphere";
            this.Text = "SphereForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblVolume;
    }
}