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
    public partial class frmCuboid : Form
    {
        // initializing the validation variable using the validation class
        private Validation Validation;
        public frmCuboid()
        {
            InitializeComponent();
            // creates a new instance of the validation object which is used for validating data input
            Validation = new Validation();
        }

        // method for when the volume button is clicked
        private void btnVolume_Click(object sender, EventArgs e)
        {
            // if method for validating each textbox to ensure the right information is inputted by the user
            if (Validation.IsPresent(txtLength, "Length") && Validation.IsInteger(txtLength, "Length")
                && Validation.IsPresent(txtWidth, "Width") && Validation.IsInteger(txtWidth, "Width")
                && Validation.IsPresent(txtHeight, "Height") && Validation.IsInteger(txtHeight, "Height")
                && Validation.IsWithinRange(txtLength, "Length", 0, 100) && Validation.IsWithinRange(txtWidth, "Width", 0, 100)
                && Validation.IsWithinRange(txtHeight, "Height", 0, 100))
            {
                // initializing the length, width and height variables by using the information in the textboxes
                double length = Convert.ToDouble(txtLength.Text);
                double width = Convert.ToDouble(txtWidth.Text);
                double height = Convert.ToDouble(txtHeight.Text);

                // creating a new cuboid object with a description which shows the formula to work out the volume
                Cuboid c = new Cuboid("Cuboid: Volume = Length x Width x Height", length, width, height);

                // setting the cuboid objects dimensions using the length, width and height variables
                c.setDimension1(length);
                c.setDimension2(width);
                c.setDimension3(height);

                // displaying the shapes description on screen
                lblDescription.Text = c.getDescription();

                // displaying the calculation for the volume of the shape and the answer
                lblVolume.Text = "Volume = " + length + "cm x " + width + "cm x " + height + "cm = " + c.calculateVolume() + "cm";
            }
        }
    }
}
