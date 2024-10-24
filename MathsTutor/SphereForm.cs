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
    public partial class frmSphere : Form
    {
        // initializing the validation variable using the validation class
        private Validation Validation;
        public frmSphere()
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
                && Validation.IsWithinRange(txtRadius, "Radius", 0, 100))
            {
                // initializing the radius variable by using the information in the textbox
                double radius = Convert.ToDouble(txtRadius.Text);

                // creating a new sphere object with a description which shows the formula to work out the volume
                Sphere s = new Sphere("Sphere: Volume = 4 / 3 πr3", radius);

                // setting the sphere objects dimension using the side variable
                s.setDimension1(radius);

                // displaying the shapes description on screen
                lblDescription.Text = s.getDescription();

                // displaying the calculation for the volume of the shape and the answer
                lblVolume.Text = "Volume = 4 / 3 x π x " + radius + "cm x " + radius + "cm x " + radius + "cm = " + s.calculateVolume() + "cm";
            }
        }
    }
}
