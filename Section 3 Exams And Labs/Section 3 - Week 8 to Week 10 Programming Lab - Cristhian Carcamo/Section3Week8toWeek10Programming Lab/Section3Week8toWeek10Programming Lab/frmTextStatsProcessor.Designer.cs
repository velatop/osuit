namespace Section3Week8toWeek10Programming_Lab
{
    partial class TextStatsProcessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtWordList = new System.Windows.Forms.TextBox();
            this.lblTextInput = new System.Windows.Forms.Label();
            this.lblWordListOutput = new System.Windows.Forms.Label();
            this.gpbDisplayOptions = new System.Windows.Forms.GroupBox();
            this.rdoTwoWordPairList = new System.Windows.Forms.RadioButton();
            this.rdoUniqueWordList = new System.Windows.Forms.RadioButton();
            this.rdoWordList = new System.Windows.Forms.RadioButton();
            this.chkIncludeFrequency = new System.Windows.Forms.CheckBox();
            this.gpbStatistics = new System.Windows.Forms.GroupBox();
            this.lblAvgUniqueWordLength = new System.Windows.Forms.Label();
            this.lblAvgWordLength = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.lblTwoWordPairCount = new System.Windows.Forms.Label();
            this.lblUniqueWordCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblSentenceCount = new System.Windows.Forms.Label();
            this.lblStatAvgUniqueWordLength = new System.Windows.Forms.Label();
            this.lblStatAvgWordLength = new System.Windows.Forms.Label();
            this.lblStatSentenceCount = new System.Windows.Forms.Label();
            this.lblStatCharCount = new System.Windows.Forms.Label();
            this.lblStatTwoWordPairCount = new System.Windows.Forms.Label();
            this.lblStatUniqueWordCount = new System.Windows.Forms.Label();
            this.lblStatWordCount = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbDisplayOptions.SuspendLayout();
            this.gpbStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputText.Location = new System.Drawing.Point(32, 67);
            this.txtInputText.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputText.Size = new System.Drawing.Size(556, 287);
            this.txtInputText.TabIndex = 0;
            this.txtInputText.TextChanged += new System.EventHandler(this.txtInputText_TextChanged);
            // 
            // txtWordList
            // 
            this.txtWordList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordList.Location = new System.Drawing.Point(32, 425);
            this.txtWordList.Margin = new System.Windows.Forms.Padding(6);
            this.txtWordList.Multiline = true;
            this.txtWordList.Name = "txtWordList";
            this.txtWordList.ReadOnly = true;
            this.txtWordList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWordList.Size = new System.Drawing.Size(556, 556);
            this.txtWordList.TabIndex = 5;
            // 
            // lblTextInput
            // 
            this.lblTextInput.AutoSize = true;
            this.lblTextInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextInput.Location = new System.Drawing.Point(26, 29);
            this.lblTextInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTextInput.Name = "lblTextInput";
            this.lblTextInput.Size = new System.Drawing.Size(274, 36);
            this.lblTextInput.TabIndex = 2;
            this.lblTextInput.Text = "Enter Text to Process:";
            // 
            // lblWordListOutput
            // 
            this.lblWordListOutput.AutoSize = true;
            this.lblWordListOutput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordListOutput.Location = new System.Drawing.Point(26, 387);
            this.lblWordListOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWordListOutput.Name = "lblWordListOutput";
            this.lblWordListOutput.Size = new System.Drawing.Size(137, 36);
            this.lblWordListOutput.TabIndex = 3;
            this.lblWordListOutput.Text = "Word List:";
            // 
            // gpbDisplayOptions
            // 
            this.gpbDisplayOptions.Controls.Add(this.rdoTwoWordPairList);
            this.gpbDisplayOptions.Controls.Add(this.rdoUniqueWordList);
            this.gpbDisplayOptions.Controls.Add(this.rdoWordList);
            this.gpbDisplayOptions.Controls.Add(this.chkIncludeFrequency);
            this.gpbDisplayOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDisplayOptions.Location = new System.Drawing.Point(656, 98);
            this.gpbDisplayOptions.Margin = new System.Windows.Forms.Padding(6);
            this.gpbDisplayOptions.Name = "gpbDisplayOptions";
            this.gpbDisplayOptions.Padding = new System.Windows.Forms.Padding(6);
            this.gpbDisplayOptions.Size = new System.Drawing.Size(566, 256);
            this.gpbDisplayOptions.TabIndex = 1;
            this.gpbDisplayOptions.TabStop = false;
            this.gpbDisplayOptions.Text = "Display Options";
            // 
            // rdoTwoWordPairList
            // 
            this.rdoTwoWordPairList.AutoSize = true;
            this.rdoTwoWordPairList.Location = new System.Drawing.Point(38, 162);
            this.rdoTwoWordPairList.Margin = new System.Windows.Forms.Padding(6);
            this.rdoTwoWordPairList.Name = "rdoTwoWordPairList";
            this.rdoTwoWordPairList.Size = new System.Drawing.Size(280, 40);
            this.rdoTwoWordPairList.TabIndex = 2;
            this.rdoTwoWordPairList.Text = "Show Two-Word List";
            this.rdoTwoWordPairList.UseVisualStyleBackColor = true;
            // 
            // rdoUniqueWordList
            // 
            this.rdoUniqueWordList.AutoSize = true;
            this.rdoUniqueWordList.Location = new System.Drawing.Point(38, 104);
            this.rdoUniqueWordList.Margin = new System.Windows.Forms.Padding(6);
            this.rdoUniqueWordList.Name = "rdoUniqueWordList";
            this.rdoUniqueWordList.Size = new System.Drawing.Size(313, 40);
            this.rdoUniqueWordList.TabIndex = 1;
            this.rdoUniqueWordList.Text = "Show Unique Word List";
            this.rdoUniqueWordList.UseVisualStyleBackColor = true;
            this.rdoUniqueWordList.CheckedChanged += new System.EventHandler(this.rdoUniqueWordList_CheckedChanged);
            // 
            // rdoWordList
            // 
            this.rdoWordList.AutoSize = true;
            this.rdoWordList.Checked = true;
            this.rdoWordList.Location = new System.Drawing.Point(38, 46);
            this.rdoWordList.Margin = new System.Windows.Forms.Padding(6);
            this.rdoWordList.Name = "rdoWordList";
            this.rdoWordList.Size = new System.Drawing.Size(223, 40);
            this.rdoWordList.TabIndex = 0;
            this.rdoWordList.TabStop = true;
            this.rdoWordList.Text = "Show Word List";
            this.rdoWordList.UseVisualStyleBackColor = true;
            // 
            // chkIncludeFrequency
            // 
            this.chkIncludeFrequency.AutoSize = true;
            this.chkIncludeFrequency.Enabled = false;
            this.chkIncludeFrequency.Location = new System.Drawing.Point(65, 214);
            this.chkIncludeFrequency.Margin = new System.Windows.Forms.Padding(6);
            this.chkIncludeFrequency.Name = "chkIncludeFrequency";
            this.chkIncludeFrequency.Size = new System.Drawing.Size(276, 40);
            this.chkIncludeFrequency.TabIndex = 3;
            this.chkIncludeFrequency.Text = "Include Frequencies";
            this.chkIncludeFrequency.UseVisualStyleBackColor = true;
            // 
            // gpbStatistics
            // 
            this.gpbStatistics.Controls.Add(this.lblAvgUniqueWordLength);
            this.gpbStatistics.Controls.Add(this.lblAvgWordLength);
            this.gpbStatistics.Controls.Add(this.lblCharCount);
            this.gpbStatistics.Controls.Add(this.lblTwoWordPairCount);
            this.gpbStatistics.Controls.Add(this.lblUniqueWordCount);
            this.gpbStatistics.Controls.Add(this.lblWordCount);
            this.gpbStatistics.Controls.Add(this.lblSentenceCount);
            this.gpbStatistics.Controls.Add(this.lblStatAvgUniqueWordLength);
            this.gpbStatistics.Controls.Add(this.lblStatAvgWordLength);
            this.gpbStatistics.Controls.Add(this.lblStatSentenceCount);
            this.gpbStatistics.Controls.Add(this.lblStatCharCount);
            this.gpbStatistics.Controls.Add(this.lblStatTwoWordPairCount);
            this.gpbStatistics.Controls.Add(this.lblStatUniqueWordCount);
            this.gpbStatistics.Controls.Add(this.lblStatWordCount);
            this.gpbStatistics.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStatistics.Location = new System.Drawing.Point(630, 497);
            this.gpbStatistics.Margin = new System.Windows.Forms.Padding(6);
            this.gpbStatistics.Name = "gpbStatistics";
            this.gpbStatistics.Padding = new System.Windows.Forms.Padding(6);
            this.gpbStatistics.Size = new System.Drawing.Size(566, 396);
            this.gpbStatistics.TabIndex = 6;
            this.gpbStatistics.TabStop = false;
            this.gpbStatistics.Text = "Statistics";
            // 
            // lblAvgUniqueWordLength
            // 
            this.lblAvgUniqueWordLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgUniqueWordLength.Location = new System.Drawing.Point(372, 275);
            this.lblAvgUniqueWordLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAvgUniqueWordLength.Name = "lblAvgUniqueWordLength";
            this.lblAvgUniqueWordLength.Size = new System.Drawing.Size(164, 33);
            this.lblAvgUniqueWordLength.TabIndex = 13;
            this.lblAvgUniqueWordLength.Text = "0";
            this.lblAvgUniqueWordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgWordLength
            // 
            this.lblAvgWordLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgWordLength.Location = new System.Drawing.Point(372, 229);
            this.lblAvgWordLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAvgWordLength.Name = "lblAvgWordLength";
            this.lblAvgWordLength.Size = new System.Drawing.Size(164, 33);
            this.lblAvgWordLength.TabIndex = 12;
            this.lblAvgWordLength.Text = "0";
            this.lblAvgWordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharCount
            // 
            this.lblCharCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharCount.Location = new System.Drawing.Point(372, 183);
            this.lblCharCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(164, 33);
            this.lblCharCount.TabIndex = 11;
            this.lblCharCount.Text = "0";
            this.lblCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoWordPairCount
            // 
            this.lblTwoWordPairCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTwoWordPairCount.Location = new System.Drawing.Point(372, 137);
            this.lblTwoWordPairCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTwoWordPairCount.Name = "lblTwoWordPairCount";
            this.lblTwoWordPairCount.Size = new System.Drawing.Size(164, 33);
            this.lblTwoWordPairCount.TabIndex = 10;
            this.lblTwoWordPairCount.Text = "0";
            this.lblTwoWordPairCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUniqueWordCount
            // 
            this.lblUniqueWordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUniqueWordCount.Location = new System.Drawing.Point(372, 90);
            this.lblUniqueWordCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUniqueWordCount.Name = "lblUniqueWordCount";
            this.lblUniqueWordCount.Size = new System.Drawing.Size(164, 33);
            this.lblUniqueWordCount.TabIndex = 9;
            this.lblUniqueWordCount.Text = "0";
            this.lblUniqueWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWordCount
            // 
            this.lblWordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWordCount.Location = new System.Drawing.Point(372, 41);
            this.lblWordCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(164, 33);
            this.lblWordCount.TabIndex = 8;
            this.lblWordCount.Text = "0";
            this.lblWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSentenceCount
            // 
            this.lblSentenceCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSentenceCount.Location = new System.Drawing.Point(372, 331);
            this.lblSentenceCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSentenceCount.Name = "lblSentenceCount";
            this.lblSentenceCount.Size = new System.Drawing.Size(164, 33);
            this.lblSentenceCount.TabIndex = 7;
            this.lblSentenceCount.Text = "0";
            this.lblSentenceCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatAvgUniqueWordLength
            // 
            this.lblStatAvgUniqueWordLength.AutoSize = true;
            this.lblStatAvgUniqueWordLength.Location = new System.Drawing.Point(30, 275);
            this.lblStatAvgUniqueWordLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatAvgUniqueWordLength.Name = "lblStatAvgUniqueWordLength";
            this.lblStatAvgUniqueWordLength.Size = new System.Drawing.Size(321, 36);
            this.lblStatAvgUniqueWordLength.TabIndex = 6;
            this.lblStatAvgUniqueWordLength.Text = "Average Unique Word Len:";
            // 
            // lblStatAvgWordLength
            // 
            this.lblStatAvgWordLength.AutoSize = true;
            this.lblStatAvgWordLength.Location = new System.Drawing.Point(30, 229);
            this.lblStatAvgWordLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatAvgWordLength.Name = "lblStatAvgWordLength";
            this.lblStatAvgWordLength.Size = new System.Drawing.Size(270, 36);
            this.lblStatAvgWordLength.TabIndex = 5;
            this.lblStatAvgWordLength.Text = "Average Word Length:";
            // 
            // lblStatSentenceCount
            // 
            this.lblStatSentenceCount.AutoSize = true;
            this.lblStatSentenceCount.Location = new System.Drawing.Point(33, 329);
            this.lblStatSentenceCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatSentenceCount.Name = "lblStatSentenceCount";
            this.lblStatSentenceCount.Size = new System.Drawing.Size(205, 36);
            this.lblStatSentenceCount.TabIndex = 0;
            this.lblStatSentenceCount.Text = "Sentence Count:";
            // 
            // lblStatCharCount
            // 
            this.lblStatCharCount.AutoSize = true;
            this.lblStatCharCount.Location = new System.Drawing.Point(30, 183);
            this.lblStatCharCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatCharCount.Name = "lblStatCharCount";
            this.lblStatCharCount.Size = new System.Drawing.Size(208, 36);
            this.lblStatCharCount.TabIndex = 4;
            this.lblStatCharCount.Text = "Character Count:";
            // 
            // lblStatTwoWordPairCount
            // 
            this.lblStatTwoWordPairCount.AutoSize = true;
            this.lblStatTwoWordPairCount.Location = new System.Drawing.Point(30, 137);
            this.lblStatTwoWordPairCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatTwoWordPairCount.Name = "lblStatTwoWordPairCount";
            this.lblStatTwoWordPairCount.Size = new System.Drawing.Size(266, 36);
            this.lblStatTwoWordPairCount.TabIndex = 3;
            this.lblStatTwoWordPairCount.Text = "Two-Word Pair Count:";
            // 
            // lblStatUniqueWordCount
            // 
            this.lblStatUniqueWordCount.AutoSize = true;
            this.lblStatUniqueWordCount.Location = new System.Drawing.Point(30, 90);
            this.lblStatUniqueWordCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatUniqueWordCount.Name = "lblStatUniqueWordCount";
            this.lblStatUniqueWordCount.Size = new System.Drawing.Size(250, 36);
            this.lblStatUniqueWordCount.TabIndex = 2;
            this.lblStatUniqueWordCount.Text = "Unique Word Count:";
            // 
            // lblStatWordCount
            // 
            this.lblStatWordCount.AutoSize = true;
            this.lblStatWordCount.Location = new System.Drawing.Point(30, 44);
            this.lblStatWordCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatWordCount.Name = "lblStatWordCount";
            this.lblStatWordCount.Size = new System.Drawing.Size(160, 36);
            this.lblStatWordCount.TabIndex = 1;
            this.lblStatWordCount.Text = "Word Count:";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(93, 1039);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(6);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(180, 58);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "&Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(305, 1039);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 58);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(191, 1120);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TextStatsProcessor
            // 
            this.AcceptButton = this.btnProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1228, 1321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.gpbStatistics);
            this.Controls.Add(this.gpbDisplayOptions);
            this.Controls.Add(this.lblWordListOutput);
            this.Controls.Add(this.lblTextInput);
            this.Controls.Add(this.txtWordList);
            this.Controls.Add(this.txtInputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TextStatsProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Statistics Processor";
            this.Load += new System.EventHandler(this.TextStatsProcessor_Load);
            this.gpbDisplayOptions.ResumeLayout(false);
            this.gpbDisplayOptions.PerformLayout();
            this.gpbStatistics.ResumeLayout(false);
            this.gpbStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtWordList;
        private System.Windows.Forms.Label lblTextInput;
        private System.Windows.Forms.Label lblWordListOutput;
        private System.Windows.Forms.GroupBox gpbDisplayOptions;
        private System.Windows.Forms.RadioButton rdoTwoWordPairList;
        private System.Windows.Forms.RadioButton rdoUniqueWordList;
        private System.Windows.Forms.RadioButton rdoWordList;
        private System.Windows.Forms.CheckBox chkIncludeFrequency;
        private System.Windows.Forms.GroupBox gpbStatistics;
        private System.Windows.Forms.Label lblAvgUniqueWordLength;
        private System.Windows.Forms.Label lblAvgWordLength;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Label lblTwoWordPairCount;
        private System.Windows.Forms.Label lblUniqueWordCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblSentenceCount;
        private System.Windows.Forms.Label lblStatAvgUniqueWordLength;
        private System.Windows.Forms.Label lblStatAvgWordLength;
        private System.Windows.Forms.Label lblStatCharCount;
        private System.Windows.Forms.Label lblStatTwoWordPairCount;
        private System.Windows.Forms.Label lblStatUniqueWordCount;
        private System.Windows.Forms.Label lblStatWordCount;
        private System.Windows.Forms.Label lblStatSentenceCount;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}