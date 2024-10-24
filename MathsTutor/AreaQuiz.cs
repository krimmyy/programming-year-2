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
    public partial class frmAreaQuiz : Form
    {
        // initializing score variable
        private int score;
        public frmAreaQuiz()
        {
            // loading both methods used the area quiz
            InitializeComponent();
            InitializeQuiz();
        }

        // method used for displaying the questions and answers
        private void InitializeQuiz()
        {
            // setting score to 0
            score = 0;

            // First Question
            groupBox1.Text = "The perimeter of a shape is";
            rbtnQ1Option1.Text = "The biggest and smallest \n side multiplied";
            rbtnQ1Option2.Text = "The distance around \n the outside edge"; // Correct Answer
            rbtnQ1Option3.Text = "The amount of space \n covered by the shape"; 
            rbtnQ1Option4.Text = "The length of all sides added up"; // Correct Answer

            // Second Question
            groupBox2.Text = "The perimeter of an object is always the same as its area";
            rbtnQ2Option1.Text = "Sometimes";
            rbtnQ2Option2.Text = "True";
            rbtnQ2Option3.Text = "Never"; 
            rbtnQ2Option4.Text = "False"; // Correct Answer

            // Third Question
            groupBox3.Text = "What is the perimeter of a square that is 5cm by 5cm?";
            rbtnQ3Option1.Text = "10cm";
            rbtnQ3Option2.Text = "35cm";
            rbtnQ3Option3.Text = "20cm"; // Correct Answer
            rbtnQ3Option4.Text = "50cm";

            // Fourth Question
            groupBox4.Text = "What is the area of a triangle that is 3cm by 4cm?";
            rbtnQ4Option1.Text = "6cm²"; // Correct Answer
            rbtnQ4Option2.Text = "18cm²";
            rbtnQ4Option3.Text = "12cm²"; 
            rbtnQ4Option4.Text = "9cm²";

            // Fifth Question
            groupBox5.Text = "What is the area of a rectangle that is 5cm by 8cm?";
            rbtnQ5Option1.Text = "30cm²";
            rbtnQ5Option2.Text = "26cm²";
            rbtnQ5Option3.Text = "40cm²"; // Correct Answer
            rbtnQ5Option4.Text = "13cm²";

            
        }

        // method used for clearing radio button selections within groupboxes
        private void ClearRadioButtons()
        {
            // looking through each control in the form
            foreach (Control control in this.Controls)
            {
                // checking if the control is in a groupbox
                if (control is GroupBox groupBox)
                {
                    // looking through each control within that groupbox
                    foreach (Control groupControl in groupBox.Controls)
                    {
                        // checking if the control that is within that groupbox is a radiobutton
                        if (groupControl is RadioButton radioButton)
                        {
                            // clearing the radio button
                            radioButton.Checked = false;
                        }
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // calling both of the methods, one for checking answers
            // and another which is for unchecking radio buttons
            CheckAnswers();
            ClearRadioButtons();
            // resetting the score back to 0 after the quiz is submitted
            score = 0;
        }

        // method for checking if the answers selected are correct
        private void CheckAnswers()
        {
            // calling each method which checks through each question seperately
            CheckQuestion1();
            CheckQuestion2();
            CheckQuestion3();
            CheckQuestion4();
            CheckQuestion5();

            // message box which will show up after the submit button is clicked
            // tells the user their score for the quiz
            MessageBox.Show($"Your score for this quiz is: {score}/5", "Quiz Finished!", MessageBoxButtons.OK);
        }

        private void CheckQuestion1()
        {
            // checks if the right answer is checked, the score is increased
            if (rbtnQ1Option2.Checked)
            {
                score++;
            }

            // checks if the right answer is checked, the score is increased
            if (rbtnQ1Option4.Checked)
            {
                score++;
            }
        }

        private void CheckQuestion2()
        {
            // checks if the right answer is checked, the score is increased
            if (rbtnQ2Option4.Checked)
            {
                score++;
            }
        }

        private void CheckQuestion3()
        {
            // checks if the right answer is checked, the score is increased
            if (rbtnQ3Option3.Checked)
            {
                score++;
            }
        }

        private void CheckQuestion4()
        {
            // checks if the right answer is checked, the score is increased
            if (rbtnQ4Option1.Checked)
            {
                score++;
            }
        }

        private void CheckQuestion5()
        {
            // checks if the right answer is checked, the score is increased
            if (rbtnQ5Option3.Checked)
            {
                score++;
            }
        }

        // method for closing the form down if the exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnQ3Option1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ3Option2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ3Option3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ3Option4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
