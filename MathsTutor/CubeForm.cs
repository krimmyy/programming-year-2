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
    public partial class frmCube : Form
    {
        // initializing the validation variable using the validation class
        private Validation Validation;
        public frmCube()
        {
            InitializeComponent();
            // creates a new instance of the validation object which is used for validating data input
            Validation = new Validation();
        }

        // method for when the volume button is clicked
        private void btnVolume_Click(object sender, EventArgs e)
        {
            // if method for validating each textbox to ensure the right information is inputted by the user
            if (Validation.IsPresent(txtSide, "Side") && Validation.IsInteger(txtSide, "Side")
                && Validation.IsWithinRange(txtSide, "Side", 0, 100))
            {
                // initializing the side variable by using the information in the textbox
                double side = Convert.ToDouble(txtSide.Text);

                // creating a new cube object with a description which shows the formula to work out the volume
                Cube c = new Cube("Cube: Volume = Side x Side x Side", side);

                // setting the cube objects dimension using the side variable
                c.setDimension1(side);

                // displaying the shapes description on screen
                lblDescription.Text = c.getDescription();

                // displaying the calculation for the volume of the shape and the answer
                lblVolume.Text = "Volume = " + side + "cm x " + side + "cm x " + side + "cm = " + c.calculateVolume() + "cm";
            }   
        }
    }
}
