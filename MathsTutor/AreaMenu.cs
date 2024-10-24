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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        // method for when the square button is clicked
        private void btnSquare_Click(object sender, EventArgs e)
        {
            // creates a new instance of the square form and displays it on screen
            Form squareForm = new frmSquare();
            squareForm.Show();
        }

        // method for when the rectangle button is clicked
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            // creates a new instance of the rectangle form and displays it on screen
            Form rectangleForm = new frmRectangle();
            rectangleForm.Show();

        }

        // method for when the cirle button is clicked
        private void btnCircle_Click(object sender, EventArgs e)
        {
            // creates a new instance of the circle form and displays it on screen
            Form circleForm = new frmCircle();
            circleForm.Show();
        }

        // method for when the triangle button is clicked
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            // creates a new instance of the triangle form and displays it on screen
            Form triangleForm = new frmTriangle();
            triangleForm.Show();
        }

        // method for when the quiz button is clicked
        private void btnQuiz_Click(object sender, EventArgs e)
        {
            // creates a new instance of the area quiz form and displays it on screen
            Form areaQuizForm = new frmAreaQuiz();
            areaQuizForm.Show();
        }

        // method for when the exit button is clicked
        private void btnExit2Main_Click(object sender, EventArgs e)
        {
            // closes the form down
            this.Close();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
