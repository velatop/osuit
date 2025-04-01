namespace Week8ProgrammingLab
{
    partial class frmCollections
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbCollection = new System.Windows.Forms.RichTextBox();
            this.rtbStats = new System.Windows.Forms.RichTextBox();
            this.lblCollection = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(24, 46);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(318, 25);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter a number (-1217 to 1217):";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(354, 40);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(196, 31);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(30, 110);
            this.btnAddNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(224, 44);
            this.btnAddNumber.TabIndex = 1;
            this.btnAddNumber.Text = "Add Number";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(266, 110);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(224, 44);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(562, 110);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(224, 44);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(809, 110);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbCollection
            // 
            this.rtbCollection.BackColor = System.Drawing.Color.Turquoise;
            this.rtbCollection.Location = new System.Drawing.Point(35, 232);
            this.rtbCollection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbCollection.Name = "rtbCollection";
            this.rtbCollection.ReadOnly = true;
            this.rtbCollection.Size = new System.Drawing.Size(396, 432);
            this.rtbCollection.TabIndex = 5;
            this.rtbCollection.TabStop = false;
            this.rtbCollection.Text = "";
            // 
            // rtbStats
            // 
            this.rtbStats.BackColor = System.Drawing.Color.RoyalBlue;
            this.rtbStats.Location = new System.Drawing.Point(531, 232);
            this.rtbStats.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbStats.Name = "rtbStats";
            this.rtbStats.ReadOnly = true;
            this.rtbStats.Size = new System.Drawing.Size(476, 302);
            this.rtbStats.TabIndex = 6;
            this.rtbStats.TabStop = false;
            this.rtbStats.Text = "";
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(30, 192);
            this.lblCollection.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(113, 25);
            this.lblCollection.TabIndex = 7;
            this.lblCollection.Text = "Collection:";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(542, 192);
            this.lblStats.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(105, 25);
            this.lblStats.TabIndex = 8;
            this.lblStats.Text = "Statistics:";
            // 
            // frmCollections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 829);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblCollection);
            this.Controls.Add(this.rtbStats);
            this.Controls.Add(this.rtbCollection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCollections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collection Lab";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCollections_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbCollection;
        private System.Windows.Forms.RichTextBox rtbStats;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Label lblStats;
    }
}