using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsTutor
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        // method for when the area button is clicked
        private void btnArea_Click(object sender, EventArgs e)
        {
            // creates a new instance of the area form and displays it on screen
            Form areaForm = new frmArea();
            areaForm.Show();
        }


        // method for when the volume button is clicked
        private void btnVolume_Click(object sender, EventArgs e)
        {
            // creates a new instance of the volume form and displays it on screen
            Form volumeForm = new frmVolume();
            volumeForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        // method for when the exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            // form is closed down
            this.Close();
        }
    }
}
