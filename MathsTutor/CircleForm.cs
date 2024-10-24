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
    public partial class frmCircle : Form
    {
        // initializing the validation variable using the validation class
        private Validation Validation;
        public frmCircle()
        {
            InitializeComponent();
            // creates a new instance of the validation object which is used for validating data input
            Validation = new Validation();
        }

        // method for when the area button is clicked
        private void btnArea_Click(object sender, EventArgs e)
        {
            // if method for validating each textbox to ensure the right information is inputted by the user
            if (Validation.IsPresent(txtRadius, "Radius") && Validation.IsInteger(txtRadius, "Radius")
                && Validation.IsWithinRange(txtRadius, "Radius", 0, 100))
            {
                // initializing the radius variable by using the information in the textbox
                double radius = Convert.ToDouble(txtRadius.Text);

                // creating a new circle object with a description which shows the formula to work out the area
                Circle c = new Circle("Circle: Area = A = πr2");

                // setting the circle objects dimension using the radius variable
                c.setDimension1(radius);

                // displaying the shapes description on screen
                lblDescription.Text = c.getDescription();

                // displaying the calculation for the area of the shape and the answer
                lblArea.Text = "Area = 3.14 x " + radius + "cm x " + radius + "cm = " + c.calculateArea() + "cm";
            }
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
