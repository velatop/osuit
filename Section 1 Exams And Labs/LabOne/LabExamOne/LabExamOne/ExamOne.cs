using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;



/*
* Name: Cristhian Carcamo
* Class: Object Oriented
* Due Date: 2/7/2025
*/

namespace LabExamOne
{
    public partial class ExamOne : Form
    {
        private Button[] ButtonLetters;
        private Button[] ButtonNumbers;
        private Button ButtonPeriods;

        public ExamOne()
        {
            InitializeComponent();
            this.CancelButton = btnExit;
            CreateKeyboard();
            ArrangeControls();
        }

        private void CreateKeyboard()
        {
            int MaxLetterButtons = 26;
            ButtonLetters = new Button[MaxLetterButtons];
            for (int i = 0; i < MaxLetterButtons; i++)
            {
                char letter = Convert.ToChar('A' + i);
                ButtonLetters[i] = new Button
                {
                    Text = letter.ToString(),
                    Size = new Size(40, 40),
                    Font = new Font("Times New Roman", 12),
                    BackColor = Color.White,
                    TabStop = false
                };
                ButtonLetters[i].Click += LetterButton_Click;
                this.Controls.Add(ButtonLetters[i]);
            }

            int MaxNumberButtons = 10;
            ButtonNumbers = new Button[MaxNumberButtons];
            for (int i = 0; i < MaxNumberButtons; i++)
            {
                ButtonNumbers[i] = new Button
                {
                    Text = i.ToString(),
                    Size = new Size(40, 40),
                    Font = new Font("Times New Roman", 12),
                    BackColor = Color.LightBlue,
                    TabStop = false
                };
                ButtonNumbers[i].Click += NumberButton_Click;
                this.Controls.Add(ButtonNumbers[i]);
            }
            ButtonPeriods = new Button
            {
                Text = ".",
                Size = new Size(40, 40),
                Font = new Font("Times New Roman", 12),
                BackColor = Color.White,
                TabStop = false
            };
            ButtonPeriods.Click += PeriodButton_Click;
            this.Controls.Add(ButtonPeriods);
        }

        private void ArrangeControls()
        {
            // Set up our starting point and spacing
            int LeftEdge = 12;
            int TopEdge = 60;
            int SpaceBetweenButtons = 45;

            // Letter buttons in a 4x7 grid
            int LetterRows = 4;
            int LettersPerRow = 7;

            for (int LetterIndex = 0; LetterIndex < ButtonLetters.Length; LetterIndex++)
            {
                // Figure out which row + column this letter
                int Row = LetterIndex / LettersPerRow;
                int Column = LetterIndex % LettersPerRow;

                // Calculate the position for this letter
                int xPosition = LeftEdge + (Column * SpaceBetweenButtons);
                int yPosition = TopEdge + (Row * SpaceBetweenButtons);

                // Place the buton at the calculated positiion
                ButtonLetters[LetterIndex].Location = new Point(xPosition, yPosition);
            }

            // Arrange number buttons in a single
            int NumberRowY = 240;

            for (int NumberIndex = 0; NumberIndex < ButtonNumbers.Length; NumberIndex++)
            {
                // Calculate the position for this number button
                int xPosition = LeftEdge + (NumberIndex * SpaceBetweenButtons);

                // Place the button at the calculated position
                ButtonNumbers[NumberIndex].Location = new Point(xPosition, NumberRowY);
            }

            // Place the period button at the end of the numberrow
            int PeriodButtonX = LeftEdge + (10 * SpaceBetweenButtons);
            ButtonPeriods.Location = new Point(PeriodButtonX, NumberRowY);
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtMessage.Text += btn.Text;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtMessage.Text += btn.Text;
        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {
            txtMessage.Text += ".";
        }

        private void btnBlank_Click(object sender, EventArgs e)
        {
            txtMessage.Text += " ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblLastMessage.Text = txtMessage.Text;
            txtMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}