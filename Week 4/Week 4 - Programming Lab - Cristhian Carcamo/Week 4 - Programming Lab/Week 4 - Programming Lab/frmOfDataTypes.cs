using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week_4___Programming_Lab
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
            this.Text = "Week 4 - Data Types";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue;
        }
        private void buttonByte_Click(object sender, EventArgs e)
        {
            byte LeftOperand = 120;
            byte RightOperand = 50;
            byte Result = (byte)(LeftOperand + RightOperand);

            labelDisplay.Text = String.Format("{0} + {1} = {2}", LeftOperand, RightOperand, Result);
        }
        private void buttonShort_Click(object sender, EventArgs e)
        {
            short LeftOperand = 1000;
            short RightOperand = 500;
            short Result = (short)(LeftOperand - RightOperand);

            labelDisplay.Text = String.Format("{0} - {1} = {2}", LeftOperand, RightOperand, Result);
        }
        private void buttonInt_Click(object sender, EventArgs e)
        {
            int LeftOperand = 15;
            int RightOperand = 4;
            int Result = LeftOperand / RightOperand;

            labelDisplay.Text = String.Format("{0} / {1} = {2}", LeftOperand, RightOperand, Result);
        }
        private void buttonLong_Click(object sender, EventArgs e)
        {
            long LeftOperand = 17;
            long RightOperand = 5;
            long Result = LeftOperand % RightOperand;

            labelDisplay.Text = String.Format("{0} % {1} = {2}", LeftOperand, RightOperand, Result);
        }
        private void buttonFloat_Click(object sender, EventArgs e)
        {
            float LeftOperand = 17.5f;
            float RightOperand = 5.2f;
            float Result = LeftOperand % RightOperand;

            labelDisplay.Text = String.Format("{0:F7} % {1:F7} = {2:F7}", LeftOperand, RightOperand, Result);
        }
        private void btnDouble_Click(object sender, EventArgs e)
        {
            double LeftOperand = 15.75;
            double RightOperand = 4.25;
            double Result = LeftOperand / RightOperand;

            labelDisplay.Text = String.Format("{0:F14} / {1:F14} = {2:F14}", LeftOperand, RightOperand, Result);
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            decimal LeftOperand = 123.456789m;
            decimal RightOperand = 2.5m;
            decimal Result = LeftOperand * RightOperand;

            labelDisplay.Text = String.Format("{0:F28} * {1:F28} = {2:F28}", LeftOperand, RightOperand, Result);
        }
        private void buttonPower_Click(object sender, EventArgs e)
        {
            double BaseNumber = 2.0;
            double Exponent = 3.0;
            double Result = Math.Pow(BaseNumber, Exponent);

            labelDisplay.Text = String.Format("{0} raised to the power of {1} is {2}", BaseNumber, Exponent, Result);
        }
        private void buttonRound_Click(object sender, EventArgs e)
        {
            double Number = 3.14159;
            int Decimals = 2;
            double Result = Math.Round(Number, Decimals);

            labelDisplay.Text = String.Format("Rounding {0} to {1} decimal places is {2}", Number, Decimals, Result);
        }
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double Number = 16.0;
            double Result = Math.Sqrt(Number);

            labelDisplay.Text = String.Format("The square root of {0} is {1}", Number, Result);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "";
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}