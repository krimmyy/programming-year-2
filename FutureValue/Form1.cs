using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (IsValidData())
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
                int years = Convert.ToInt32(txtYears.Text);
                int months = years * 12;
                decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;


                decimal futureValue = CalculateFutureValue(monthlyInvestment,
                    monthlyInterestRate, months);

                txtFutureValue.Text = futureValue.ToString("c");
                txtMonthlyInvestment.Focus();
            }
        }

        private void btnExit_Click(object sender , EventArgs e)
        {
            this.Close();
        }

        private void txtMonthlyInvestment_TextChanged(object sender, EventArgs e)
        {

        }

        private decimal CalculateFutureValue(decimal monInvestment, decimal monInterestRate, int noOfMonths)
        {
            decimal futureValue = 0M;
            for (int i =0; i < noOfMonths; i++)
            {
                futureValue = (futureValue + monInvestment) * (1 + monInterestRate);
            }
            return futureValue;
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field!");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInteger(TextBox textControl, string name)
        {
            try
            {
                int num = Convert.ToInt32(textControl.Text);
                return true;
            }
            catch
            {
                MessageBox.Show(name + " must be a whole number.");
                textControl.Focus();
                return false;
            }
        }//IsInteger

        public bool IsDecimal(TextBox textControl, string name)
        {
            try
            {
                decimal num = Convert.ToDecimal(textControl.Text);
                return true;
            }
            catch
            {
                MessageBox.Show(name + " must be a decimal number.");
                textControl.Focus();
                return false;
            }
        }//IsDecimal

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            { 
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Clear();
                textBox.Focus();
                return false;
            }
            return true;
            
        }//IsWithinRange

        private void txtMonthlyInvestment_TextChanged_1(object sender, EventArgs e)
        {

        }

        public bool IsValidData()
        {
            return
                IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
                IsInteger(txtMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 5, 1000) &&

                IsPresent(txtInterestRate, "InterestRate") &&
                IsDecimal(txtInterestRate, "InterestRate") &&
                IsWithinRange(txtInterestRate, "InterestRate", 0, 10) &&

                IsPresent(txtYears, "Number of Years") &&
                IsInteger(txtYears, "Number of Years") &&
                IsWithinRange(txtYears, "Number of Years", 1, 20);
        }
    }
}
