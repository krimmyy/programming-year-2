using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoHamburger.Checked == true)
            {
                cbxAddOn1.Text = "Lettuce, tomato and onions";
                cbxAddOn2.Text = "Ketchup, mustard and mayonnaise";
                cbxAddOn3.Text = "French fries";
            }
            else
            {
                cbxAddOn1.Checked = false;
                cbxAddOn2.Checked = false;
                cbxAddOn3.Checked = false;
            }
         
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPizza.Checked == true)
            {
                cbxAddOn1.Text = "Pepperoni";
                cbxAddOn2.Text = "Sausage";
                cbxAddOn3.Text = "Olives";
            }
            else
            {
                cbxAddOn1.Checked = false;
                cbxAddOn2.Checked = false;
                cbxAddOn3.Checked = false;
            }
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSalad.Checked == true)
            {
                cbxAddOn1.Text = "Croutons";
                cbxAddOn2.Text = "Bacon bits";
                cbxAddOn3.Text = "Bread sticks";
            }
            else
            {
                cbxAddOn1.Checked = false;
                cbxAddOn2.Checked = false;
                cbxAddOn3.Checked = false;
            }
        }

        private void cbxAddOn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxAddOn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxAddOn3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double addOn1 = 0;
            double addOn2 = 0;
            double addOn3 = 0;
            double mainPrice = 0;
            double subTotal = 0;
            double totalPrice = 0;
            double taxPrice = 0;

            if(rdoHamburger.Checked)
            {
                mainPrice = 6.95;
                if(cbxAddOn1.Checked)
                {
                    addOn1 = 0.75;
                }
                if(cbxAddOn2.Checked)
                {
                    addOn2 = 0.75;
                }
                if(cbxAddOn3.Checked)
                {
                    addOn3 = 0.75;
                }
                subTotal = mainPrice + addOn1 + addOn2 + addOn3;
                taxPrice = subTotal / 100 * 7.75;
                totalPrice = subTotal + taxPrice;
                txtSubtotal.Text = subTotal.ToString("c");
                txtTax.Text = taxPrice.ToString("c");
                txtTotal.Text = totalPrice.ToString("c");

            }
            else if (rdoPizza.Checked)
            {
                mainPrice = 5.95;
                if (cbxAddOn1.Checked)
                {
                    addOn1 = 0.75;
                }
                if (cbxAddOn2.Checked)
                {
                    addOn2 = 0.75;
                }
                if (cbxAddOn3.Checked)
                {
                    addOn3 = 0.75;
                }
                subTotal = mainPrice + addOn1 + addOn2 + addOn3;
                taxPrice = subTotal / 100 * 7.75;
                totalPrice = subTotal + taxPrice;
                txtSubtotal.Text = subTotal.ToString("c");
                txtTax.Text = taxPrice.ToString("c");
                txtTotal.Text = totalPrice.ToString("c");
            }
            else if (rdoSalad.Checked)
            {
                mainPrice = 4.95;
                if (cbxAddOn1.Checked)
                {
                    addOn1 = 0.75;
                }
                if (cbxAddOn2.Checked)
                {
                    addOn2 = 0.75;
                }
                if (cbxAddOn3.Checked)
                {
                    addOn3 = 0.75;
                }
                subTotal = mainPrice + addOn1 + addOn2 + addOn3;
                taxPrice = subTotal / 100 * 7.75;
                totalPrice = subTotal + taxPrice;
                txtSubtotal.Text = subTotal.ToString("c");
                txtTax.Text = taxPrice.ToString("c");
                txtTotal.Text = totalPrice.ToString("c");
            }
            else
            {
                if(cbxAddOn1.Checked)
                {
                    txtSubtotal.Clear();
                    txtTax.Clear();
                    txtTotal.Clear();
                }
                if(cbxAddOn2.Checked)
                {
                    txtSubtotal.Clear();
                    txtTax.Clear();
                    txtTotal.Clear();
                }
                if(cbxAddOn3.Checked)
                {
                    txtSubtotal.Clear();
                    txtTax.Clear();
                    txtTotal.Clear();
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The order was placed at " + DateTime.Now.ToString() + ". The order total is: " + txtTotal.Text + ".");
            this.Close();
        }
    }
}
