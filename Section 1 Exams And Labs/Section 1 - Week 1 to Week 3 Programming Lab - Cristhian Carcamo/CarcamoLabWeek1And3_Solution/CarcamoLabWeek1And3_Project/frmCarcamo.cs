using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarcamoLabWeek1And3_Project
{
    public partial class frmCarcamo : Form
    {
        public frmCarcamo()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = " ";
            lblTheDominator.BackColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnRed.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnBlue.BackColor;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnGreen.BackColor;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnYellow.BackColor;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnPurple.BackColor;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnOrange.BackColor;
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnBrown.BackColor;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnPink.BackColor;
        }

        private void btnTeal_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnTeal.BackColor;
        }
        private void btnDigit1_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "1";
        }

        private void btnDigit2_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "2";
        }

        private void btnDigit3_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "3";
        }

        private void btnDigit4_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "4";
        }

        private void btnDigit5_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "5";
        }

        private void btnDigit6_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "6";
        }

        private void btnDigit7_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "7";
        }

        private void btnDigit8_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "8";
        }

        private void btnDigit9_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "9";
        }
    }
}