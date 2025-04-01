using System;
using System.Drawing;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            lblMessage.Text = btnR.Text;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnRed.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnBlue.BackColor;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            lblMessage.Text = btnL.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}