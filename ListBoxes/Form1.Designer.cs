namespace ListBoxes
{
    partial class frmTeams
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.lstATeam = new System.Windows.Forms.ListBox();
            this.lstBTeam = new System.Windows.Forms.ListBox();
            this.btnToB = new System.Windows.Forms.Button();
            this.btnToA = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add to Team A";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Location = new System.Drawing.Point(64, 101);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(44, 13);
            this.lblTeamA.TabIndex = 2;
            this.lblTeamA.Text = "Team A";
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.Location = new System.Drawing.Point(317, 101);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(44, 13);
            this.lblTeamB.TabIndex = 3;
            this.lblTeamB.Text = "Team B";
            // 
            // lstATeam
            // 
            this.lstATeam.FormattingEnabled = true;
            this.lstATeam.Location = new System.Drawing.Point(35, 136);
            this.lstATeam.Name = "lstATeam";
            this.lstATeam.Size = new System.Drawing.Size(120, 121);
            this.lstATeam.TabIndex = 4;
            // 
            // lstBTeam
            // 
            this.lstBTeam.FormattingEnabled = true;
            this.lstBTeam.Location = new System.Drawing.Point(277, 136);
            this.lstBTeam.Name = "lstBTeam";
            this.lstBTeam.Size = new System.Drawing.Size(120, 121);
            this.lstBTeam.TabIndex = 5;
            // 
            // btnToB
            // 
            this.btnToB.Location = new System.Drawing.Point(176, 146);
            this.btnToB.Name = "btnToB";
            this.btnToB.Size = new System.Drawing.Size(75, 23);
            this.btnToB.TabIndex = 6;
            this.btnToB.Text = ">>";
            this.btnToB.UseVisualStyleBackColor = true;
            this.btnToB.Click += new System.EventHandler(this.btnToB_Click);
            // 
            // btnToA
            // 
            this.btnToA.Location = new System.Drawing.Point(176, 213);
            this.btnToA.Name = "btnToA";
            this.btnToA.Size = new System.Drawing.Size(75, 23);
            this.btnToA.TabIndex = 7;
            this.btnToA.Text = "<<";
            this.btnToA.UseVisualStyleBackColor = true;
            this.btnToA.Click += new System.EventHandler(this.btnToA_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(353, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 48);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(277, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 48);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Team Lists";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 285);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToA);
            this.Controls.Add(this.btnToB);
            this.Controls.Add(this.lstBTeam);
            this.Controls.Add(this.lstATeam);
            this.Controls.Add(this.lblTeamB);
            this.Controls.Add(this.lblTeamA);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Name = "frmTeams";
            this.Text = "Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.Label lblTeamB;
        private System.Windows.Forms.ListBox lstATeam;
        private System.Windows.Forms.ListBox lstBTeam;
        private System.Windows.Forms.Button btnToB;
        private System.Windows.Forms.Button btnToA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

