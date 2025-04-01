// Name: Cristhian Carcamo
// Class: Object Oriented with C#
// Due: 3/5/2025
// Semester: Spring 2025

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week7Lab_Carcamo
{
    public partial class frmRealID : Form
    {
        public frmRealID()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            try
            {
                if (txtLeftOperand.Text == "" || txtRightOperand.Text == "")
                {
                    lblResult.Text = "Must contain a value";
                    lblResult.ForeColor = Color.Red;
                    return;
                }
                if (!decimal.TryParse(txtLeftOperand.Text, out decimal leftOperand) ||
                    !decimal.TryParse(txtRightOperand.Text, out decimal rightOperand))
                {
                    lblResult.Text = "Must contain valid numeric values";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                // calculation
                decimal result = Calculate(leftOperand, rightOperand, "+");

                lblResult.Text = result.ToString();
                lblResult.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblResult.Text = "error: " + ex.Message;
                lblResult.ForeColor = Color.Red;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            // Do subtraction if valid
            try
            {
                if (txtLeftOperand.Text == "" || txtRightOperand.Text == "")
                {
                    lblResult.Text = "Must contain a value";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                if (!decimal.TryParse(txtLeftOperand.Text, out decimal leftOperand) ||
                    !decimal.TryParse(txtRightOperand.Text, out decimal rightOperand))
                {
                    lblResult.Text = "Both Must contain valid numeric values";
                    lblResult.ForeColor = Color.Red;
                    return;
                }
                decimal result = Calculate(leftOperand, rightOperand, "-");

                lblResult.Text = result.ToString();
                lblResult.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
                lblResult.ForeColor = Color.Red;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            try
            {
                if (txtLeftOperand.Text == "" || txtRightOperand.Text == "")
                {
                    lblResult.Text = "Must contain a value";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                if (!decimal.TryParse(txtLeftOperand.Text, out decimal leftOperand) ||
                    !decimal.TryParse(txtRightOperand.Text, out decimal rightOperand))
                {
                    lblResult.Text = "Only can contain valid numeric values";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                // Calculation
                decimal result = Calculate(leftOperand, rightOperand, "*");

                lblResult.Text = result.ToString();
                lblResult.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
                lblResult.ForeColor = Color.Red;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            try
            {
                if (txtLeftOperand.Text == "" || txtRightOperand.Text == "")
                {
                    lblResult.Text = "Must contain a value";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                // Convert text to decimal values
                if (!decimal.TryParse(txtLeftOperand.Text, out decimal leftOperand) ||
                    !decimal.TryParse(txtRightOperand.Text, out decimal rightOperand))
                {
                    lblResult.Text = "Must contain valid numeric values";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                // Test division by zero
                if (rightOperand == 0)
                {
                    lblResult.Text = "Cannot divide by zero";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                decimal result = Calculate(leftOperand, rightOperand, "/");

                lblResult.Text = result.ToString();
                lblResult.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
                lblResult.ForeColor = Color.Red;
            }
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            try
            {
                string errorMessage = "";

                // Test fields are empty
                if (txtLeftOperand.Text == "" || txtRightOperand.Text == "")
                {
                    lblResult.Text = "Both must contain a value";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                if (!decimal.TryParse(txtLeftOperand.Text, out decimal leftOperand) ||
                    !decimal.TryParse(txtRightOperand.Text, out decimal rightOperand))
                {
                    lblResult.Text = "Must contain valid numeric values";
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                if (rightOperand == 0)
                {
                    errorMessage += "Cannot perform modulus using zero as right operand\n";
                }

                if (leftOperand < 0)
                {
                    errorMessage += "Left operand cannot be negative for modulus operation\n";
                }

                if (rightOperand < 0)
                {
                    errorMessage += "Right operand cannot be negative for modulus operation\n";
                }

                // If validation errors, display and return
                if (errorMessage != "")
                {
                    lblResult.Text = errorMessage;
                    lblResult.ForeColor = Color.Red;
                    return;
                }

                decimal result = Calculate(leftOperand, rightOperand, "%");

                lblResult.Text = result.ToString();
                lblResult.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
                lblResult.ForeColor = Color.Red;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblResult.Text = "";
            txtLeftOperand.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Calculations based on the operator provided
        private decimal Calculate(decimal leftOperand, decimal rightOperand, string operation)
        {
            decimal result = 0;

            switch (operation)
            {
                case "+":
                    result = leftOperand + rightOperand;
                    break;
                case "-":
                    result = leftOperand - rightOperand;
                    break;
                case "*":
                    result = leftOperand * rightOperand;
                    break;
                case "/":
                    result = leftOperand / rightOperand;
                    break;
                case "%":
                    result = leftOperand % rightOperand;
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }
            return result;
        }
    }
}