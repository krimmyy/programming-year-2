using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsTutor
{
    public class Validation
    {
        // method for checking if the data is an integer
        public bool IsInteger(TextBox textBox, string name)
        {
            try
            {
                // try converting the data from the textbox into an integer and storing it to a variable
                int num = Convert.ToInt32(textBox.Text);
                // if the data is an integer it succeeds and breaks out of the loop
                return true;
            }
            catch
            {
                // if there is an exception thrown during the conversion because the data entered is not an integer
                // display the error message, clear the textbox and let the user try entering it again
                MessageBox.Show(name + " must be a whole number!");
                textBox.Clear();
                textBox.Focus();
                // if unsuccessful then it stays false and loops again
                return false;
            }
        }

        // method for checking if the data is within a specified range
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            // converting the data inputted into the textbox into a decimal and storing it to a variable
            decimal number = Convert.ToDecimal(textBox.Text);
            // check if the number entered is within the specified range
            if (number < min || number > max)
            {
                // if the data entered is outside the range then display an error message with the range to help the user with correcting themselves
                // clear the textbox and let the user try entering again
                MessageBox.Show(name + " has to be between " + min + " and " + max + ".", "Error!");
                textBox.Clear();
                textBox.Focus();
                // if unsuccessful then it stays false and loops again
                return false;
            }
            // if the data is within range it succeeds and breaks out of the loop
            return true;
        }

        // method for checking if there is any data inputted
        public bool IsPresent(TextBox textBox, string name)
        {
            // checking if the textbox is empty or if there are only whitespaces
            if (string.IsNullOrEmpty(textBox.Text))
            {
                // if the textbox is empty then an error message is displayed and the user is allowed to enter again
                MessageBox.Show(name + " has to be filled out!");
                textBox.Focus();
                // if unsuccessful then it stays false and loops again
                return false;
            }
            // if there is correct data entered it succeeds and breaks out of the loop
            return true;
        }
    }
}
