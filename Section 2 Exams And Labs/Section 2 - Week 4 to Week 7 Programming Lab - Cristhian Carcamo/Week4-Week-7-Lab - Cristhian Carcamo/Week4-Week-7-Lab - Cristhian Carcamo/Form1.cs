using System;
using System.Drawing;
using System.Windows.Forms;

// Name: Cristhian Carcamo
// Class: Obj-Orient Prg Using C#
// Due: 3/5/2025
// Semester: Spring 2025

namespace Week4_Week_7_Lab___Cristhian_Carcamo
{
    public partial class Form1 : Form
    {
        private const int BINARY = 2;
        private const int OCTAL = 8;
        private const int HEX = 16;
        private const int BASE_6 = 6;
        private const int BASE_9 = 9;

        public Form1()
        {
            InitializeComponent();
            UpdateButtonStatus();
        }

        // Convert a decimal number to any base
        private string ConvertToBase(int decimalNumber, int targetBase)
        {
            // If the base is valid
            if (targetBase < 2 || targetBase > 16)
            {
                return "Error, base must be between 2 and 16";
            }

            // If the decimal number is valid
            if (decimalNumber < 0)
            {
                return "Error, number must be positive";
            }
            // If the number is 0, return "0"
            if (decimalNumber == 0)
            {
                return "0";
            }

            char[] digits = "0123456789ABCDEF".ToCharArray();

            // Rresult from right to left
            string result = "";

            // Continue dividing until quotient = 0
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % targetBase;
                result = digits[remainder] + result;
                decimalNumber /= targetBase;
            }

            // Correct prefix based on the base
            if (targetBase == HEX)
                return "0x" + result;
            else
                return targetBase + "x" + result;
        }

        // Validate the input to confirm it's a positive integer
        private bool IsValidDecimal(string input, out int number)
        {
            if (int.TryParse(input, out number))
            {
                return number >= 0;
            }
            return false;
        }

        // Validate the base input to confirm it's between 2 and 16
        private bool IsValidBaseInput(string input, out int baseValue)
        {
            if (int.TryParse(input, out baseValue))
            {
                return baseValue >= 2 && baseValue <= 16;
            }
            return false;
        }

        // Event handler for the process click button
        private void btnProcess_Click(object sender, EventArgs e)
        {
            string decimalInput = txtConvertFrom.Text;
            string baseInput = txtBase.Text;

            if (IsValidDecimal(decimalInput, out int decimalValue))
            {
                if (IsValidBaseInput(baseInput, out int baseValue))
                {
                    // Conversion
                    string result = ConvertToBase(decimalValue, baseValue);
                    lblMessage.Text = result;
                    lblMessage.ForeColor = Color.Black;
                }
                else
                {
                    // Error message for invalid base
                    lblMessage.Text = "Base must be between 2 and 16";
                    lblMessage.ForeColor = Color.Red;
                }
            }
            else
            {
                // Error message for invalid decimal
                lblMessage.Text = "Please enter a valid positive integer";
                lblMessage.ForeColor = Color.Red;
            }
        }

        // Event handler for the binary button
        private void btnBinary_Click(object sender, EventArgs e)
        {
            ConvertToSpecificBase(BINARY);
        }
        // Event handler for the hex button
        private void btnHex_Click(object sender, EventArgs e)
        {
            ConvertToSpecificBase(HEX);
        }

        // Event handler for the octal button
        private void btnOctal_Click(object sender, EventArgs e)
        {
            ConvertToSpecificBase(OCTAL);
        }

        // Event handler for the base 6 button
        private void btnBase6_Click(object sender, EventArgs e)
        {
            ConvertToSpecificBase(BASE_6);
        }

        // Event handler for the base 9 button
        private void btnBase9_Click(object sender, EventArgs e)
        {
            ConvertToSpecificBase(BASE_9);
        }
        private void ConvertToSpecificBase(int targetBase)
        {
            string decimalInput = txtConvertFrom.Text;

            if (IsValidDecimal(decimalInput, out int decimalValue))
            {
                string result = ConvertToBase(decimalValue, targetBase);
                lblMessage.Text = result;
                lblMessage.ForeColor = Color.Black;
            }
            else
            {
                lblMessage.Text = "Enter a valid positive integer";
                lblMessage.ForeColor = Color.Red;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConvertFrom.Text = "";
            txtBase.Text = "";
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Black;
            txtConvertFrom.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the text changed event of the convert from text box
        private void txtConvertFrom_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }

        // Update the enabled status of the conversion buttons
        private void UpdateButtonStatus()
        {
            bool hasConvertFromContent = !string.IsNullOrEmpty(txtConvertFrom.Text);
            btnBinary.Enabled = hasConvertFromContent;
            btnHex.Enabled = hasConvertFromContent;
            btnOctal.Enabled = hasConvertFromContent;
            btnBase6.Enabled = hasConvertFromContent;
            btnBase9.Enabled = hasConvertFromContent;

            btnProcess.Enabled = hasConvertFromContent && !string.IsNullOrEmpty(txtBase.Text);
        }
    }
}