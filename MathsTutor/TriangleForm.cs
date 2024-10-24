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
    public partial class frmTriangle : Form
    {
        // initializing the validation variable using the validation class
        private Validation Validation;
        public frmTriangle()
        {
            InitializeComponent();
            // creates a new instance of the validation object which is used for validating data input
            Validation = new Validation();
        }

        // method for when the area button is clicked
        private void btnArea_Click(object sender, EventArgs e)
        {
            // if method for validating each textbox to ensure the right information is inputted by the user
            if (Validation.IsPresent(txtBase, "Base") && Validation.IsInteger(txtBase, "Base")
                && Validation.IsPresent(txtHeight, "Height") && Validation.IsInteger(txtHeight, "Height")
                && Validation.IsWithinRange(txtBase, "Base", 0, 100) && Validation.IsWithinRange(txtHeight, "Height", 0, 100))
            {
                // initializing the base and height variable by using the information in the textbox
                double base1 = Convert.ToDouble(txtBase.Text);
                double height = Convert.ToDouble(txtBase.Text);

                // creating a new triangle object with a description which shows the formula to work out the area
                Triangle t = new Triangle("Triangle: Area = 1/2 (Base x Height)" ,base1, height);

                // setting the triangle objects dimensions using the base and height variables
                t.setDimension1(base1);
                t.setDimension2(height);

                // displaying the shapes description on screen
                lblDescription.Text = t.getDescription();

                // displaying the calculation for the area of the shape and the answer
                lblArea.Text = "Area = 1/2 (" + base1 + "cm x " + height + "cm =" + t.calculateArea() + "cm)"; 
            }
        }
    }
}
