using System;
using System.Windows.Forms;

namespace Week10ProgrammingLab
{
    // Name: Cristhian Carcamo
    // Class: Object Oriented Programming
    // Semester: Spring 2025
    // Due Date: 3/23/2025
    public partial class frmRadioStar : Form
    {
        public frmRadioStar()
        {
            InitializeComponent();
        }

        private void frmRadioStar_Load(object sender, EventArgs e)
        {
            // Addition is selected by default
            rdoAddition.Checked = true;

            chkVerbose.Checked = true;
            txtLeftOperand.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Check data before calculating
            if (ValidateData())
            {
                int leftOperand = int.Parse(txtLeftOperand.Text);
                int rightOperand = int.Parse(txtRightOperand.Text);
                int result = 0;
                string operation = "";

                if (rdoAddition.Checked)
                {
                    result = Add(leftOperand, rightOperand);
                    operation = "+";
                }
                else if (rdoSubtraction.Checked)
                {
                    result = Subtract(leftOperand, rightOperand);
                    operation = "-";
                }
                else if (rdoMultiplication.Checked)
                {
                    result = Multiply(leftOperand, rightOperand);
                    operation = "*";
                }
                else if (rdoDivision.Checked)
                {
                    result = Divide(leftOperand, rightOperand);
                    operation = "/";
                }
                else if (rdoModulus.Checked)
                {
                    result = Modulus(leftOperand, rightOperand);
                    operation = "%";
                }

                // Display the result
                if (chkVerbose.Checked)
                {
                    lblMessage.Text = $"{leftOperand} {operation} {rightOperand} = {result}";
                }
                else
                {
                    lblMessage.Text = $"The Answer is: {result}";
                }
            }
        }

        private bool ValidateData()
        {
            string errorMessage = "";
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtLeftOperand.Text))
            {
                errorMessage += "The left operand text box is empty.\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtRightOperand.Text))
            {
                errorMessage += "The right operand text box is empty.\n";
                isValid = false;
            }

            // Display the message and return
            if (!isValid)
            {
                lblMessage.Text = errorMessage;
                return false;
            }

            // Check if values are integers
            int leftOperand, rightOperand;
            bool isLeftValid = int.TryParse(txtLeftOperand.Text, out leftOperand);
            bool isRightValid = int.TryParse(txtRightOperand.Text, out rightOperand);

            if (!isLeftValid)
            {
                errorMessage += "The left operand must be an integer.\n";
                isValid = false;
            }

            if (!isRightValid)
            {
                errorMessage += "The right operand must be an integer.\n";
                isValid = false;
            }

            //Display the message and return
            if (!isValid)
            {
                lblMessage.Text = errorMessage;
                return false;
            }

            // Division or modulus by zero
            if ((rdoDivision.Checked || rdoModulus.Checked) && rightOperand == 0)
            {
                lblMessage.Text = "Cannot divide by zero. Enter a nonzero value for the right operand.";
                return false;
            }

            // Operations with negative numbers
            if (rdoModulus.Checked && (leftOperand < 0 || rightOperand < 0))
            {
                lblMessage.Text = "Modulus operations are not allowed with negative numbers.";
                return false;
            }

            return true;
        }

        private int Add(int left, int right)
        {
            return left + right;
        }

        private int Subtract(int left, int right)
        {
            return left - right;
        }

        private int Multiply(int left, int right)
        {
            return left * right;
        }

        private int Divide(int left, int right)
        {
            return left / right;
        }

        private int Modulus(int left, int right)
        {
            return left % right;
        }

        // Clear messages
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblMessage.Text = "";
            rdoAddition.Checked = true;
            chkVerbose.Checked = true;
            txtLeftOperand.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}