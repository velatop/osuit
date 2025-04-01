using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8ProgrammingLab
{
    public partial class frmCollections : Form
    {
        private const int TOTAL_ELEMENTS = 17;
        private const int MIN = -1217;
        private const int MAX = 1217;
        private int[] numbersInCollection;
        private int elementCount;

        public frmCollections()
        {
            InitializeComponent();
            InitializeCollection();
        }

        private void InitializeCollection()
        {
            numbersInCollection = new int[TOTAL_ELEMENTS];
            elementCount = 0;
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            // Confirm to add the number to the collection
            if (ValidateInput(txtNumber.Text))
            {
                ClearDisplayAreas();
                int number = int.Parse(txtNumber.Text);

                if (elementCount >= TOTAL_ELEMENTS)
                {
                    rtbStats.Text = "Collection contains error, cannot add more than 17 numbers.";
                    txtNumber.Text = "";
                    return;
                }
                // Range match
                if (number < MIN || number > MAX)
                {
                    rtbStats.Text = "Value out of range error, numbers has to be between -1,217 and 1,217.";
                    txtNumber.Text = "";
                    return;
                }

                // Add number to collection
                numbersInCollection[elementCount] = number;
                elementCount++;

                txtNumber.Text = "";
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            // Check collection's count
            if (elementCount == 0)
            {
                rtbStats.Text = "The collection is empty, add numbers first.";
                return;
            }
            DisplayCollection();

            DisplayStatistics();

            InitializeCollection();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeCollection();

            ClearDisplayAreas();

            rtbStats.Text = "The collection was cleared.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                rtbStats.Text = "Error, enter a number.";
                return false;
            }

            if (!int.TryParse(input, out int number))
            {
                rtbStats.Text = "Error, please enter a valid integer.";
                txtNumber.Text = "";
                return false;
            }

            return true;
        }

        private void DisplayCollection()
        {
            rtbCollection.Text = "";
            for (int i = 0; i < elementCount; i++)
            {
                rtbCollection.Text += numbersInCollection[i] + Environment.NewLine;
            }
        }

        private void DisplayStatistics()
        {
            int sumTotal = 0;
            int highestNumber = numbersInCollection[0];
            int lowestNumber = numbersInCollection[0];

            for (int i = 0; i < elementCount; i++)
            {
                int currentNumber = numbersInCollection[i];
                sumTotal += currentNumber;

                // Highest check
                if (currentNumber > highestNumber)
                {
                    highestNumber = currentNumber;
                }

                // Lowest check
                if (currentNumber < lowestNumber)
                {
                    lowestNumber = currentNumber;
                }
            }
            double average = (double)sumTotal / elementCount;

            rtbStats.Text = "Highest Number: " + highestNumber + Environment.NewLine;
            rtbStats.Text += "Lowest Number: " + lowestNumber + Environment.NewLine;
            rtbStats.Text += "Number Count: " + elementCount + Environment.NewLine;
            rtbStats.Text += "Average: " + average.ToString();
        }

        private void ClearDisplayAreas()
        {
            rtbCollection.Text = "";
            rtbStats.Text = "";
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                btnAddNumber_Click(sender, e);
            }
        }

        private void frmCollections_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnExit_Click(sender, e);
            }
        }
    }
}