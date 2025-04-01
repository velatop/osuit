using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Section3Week8toWeek10Programming_Lab
{
    public partial class TextStatsProcessor : Form
    {
        public TextStatsProcessor()
        {
            InitializeComponent();
        }
        private void TextStatsProcessor_Load(object sender, EventArgs e)
        {
            // Default radio button selection
            rdoWordList.Checked = true;

            chkIncludeFrequency.Enabled = false;
            btnProcess.Enabled = false;
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Validate text to process
            if (string.IsNullOrWhiteSpace(txtInputText.Text))
            {
                MessageBox.Show("Enter some text to process.", "No Text",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInputText.Focus();
                return;
            }

            // Process and display statistics
            ProcessText();
        }

        // Clear button click event handler
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset controls to default
            txtInputText.Clear();
            txtWordList.Clear();
            lblSentenceCount.Text = "0";
            lblWordCount.Text = "0";
            lblUniqueWordCount.Text = "0";
            lblTwoWordPairCount.Text = "0";
            lblCharCount.Text = "0";
            lblAvgWordLength.Text = "0";
            lblAvgUniqueWordLength.Text = "0";
            rdoWordList.Checked = true;

            // Disable frequency & uncheck it
            chkIncludeFrequency.Enabled = false;
            chkIncludeFrequency.Checked = false;

            btnProcess.Enabled = false;
            txtInputText.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtInputText_TextChanged(object sender, EventArgs e)
        {
            btnProcess.Enabled = !string.IsNullOrWhiteSpace(txtInputText.Text);
        }

        //Unique Word List radio button is checked or unchecked
        private void rdoUniqueWordList_CheckedChanged(object sender, EventArgs e)
        {
            chkIncludeFrequency.Enabled = rdoUniqueWordList.Checked;
        }

        private void ProcessText()
        {
            string inputText = txtInputText.Text;
            int sentenceCount = CountSentences(inputText);
            List<string> wordList = GetWordList(inputText);
            Dictionary<string, int> uniqueWords = GetUniqueWordsDictionary(wordList);
            List<string> twoWordPairs = GetTwoWordPairs(inputText);
            int charCount = inputText.Length;
            double avgWordLength = CalculateAverageWordLength(wordList);
            double avgUniqueWordLength = CalculateAverageUniqueWordLength(uniqueWords.Keys.ToList());

            // Update the statistics labels
            lblSentenceCount.Text = sentenceCount.ToString();
            lblWordCount.Text = wordList.Count.ToString();
            lblUniqueWordCount.Text = uniqueWords.Count.ToString();
            lblTwoWordPairCount.Text = twoWordPairs.Count.ToString();
            lblCharCount.Text = charCount.ToString();
            lblAvgWordLength.Text = avgWordLength.ToString("F2");
            lblAvgUniqueWordLength.Text = avgUniqueWordLength.ToString("F2");

            // Display word list based on the selected radio button
            DisplaySelectedWordList(wordList, uniqueWords, twoWordPairs);
        }

        private int CountSentences(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c == '.' || c == '!' || c == '?')
                {
                    count++;
                }
            }

            return Math.Max(count, 1);
        }

        // Get a list of all words
        private List<string> GetWordList(string text)
        {
            List<string> words = new List<string>();
            string[] rawWords = text.Split(new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in rawWords)
            {
                string cleanWord = CleanWord(word);
                if (!string.IsNullOrEmpty(cleanWord) && !IsNumber(cleanWord))
                {
                    words.Add(cleanWord);
                }
            }
            words.Sort();

            return words;
        }

        private string CleanWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return string.Empty;

            StringBuilder cleanedWord = new StringBuilder();

            foreach (char c in word)
            {
                // Keep letters, hyphens, & apostrophes
                if (char.IsLetter(c) || c == '-' || c == '\'')
                {
                    cleanedWord.Append(c);
                }
            }

            return cleanedWord.ToString();
        }

        private bool IsNumber(string text)
        {
            return text.All(char.IsDigit);
        }

        // Get a dictionary of unique words & their frequencies
        private Dictionary<string, int> GetUniqueWordsDictionary(List<string> words)
        {
            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (uniqueWords.ContainsKey(word))
                {
                    uniqueWords[word]++;
                }
                else
                {
                    uniqueWords[word] = 1;
                }
            }

            return uniqueWords;
        }

        // Method to get two word pairs appear more than once
        private List<string> GetTwoWordPairs(string text)
        {
            List<string> allPairs = new List<string>();
            Dictionary<string, int> pairFrequency = new Dictionary<string, int>();

            string[] rawWords = text.Split(new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            List<string> cleanWords = new List<string>();
            foreach (string word in rawWords)
            {
                string cleanWord = CleanWord(word);
                if (!string.IsNullOrEmpty(cleanWord) && !IsNumber(cleanWord))
                {
                    cleanWords.Add(cleanWord);
                }
            }

            for (int i = 0; i < cleanWords.Count - 1; i++)
            {
                string pair = cleanWords[i] + " " + cleanWords[i + 1];

                if (pairFrequency.ContainsKey(pair))
                {
                    pairFrequency[pair]++;
                }
                else
                {
                    pairFrequency[pair] = 1;
                }
            }

            // Add pairs that appear more than once
            foreach (var pair in pairFrequency)
            {
                if (pair.Value > 1)
                {
                    for (int i = 0; i < pair.Value; i++)
                    {
                        allPairs.Add(pair.Key);
                    }
                }
            }

            allPairs.Sort();

            return allPairs;
        }

        private double CalculateAverageWordLength(List<string> words)
        {
            if (words.Count == 0)
                return 0;

            int totalLength = 0;
            foreach (string word in words)
            {
                totalLength += word.Length;
            }

            return (double)totalLength / words.Count;
        }

        private double CalculateAverageUniqueWordLength(List<string> uniqueWords)
        {
            if (uniqueWords.Count == 0)
                return 0;

            int totalLength = 0;
            foreach (string word in uniqueWords)
            {
                totalLength += word.Length;
            }

            return (double)totalLength / uniqueWords.Count;
        }

        // Display the selected word list
        private void DisplaySelectedWordList(List<string> wordList,
            Dictionary<string, int> uniqueWords, List<string> twoWordPairs)
        {
            txtWordList.Clear();

            if (rdoWordList.Checked)
            {
                // Display all words
                foreach (string word in wordList)
                {
                    txtWordList.AppendText(word + Environment.NewLine);
                }
            }
            else if (rdoUniqueWordList.Checked)
            {
                List<string> sortedUniqueWords = uniqueWords.Keys.ToList();
                sortedUniqueWords.Sort();

                foreach (string word in sortedUniqueWords)
                {
                    if (chkIncludeFrequency.Checked)
                    {
                        txtWordList.AppendText(word + " (" + uniqueWords[word] + ")" + Environment.NewLine);
                    }
                    else
                    {
                        txtWordList.AppendText(word + Environment.NewLine);
                    }
                }
            }
            else if (rdoTwoWordPairList.Checked)
            {
                foreach (string pair in twoWordPairs)
                {
                    txtWordList.AppendText(pair + Environment.NewLine);
                }
            }
        }
    }
}