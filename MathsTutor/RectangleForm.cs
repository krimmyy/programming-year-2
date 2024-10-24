using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace MathsTutor
{
    public partial class frmRectangle : Form
    {
        // initializing the validation variable using the validation class
        private Validation Validation;
        public frmRectangle()
        {
            InitializeComponent();
            // creates a new instance of the validation object which is used for validating data input
            Validation = new Validation();
        }

        // method for when the area button is clicked
        private void btnArea_Click(object sender, EventArgs e)
        {
            // if method for validating each textbox to ensure the right information is inputted by the user
            if (Validation.IsPresent(txtLength, "Length") && Validation.IsInteger(txtLength, "Length")
                && Validation.IsPresent(txtBreadth, "Breadth") && Validation.IsInteger(txtBreadth, "Breadth")
                && Validation.IsWithinRange(txtBreadth, "Breadth", 0, 100) && Validation.IsWithinRange(txtLength, "Length", 0, 100))
            {
                // initializing the length and breadth variables by using the information in the textboxes
                double length = Convert.ToDouble(txtLength.Text);
                double breadth = Convert.ToDouble(txtBreadth.Text);

                // creating a new rectangle object with a description which shows the formula to work out the area
                Rectangle r = new Rectangle("Rectangle: Area = Length x Breadth", length, breadth);

                // setting the rectangle objects dimensions using the length and breadth variables
                r.setDimension1(length);
                r.setDimension2(breadth);

                // displaying the shapes description on screen
                lblDescription.Text = r.getDescription();

                // displaying the calculation for the area of the shape and the answer
                lblArea.Text = "Area = " + length + "cm x " + breadth + "cm = " + r.calculateArea() + "cm";
            }
            
        }
    }
}
