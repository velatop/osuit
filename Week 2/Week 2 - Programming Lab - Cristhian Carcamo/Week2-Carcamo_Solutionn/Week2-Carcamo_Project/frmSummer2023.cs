using System;
using System.Windows.Forms;

//Name: Cristhian Carcamo
// Class: Object Oriented With c#
// Due: 3/5/2025
// Semester: Spring 2025

namespace Week2_Carcamo_Project
{
    public partial class frmSummer2023 : Form
    {
        public frmSummer2023()
        {
            InitializeComponent();
        }
        private void btnWipeClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = txtInput.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}