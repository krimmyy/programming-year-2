namespace MathsTutor
{
    partial class frmTriangle
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
            this.btnArea = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(264, 59);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(92, 60);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(58, 59);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(57, 13);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base (cm):";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(135, 56);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(55, 174);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description: ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(55, 229);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area =";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(58, 99);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(64, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height (cm):";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(135, 96);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 6;
            // 
            // frmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(435, 321);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnArea);
            this.Name = "frmTriangle";
            this.Text = "TriangleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
    }
}

