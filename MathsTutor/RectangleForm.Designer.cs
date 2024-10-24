namespace MathsTutor
{
    partial class frmRectangle
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblBreadth = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtBreadth = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(52, 43);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(66, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (cm):";
            // 
            // lblBreadth
            // 
            this.lblBreadth.AutoSize = true;
            this.lblBreadth.Location = new System.Drawing.Point(52, 81);
            this.lblBreadth.Name = "lblBreadth";
            this.lblBreadth.Size = new System.Drawing.Size(70, 13);
            this.lblBreadth.TabIndex = 1;
            this.lblBreadth.Text = "Breadth (cm):";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(52, 197);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 13);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area =";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(52, 139);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(133, 43);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 4;
            // 
            // txtBreadth
            // 
            this.txtBreadth.Location = new System.Drawing.Point(133, 81);
            this.txtBreadth.Name = "txtBreadth";
            this.txtBreadth.Size = new System.Drawing.Size(100, 20);
            this.txtBreadth.TabIndex = 5;
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(250, 43);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(82, 58);
            this.btnArea.TabIndex = 6;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // frmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(413, 253);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtBreadth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblBreadth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmRectangle";
            this.Text = "RectangleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblBreadth;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtBreadth;
        private System.Windows.Forms.Button btnArea;
    }
}