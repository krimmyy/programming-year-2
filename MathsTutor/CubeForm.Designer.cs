namespace MathsTutor
{
    partial class frmCube
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.ForeColor = System.Drawing.Color.Black;
            this.btnVolume.Location = new System.Drawing.Point(114, 88);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(104, 53);
            this.btnVolume.TabIndex = 0;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Side (cm):";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(156, 51);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(100, 20);
            this.txtSide.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(52, 174);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(52, 227);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(51, 13);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.Text = "Volume =";
            // 
            // frmCube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(348, 291);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtSide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolume);
            this.Name = "frmCube";
            this.Text = "CubeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblVolume;
    }
}