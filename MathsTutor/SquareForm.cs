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
    public partial class frmSquare : Form
    {
        // initializing the validation variable using the validation class
        private Validation Validation;
        public frmSquare()
        {
            InitializeComponent();
            // creates a new instance of the validation object which is used for validating data input
            Validation = new Validation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // method for when the area button is clicked
        private void btnArea_Click(object sender, EventArgs e)
        {
            // if method for validating each textbox to ensure the right information is inputted by the user
            if (Validation.IsPresent(txtLength, "Length") && Validation.IsInteger(txtLength, "Length")
                && Validation.IsWithinRange(txtLength, "Length", 0, 100))
            {
                // initializing the length variable by using the information in the textbox
                double length = Convert.ToDouble(txtLength.Text);

                // creating a new square object with a description which shows the formula to work out the area
                Square s = new Square("Square: All sides are equal." + "\n\nArea = length x length", length);

                // displaying the shapes description on screen
                lblDescription.Text = s.getDescription();

                // displaying the calculation for the area of the shape and the answer
                lblArea.Text = "Area = " + length + "cm x " + length + "cm = " + s.calculateArea() + "cm";
            }
            
        }
    }
}
