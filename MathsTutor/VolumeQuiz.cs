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
    public partial class frmVolumeQuiz : Form
    {
        // initializing score variable
        private int score;
        public frmVolumeQuiz()
        {
            // loading both methods used for the area quiz
            InitializeComponent();
            InitializeQuiz();
        }

        // method used for displaying the questions and answers
        private void InitializeQuiz()
        {
            // setting score to 0
            score = 0;

            // First Question
            groupBox1.Text = "What is the formula for volume?";
            rbtnQ1Option1.Text = "Volume = \n Length x Width";
            rbtnQ1Option2.Text = "Volume = \n Length x Width x Height"; // Correct Answer
            rbtnQ1Option3.Text = "Volume = \n Length + Width + Height";
            rbtnQ1Option4.Text = "Volume = \n Length + Width + Length + Width";

            // Second Question
            groupBox2.Text = "What is the formula for finding the volume of a rectangular prism?";
            rbtnQ2Option1.Text = "V = l + w + h";
            rbtnQ2Option2.Text = "V = 2l + 2w + 2h";
            rbtnQ2Option3.Text = "V = l × w × h"; // Correct Answer
            rbtnQ2Option4.Text = "V = l + w x h"; 

            // Third Question
            groupBox3.Text = "What is the volume of a cube with sides measuring 5 centimeters each?";
            rbtnQ3Option1.Text = "100cm³";
            rbtnQ3Option2.Text = "25cm³";
            rbtnQ3Option3.Text = "50cm³"; 
            rbtnQ3Option4.Text = "125cm³"; // Correct Answer

            // Fourth Question
            groupBox4.Text = "What is the volume of a cone that is 4cm in radius and 6cm in height?";
            rbtnQ4Option1.Text = "100cm³"; // Correct Answer
            rbtnQ4Option2.Text = "45cm³";
            rbtnQ4Option3.Text = "73cm³";
            rbtnQ4Option4.Text = "20cm³";

            // Fifth Question
            groupBox5.Text = "What is the volume of a rectangular prism that is 10m by 3m with the height of 6m?";
            rbtnQ5Option1.Text = "180m³"; // Correct Answer
            rbtnQ5Option2.Text = "360m³";
            rbtnQ5Option3.Text = "1800cm³"; 
            rbtnQ5Option4.Text = "120m³";
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
        }

        private void CheckQuestion2()
        {
            // checks if the right answer is checked, the score is increased
            if (rbtnQ2Option3.Checked)
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
            if (rbtnQ5Option1.Checked)
            {
                score++;
            }
        }

        // method for closing the form down if the exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVolumeQuiz_Load(object sender, EventArgs e)
        {

        }

        private void rbtnQ4Option2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ4Option3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ4Option4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnQ4Option1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
