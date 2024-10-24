namespace MathsTutor
{
    partial class frmVolume
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
            this.btnTitle = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCylinder = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnSphere = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnCuboid = new System.Windows.Forms.Button();
            this.btnExit2Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.Brown;
            this.btnTitle.Location = new System.Drawing.Point(45, 37);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(375, 71);
            this.btnTitle.TabIndex = 7;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Brown;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(118, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 31);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Volume Calculator";
            // 
            // btnCylinder
            // 
            this.btnCylinder.BackColor = System.Drawing.Color.Yellow;
            this.btnCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCylinder.Location = new System.Drawing.Point(64, 143);
            this.btnCylinder.Name = "btnCylinder";
            this.btnCylinder.Size = new System.Drawing.Size(120, 62);
            this.btnCylinder.TabIndex = 9;
            this.btnCylinder.Text = "Cylinder";
            this.btnCylinder.UseVisualStyleBackColor = false;
            this.btnCylinder.Click += new System.EventHandler(this.btnCylinder_Click);
            // 
            // btnCube
            // 
            this.btnCube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCube.Location = new System.Drawing.Point(276, 143);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(120, 62);
            this.btnCube.TabIndex = 10;
            this.btnCube.Text = "Cube";
            this.btnCube.UseVisualStyleBackColor = false;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnSphere
            // 
            this.btnSphere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSphere.Location = new System.Drawing.Point(64, 254);
            this.btnSphere.Name = "btnSphere";
            this.btnSphere.Size = new System.Drawing.Size(120, 62);
            this.btnSphere.TabIndex = 11;
            this.btnSphere.Text = "Sphere";
            this.btnSphere.UseVisualStyleBackColor = false;
            this.btnSphere.Click += new System.EventHandler(this.btnSphere_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.Location = new System.Drawing.Point(64, 361);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(120, 61);
            this.btnQuiz.TabIndex = 12;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnCuboid
            // 
            this.btnCuboid.BackColor = System.Drawing.Color.Cyan;
            this.btnCuboid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuboid.ForeColor = System.Drawing.Color.Black;
            this.btnCuboid.Location = new System.Drawing.Point(276, 254);
            this.btnCuboid.Name = "btnCuboid";
            this.btnCuboid.Size = new System.Drawing.Size(120, 62);
            this.btnCuboid.TabIndex = 13;
            this.btnCuboid.Text = "Cuboid";
            this.btnCuboid.UseVisualStyleBackColor = false;
            this.btnCuboid.Click += new System.EventHandler(this.btnCuboid_Click);
            // 
            // btnExit2Main
            // 
            this.btnExit2Main.BackColor = System.Drawing.Color.Red;
            this.btnExit2Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2Main.Location = new System.Drawing.Point(276, 360);
            this.btnExit2Main.Name = "btnExit2Main";
            this.btnExit2Main.Size = new System.Drawing.Size(120, 62);
            this.btnExit2Main.TabIndex = 14;
            this.btnExit2Main.Text = "Exit";
            this.btnExit2Main.UseVisualStyleBackColor = false;
            this.btnExit2Main.Click += new System.EventHandler(this.btnExit2Main_Click);
            // 
            // frmVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(469, 455);
            this.Controls.Add(this.btnExit2Main);
            this.Controls.Add(this.btnCuboid);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.btnSphere);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnCylinder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTitle);
            this.Name = "frmVolume";
            this.Text = "VolumeMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCylinder;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnSphere;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnCuboid;
        private System.Windows.Forms.Button btnExit2Main;
    }
}