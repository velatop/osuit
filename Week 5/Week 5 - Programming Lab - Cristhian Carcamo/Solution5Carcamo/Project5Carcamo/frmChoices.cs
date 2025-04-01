using System;
using System.Windows.Forms;

/*
 Name: Cristhian Carcamo
 Class: Object Oriented
 Due Date: 2/16/2025
 */

namespace Project5Carcamo
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double leftNumber = double.Parse(txtRangeLeft.Text);
                double rightNumber = double.Parse(txtRangeRight.Text);
                double checkNumber = double.Parse(txtCheckNumber.Text);

                if (checkNumber == leftNumber)
                {
                    lblUserMessage.Text = "The number is equal to lower end of the range.";
                }
                else if (checkNumber == rightNumber)
                {
                    lblUserMessage.Text = "The number is equal to upper end of the range.";
                }
                else if (checkNumber < leftNumber)
                {
                    lblUserMessage.Text = "The number is lower than low end of the range.";
                }
                else if (checkNumber > rightNumber)
                {
                    lblUserMessage.Text = "The number is bigger than high end of the range.";
                }
                else
                {
                    lblUserMessage.Text = $"The number is in the middle of {leftNumber} and {rightNumber}.";
                }

                txtCheckNumber.Clear();
                txtCheckNumber.Focus();
            }
        }

        private bool ValidateInputs()
        {
            if (!double.TryParse(txtRangeLeft.Text, out double leftNumber) ||
                !double.TryParse(txtRangeRight.Text, out double rightNumber) ||
                !double.TryParse(txtCheckNumber.Text, out double checkNumber))
            {
                lblUserMessage.Text = "Please enter valid numbers.";
                return false;
            }

            if (leftNumber >= rightNumber)
            {
                lblUserMessage.Text = "The right number must be larger than left number.";
                return false;
            }

            return true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtRangeLeft.Clear();
            txtRangeRight.Clear();
            txtCheckNumber.Clear();
            lblUserMessage.Text = "";
            txtRangeLeft.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}