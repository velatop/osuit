using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Cristhian Carcamo
// Class: Obj-Orient Prg Using C#
// Due: 3/5/2025
// Semester: Spring 2025

namespace Section2Exam_Carcamo
{
    public partial class frmLab : Form
    {
        public frmLab()
        {
            InitializeComponent();
            SetupOperationsUI();
        }
        private void SetupOperationsUI()
        {
            // Disable all DO buttons at startup
            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = false;

            // Hide all operand textboxes
            txtOperand1.Visible = false;
            txtOperand2.Visible = false;
            lblOperand1.Visible = false;
            lblOperand2.Visible = false;
        }

        // Show modulus button
        private void btnShowModulus_Click(object sender, EventArgs e)
        {
            // Show controls for modulus operation
            lblOperand1.Text = "Dividend:";
            lblOperand2.Text = "Divisor:";
            lblOperand1.Visible = true;
            lblOperand2.Visible = true;
            txtOperand1.Visible = true;
            txtOperand2.Visible = true;

            // Enable only the modulus button and disable others
            btnDoModulus.Enabled = true;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = false;

            // Clear the textboxes
            txtOperand1.Text = "";
            txtOperand2.Text = "";
            txtOperand1.Focus();
        }

        // Show factorial button
        private void btnShowFactorial_Click(object sender, EventArgs e)
        {
            // Show controls for factorial operation
            lblOperand1.Text = "Number (0-15):";
            lblOperand1.Visible = true;
            txtOperand1.Visible = true;

            // Hide second operand as it's not needed
            lblOperand2.Visible = false;
            txtOperand2.Visible = false;

            // Enable only the factorial button and disable others
            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = true;
            btnDoFibonacci.Enabled = false;

            // Clear the textbox
            txtOperand1.Text = "";
            txtOperand1.Focus();
        }

        // Show bibonacci button
        private void btnShowFibonacci_Click(object sender, EventArgs e)
        {
            // Show controls for fibonacci operation
            lblOperand1.Text = "Term (0-45):";
            lblOperand1.Visible = true;
            txtOperand1.Visible = true;

            // Hide second operand as it's not needed
            lblOperand2.Visible = false;
            txtOperand2.Visible = false;

            // Enable only the Fibonacci button and disable others
            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = true;

            // Clear the textbox
            txtOperand1.Text = "";
            txtOperand1.Focus();
        }

        // Do modulus button
        private void btnDoModulus_Click(object sender, EventArgs e)
        {
            // Validate that fields are not empty
            if (txtOperand1.Text == "" || txtOperand2.Text == "")
            {
                lblMessage.Text = "Error, both fields are required for the modulus operation.";
                return;
            }

            int dividend, divisor;

            try
            {
                // Validate that values are integers
                if (!int.TryParse(txtOperand1.Text, out dividend))
                {
                    lblMessage.Text = "Error, the dividend must be an integer.";
                    return;
                }

                if (!int.TryParse(txtOperand2.Text, out divisor))
                {
                    lblMessage.Text = "Error, the divisor must be an integer.";
                    return;
                }

                // Validate that divisor is not zero
                if (divisor == 0)
                {
                    lblMessage.Text = "Error, this cannot divide by zero.";
                    return;
                }

                // Calculate division and modulus without using / and % operators
                int quotient = 0;
                int remainder = dividend;

                // If dividend is negative, adjust to maintain sign correctly
                if (dividend < 0 && divisor > 0)
                {
                    while (remainder + divisor <= 0)
                    {
                        remainder += divisor;
                        quotient--;
                    }
                }
                else if (dividend > 0 && divisor < 0)
                {
                    while (remainder + divisor >= 0)
                    {
                        remainder += divisor;
                        quotient--;
                    }
                }
                else if (dividend < 0 && divisor < 0)
                {
                    while (remainder - divisor >= 0)
                    {
                        remainder -= divisor;
                        quotient++;
                    }
                }
                else // Both positive
                {
                    while (remainder >= divisor)
                    {
                        remainder -= divisor;
                        quotient++;
                    }
                }

                // Display the result in the message area
                lblMessage.Text = $"{dividend} divided by {divisor} is {quotient} with a remainder of {remainder}";
            }
            catch (Exception ex)
            {
                // Handle any other exception
                lblMessage.Text = "Unexpected error: " + ex.Message;
            }
        }

        // Do factorial button
        private void btnDoFactorial_Click(object sender, EventArgs e)
        {
            // Validate that the field is not empty
            if (txtOperand1.Text == "")
            {
                lblMessage.Text = "Error. this field is required to calculate factorial.";
                return;
            }

            try
            {
                int number;

                // Validate that the value is an integer
                if (!int.TryParse(txtOperand1.Text, out number))
                {
                    lblMessage.Text = "Error, the value must be an integer.";
                    return;
                }

                // Validate the range of the number (0-15)
                if (!ValidateRange(number, 0, 15))
                {
                    lblMessage.Text = "Error, the number for factorial must be between 0 and 15.";
                    return;
                }

                // Calculate the factorial
                long result = CalculateFactorial(number);

                // Display the result in the message area
                lblMessage.Text = $"The answer to {number}! is {result}";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        // Do fibonacci button
        private void btnDoFibonacci_Click(object sender, EventArgs e)
        {
            // Validate that the field is not empty
            if (txtOperand1.Text == "")
            {
                lblMessage.Text = "Error.. this field is required to calculate the Fibonacci term.";
                return;
            }

            try
            {
                int term;

                // Validate that the value is an integer
                if (!int.TryParse(txtOperand1.Text, out term))
                {
                    lblMessage.Text = "Error, the value must be an integer.";
                    return;
                }

                // Validate the range of the number (0-45)
                if (!ValidateRange(term, 0, 45))
                {
                    lblMessage.Text = "Error, the number for Fibonacci must be between 0 and 45.";
                    return;
                }

                // Calculate the bibonacci term
                long result = CalculateFibonacci(term);

                // For terms 0 and 1, display messages
                if (term == 0)
                {
                    lblMessage.Text = "Fibonacci(0) = 0";
                }
                else if (term == 1)
                {
                    lblMessage.Text = "Fibonacci(1) = 1";
                }
                else
                {
                    // For terms greater than 1, display the complete formula
                    long term1 = CalculateFibonacci(term - 1);
                    long term2 = CalculateFibonacci(term - 2);
                    lblMessage.Text = $"Fibonacci({term}) = Fibonacci({term - 1}) + Fibonacci({term - 2}) = {term1} + {term2} = {result}";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        // Method to validate the range of a number
        private bool ValidateRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        // Method to calculate factorial
        private long CalculateFactorial(int n)
        {
            // Base cases: 0! and 1! are 1
            if (n == 0 || n == 1)
                return 1;

            // Calculate factorial with loop
            long factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        // Method to calculate fibonacci term
        private long CalculateFibonacci(int n)
        {
            // Base cases
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            // Calculate fibonacci with loop
            long fib1 = 0;
            long fib2 = 1;
            long fibCurrent = 0;

            for (int i = 2; i <= n; i++)
            {
                fibCurrent = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibCurrent;
            }

            return fibCurrent;
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear only the message
            lblMessage.Text = "";
        }

        // Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting operations application",
                "Bye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}