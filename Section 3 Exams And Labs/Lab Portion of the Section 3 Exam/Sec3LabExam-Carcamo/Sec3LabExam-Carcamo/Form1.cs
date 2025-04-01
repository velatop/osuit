using System;
using System.Text;
using System.Windows.Forms;

// Name: Cristhian Carcamo
// Class: Object Oriented with C#
// Date Due: 3/27/2025
// Semester: Spring 2025

namespace Sec3LabExam_Carcamo
{
    public partial class Form1 : Form
    {
        private int plainToCipherCount = 0;
        private int cipherToPlainCount = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Enter text to convert.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            // Conversion based on the selected radio button
            if (rdoPlainToCipher.Checked)
            {
                txtOutput.Text = ConvertText(txtInput.Text, true);
                plainToCipherCount++;
            }
            else
            {
                txtOutput.Text = ConvertText(txtInput.Text, false);
                cipherToPlainCount++;
            }
        }

        private string ConvertText(string text, bool plainToCipher)
        {
            string plainText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cipherText = "RSNEPHATIMGLXWVFUJZKOBYDQ";

            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                // If the character is a letter, convert it
                if (char.IsLetter(c))
                {
                    char upperC = char.ToUpper(c);
                    int index;

                    if (plainToCipher)
                    {
                        // Convert from Plain Text to Cipher Text
                        index = plainText.IndexOf(upperC);
                        if (index >= 0)
                        {
                            result.Append(cipherText[index]);
                        }
                    }
                    else
                    {
                        // Convert from Cipher Text to Plain Text
                        index = cipherText.IndexOf(upperC);
                        if (index >= 0)
                        {
                            result.Append(plainText[index]);
                        }
                    }
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtInput.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Modify message with counts before closing
            string message = $"Messages converted:\n" + $"Plain Text to Cipher Text: {plainToCipherCount}\n" +
                            $"Cipher Text to Plain Text: {cipherToPlainCount}";

            MessageBox.Show(message, "Conversion Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoPlainToCipher.Checked = true;
        }
    }
}