using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloYou
{
    public partial class frmHelloYou : Form
    {
        public frmHelloYou()
        {
            InitializeComponent();
        }

        private void frmHelloYou_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lblHello.Text = "Hello " + name;
        }
    }
}
