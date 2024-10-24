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
    public partial class frmVolume : Form
    {
        public frmVolume()
        {
            InitializeComponent();
        }

        // method for when the cylinder button is clicked
        private void btnCylinder_Click(object sender, EventArgs e)
        {
            // creates a new instance of the cylinder form and displays it on screen
            Form cylinderForm = new frmCylinder();
            cylinderForm.Show();
        }

        // method for when the exit button is clicked
        private void btnExit2Main_Click(object sender, EventArgs e)
        {
            // closes the form down
            this.Close();
        }

        // method for when the quiz button is clicked
        private void btnQuiz_Click(object sender, EventArgs e)
        {
            // creates a new instance of the volume quiz form and displays it on screen
            Form volumeQuizForm = new frmVolumeQuiz();
            volumeQuizForm.Show();
        }

        // method for when the cube button is clicked
        private void btnCube_Click(object sender, EventArgs e)
        {
            // creates a new instance of the cube form and displays it on screen
            Form cubeForm = new frmCube();
            cubeForm.Show();
        }

        // method for when the sphere button is clicked
        private void btnSphere_Click(object sender, EventArgs e)
        {
            // creates a new instance of the sphere form and displays it on screen
            Form sphereForm = new frmSphere();
            sphereForm.Show();
        }

        // method for when the cuboid button is clicked
        private void btnCuboid_Click(object sender, EventArgs e)
        {
            // creates a new instance of the cuboid form and displays it on screen
            Form cuboidForm = new frmCuboid();
            cuboidForm.Show();
        }
    }
}
