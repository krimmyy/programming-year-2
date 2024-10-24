namespace MathsTutor
{
    partial class frmCircle
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(44, 53);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(134, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius of Circle (1-100cm):";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(44, 168);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(44, 222);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 13);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area =";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(184, 50);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(76, 20);
            this.txtRadius.TabIndex = 3;
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(101, 96);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(104, 47);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // frmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(316, 270);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRadius);
            this.Name = "frmCircle";
            this.Text = "CircleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnArea;
    }
}