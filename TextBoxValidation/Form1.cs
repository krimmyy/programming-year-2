using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxValidation
{
    public partial class frmTextBoxValidate : Form
    {
        public frmTextBoxValidate()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isPresent(txtAge, "Age") && isPresent(txtName, "Name"))
            {
                MessageBox.Show("Hello " + txtName.Text +
                    "\n\nYou are " + txtAge.Text + " years old.");
            }

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Please enter only letters!");
                e.Handled = true;
                txtName.Clear();
            }

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
                txtAge.Clear();
            }

        }

        public bool isPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field!");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
