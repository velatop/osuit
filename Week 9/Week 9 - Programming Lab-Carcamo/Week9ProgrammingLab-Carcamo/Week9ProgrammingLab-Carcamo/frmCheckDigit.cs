using System;
using System.Windows.Forms;

namespace Week9ProgrammingLab_Carcamo
{
    public partial class frmCheckDigit : Form
    {
        public frmCheckDigit()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            ProcessForm();
        }

        // Resets all form fields
        private void ResetForm()
        {
            txtAccount.Text = "";
            txtConfirmAccount.Text = "";
            txtPayment.Text = "";
            lblMessage.Text = "";
            txtAccount.Focus();
        }

        // Check form data, validates input and displays appropriate message
        private void ProcessForm()
        {
            if (string.IsNullOrEmpty(txtAccount.Text) ||
                string.IsNullOrEmpty(txtConfirmAccount.Text) ||
                string.IsNullOrEmpty(txtPayment.Text))
            {
                lblMessage.Text = "Error, all fields are required.";
                return;
            }
            if (txtAccount.Text != txtConfirmAccount.Text)
            {
                lblMessage.Text = "Error, account numbers not match.";
                return;
            }

            // Check if account number is numeric
            if (!IsNumeric(txtAccount.Text))
            {
                lblMessage.Text = "Error, account number must contain only numeric characters.";
                return;
            }
            if (txtAccount.Text.Length != 8)
            {
                lblMessage.Text = "Error, account number must be iqual to 8 digits.";
                return;
            }

            // Check digit algorithm
            if (!IsValidAccountNumber(txtAccount.Text))
            {
                lblMessage.Text = "Error, check digit verification failed.";
                return;
            }

            // Same, check if payment is valid
            decimal payment;
            if (!TryParsePayment(txtPayment.Text, out payment))
            {
                lblMessage.Text = "Error, invalid payment amount.";
                return;
            }
            //
            string currentDate = DateTime.Now.ToString("MMMM d");
            lblMessage.Text = $"Payment of {payment:C2} was added to account {txtAccount.Text} on {currentDate}.";
        }

        // Check if contains only numeric characters
        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // Check digit algorithm
        private bool IsValidAccountNumber(string accountNumber)
        {
            string mainPart = accountNumber.Substring(0, 7);
            char checkDigit = accountNumber[7];
            int sum = 0;

            foreach (char c in mainPart)
            {
                sum += c - '0';
            }
            int expectedCheckDigit = sum % 10;
            //
            int actualCheckDigit = checkDigit - '0';

            return expectedCheckDigit == actualCheckDigit;
        }

        private bool TryParsePayment(string text, out decimal payment)
        {
            string cleanText = text.Replace("$", "").Replace(",", "");
            return decimal.TryParse(cleanText, out payment);
        }
    }
}