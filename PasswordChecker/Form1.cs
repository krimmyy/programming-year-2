using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

            if (txtPassword1.Text.CompareTo(txtPassword2.Text) == 0)
                lblMessage.Text = "Passwords Match";
            else
                lblMessage.Text = "Passwords Do Not Match";
        }
    }
}
