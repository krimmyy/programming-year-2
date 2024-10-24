namespace LunchOrder
{
    partial class frmLunchOrder
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
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.gbxAddOns = new System.Windows.Forms.GroupBox();
            this.gbxTotals = new System.Windows.Forms.GroupBox();
            this.cbxAddOn1 = new System.Windows.Forms.CheckBox();
            this.cbxAddOn2 = new System.Windows.Forms.CheckBox();
            this.cbxAddOn3 = new System.Windows.Forms.CheckBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbxMainCourse.SuspendLayout();
            this.gbxAddOns.SuspendLayout();
            this.gbxTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rdoHamburger);
            this.gbxMainCourse.Controls.Add(this.rdoPizza);
            this.gbxMainCourse.Controls.Add(this.rdoSalad);
            this.gbxMainCourse.Location = new System.Drawing.Point(34, 36);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Size = new System.Drawing.Size(200, 100);
            this.gbxMainCourse.TabIndex = 0;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main Course";
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Location = new System.Drawing.Point(20, 19);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdoHamburger.TabIndex = 1;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - £6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(20, 42);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 2;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - £5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(20, 65);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 3;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - £4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // gbxAddOns
            // 
            this.gbxAddOns.Controls.Add(this.cbxAddOn1);
            this.gbxAddOns.Controls.Add(this.cbxAddOn2);
            this.gbxAddOns.Controls.Add(this.cbxAddOn3);
            this.gbxAddOns.Location = new System.Drawing.Point(352, 36);
            this.gbxAddOns.Name = "gbxAddOns";
            this.gbxAddOns.Size = new System.Drawing.Size(201, 89);
            this.gbxAddOns.TabIndex = 1;
            this.gbxAddOns.TabStop = false;
            this.gbxAddOns.Text = "Add-on Items";
            // 
            // gbxTotals
            // 
            this.gbxTotals.Controls.Add(this.txtTotal);
            this.gbxTotals.Controls.Add(this.lblSubtotal);
            this.gbxTotals.Controls.Add(this.lblTax);
            this.gbxTotals.Controls.Add(this.lblTotal);
            this.gbxTotals.Controls.Add(this.txtTax);
            this.gbxTotals.Controls.Add(this.txtSubtotal);
            this.gbxTotals.Location = new System.Drawing.Point(54, 186);
            this.gbxTotals.Name = "gbxTotals";
            this.gbxTotals.Size = new System.Drawing.Size(227, 113);
            this.gbxTotals.TabIndex = 2;
            this.gbxTotals.TabStop = false;
            this.gbxTotals.Text = "Order Total";
            // 
            // cbxAddOn1
            // 
            this.cbxAddOn1.AutoSize = true;
            this.cbxAddOn1.Location = new System.Drawing.Point(6, 19);
            this.cbxAddOn1.Name = "cbxAddOn1";
            this.cbxAddOn1.Size = new System.Drawing.Size(15, 14);
            this.cbxAddOn1.TabIndex = 4;
            this.cbxAddOn1.UseVisualStyleBackColor = true;
            this.cbxAddOn1.CheckedChanged += new System.EventHandler(this.cbxAddOn1_CheckedChanged);
            // 
            // cbxAddOn2
            // 
            this.cbxAddOn2.AutoSize = true;
            this.cbxAddOn2.Location = new System.Drawing.Point(6, 39);
            this.cbxAddOn2.Name = "cbxAddOn2";
            this.cbxAddOn2.Size = new System.Drawing.Size(15, 14);
            this.cbxAddOn2.TabIndex = 5;
            this.cbxAddOn2.UseVisualStyleBackColor = true;
            this.cbxAddOn2.CheckedChanged += new System.EventHandler(this.cbxAddOn2_CheckedChanged);
            // 
            // cbxAddOn3
            // 
            this.cbxAddOn3.AutoSize = true;
            this.cbxAddOn3.Location = new System.Drawing.Point(6, 59);
            this.cbxAddOn3.Name = "cbxAddOn3";
            this.cbxAddOn3.Size = new System.Drawing.Size(15, 14);
            this.cbxAddOn3.TabIndex = 6;
            this.cbxAddOn3.UseVisualStyleBackColor = true;
            this.cbxAddOn3.CheckedChanged += new System.EventHandler(this.cbxAddOn3_CheckedChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(92, 28);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 7;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(34, 28);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 8;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(20, 54);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 13);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax (7.75%):";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(92, 54);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 10;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Order Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(411, 175);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(411, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(92, 80);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbxTotals);
            this.Controls.Add(this.gbxAddOns);
            this.Controls.Add(this.gbxMainCourse);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gbxAddOns.ResumeLayout(false);
            this.gbxAddOns.PerformLayout();
            this.gbxTotals.ResumeLayout(false);
            this.gbxTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.GroupBox gbxAddOns;
        private System.Windows.Forms.GroupBox gbxTotals;
        private System.Windows.Forms.CheckBox cbxAddOn1;
        private System.Windows.Forms.CheckBox cbxAddOn2;
        private System.Windows.Forms.CheckBox cbxAddOn3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

