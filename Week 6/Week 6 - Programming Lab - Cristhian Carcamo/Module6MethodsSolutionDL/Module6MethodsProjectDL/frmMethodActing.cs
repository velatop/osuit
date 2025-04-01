using System;
using System.Drawing;
using System.Windows.Forms;

/*Name: Cristhian Carcamo
 * Class: Object Oriented
 * Date: 2/16/2025
 */

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmMethodActing()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue;
        }

        private decimal CalculateResult(decimal leftOperand, decimal rightOperand, byte operation)
        {
            decimal result = 0;

            switch (operation)
            {
                case ADD:
                    result = leftOperand + rightOperand;
                    break;
                case SUBTRACT:
                    result = leftOperand - rightOperand;
                    break;
                case MULTIPLY:
                    result = leftOperand * rightOperand;
                    break;
                case DIVIDE:
                    result = leftOperand / rightOperand;
                    break;
                case MODULUS:
                    result = leftOperand % rightOperand;
                    break;
            }

            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;
            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalculateResult(dLeft, dRight, ADD);

            szAnswer = dAnswer.ToString();
            szEquation = szLeft + " + " + szRight + " = " + szAnswer;
            lblResult.Text = "";
            lblResult.Text = szEquation;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;
            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalculateResult(dLeft, dRight, SUBTRACT);

            szAnswer = dAnswer.ToString();
            szEquation = szLeft + " - " + szRight + " = " + szAnswer;
            lblResult.Text = "";
            lblResult.Text = szEquation;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;
            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalculateResult(dLeft, dRight, MULTIPLY);

            szAnswer = dAnswer.ToString();
            szEquation = szLeft + " * " + szRight + " = " + szAnswer;
            lblResult.Text = "";
            lblResult.Text = szEquation;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;
            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalculateResult(dLeft, dRight, DIVIDE);

            szAnswer = dAnswer.ToString();
            szEquation = szLeft + " / " + szRight + " = " + szAnswer;
            lblResult.Text = "";
            lblResult.Text = szEquation;
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOperand.Text;
            szRight = txtRightOperand.Text;
            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalculateResult(dLeft, dRight, MODULUS);

            szAnswer = dAnswer.ToString();
            szEquation = szLeft + " % " + szRight + " = " + szAnswer;
            lblResult.Text = "";
            lblResult.Text = szEquation;
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
    }
}