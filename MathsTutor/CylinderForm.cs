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
    public partial class frmCylinder : Form
    {
        // initializing the validation variable using the validation class
        private Validation Validation;
        public frmCylinder()
        {
            InitializeComponent();
            // creates a new instance of the validation object which is used for validating data input
            Validation = new Validation();
        }

        // method for when the volume button is clicked
        private void btnVolume_Click(object sender, EventArgs e)
        {
            // if method for validating each textbox to ensure the right information is inputted by the user
            if (Validation.IsPresent(txtRadius, "Radius") && Validation.IsInteger(txtRadius, "Radius")
                && Validation.IsPresent(txtHeight, "Height") && Validation.IsInteger(txtHeight, "Height")
                && Validation.IsWithinRange(txtRadius, "Radius", 0, 100) && Validation.IsWithinRange(txtHeight, "Height", 0, 100))
            {
                // initializing the radius and height variables by using the information in the textboxes
                double radius = Convert.ToDouble(txtRadius.Text);
                double height = Convert.ToDouble(txtHeight.Text);

                // creating a new cylinder object with a description which shows the formula to work out the volume
                Cylinder c = new Cylinder("Cylinder: Volume = πr2h", radius, height);

                // setting the cylinder objects dimension using the radius and height variables
                c.setDimension1(radius);
                c.setDimension2(height);

                // displaying the shapes description on screen
                lblDescription.Text = c.getDescription();

                // displaying the calculation for the volume of the shape and the answer
                lblVolume.Text = "Volume = π x " + radius + "cm x " + radius + "cm x " + height + "cm = " + c.calculateVolume() + "cm";
            }
        }
    }
}
