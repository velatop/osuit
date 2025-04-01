namespace Project5Carcamo
{
    partial class frmChoices
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFormInstructions;
        private System.Windows.Forms.Label lblRangeLeft;
        private System.Windows.Forms.Label lblRangeRight;
        private System.Windows.Forms.Label lblCheckDescription;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.TextBox txtRangeLeft;
        private System.Windows.Forms.TextBox txtRangeRight;
        private System.Windows.Forms.TextBox txtCheckNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFormInstructions = new System.Windows.Forms.Label();
            this.lblRangeLeft = new System.Windows.Forms.Label();
            this.lblRangeRight = new System.Windows.Forms.Label();
            this.lblCheckDescription = new System.Windows.Forms.Label();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.txtRangeLeft = new System.Windows.Forms.TextBox();
            this.txtRangeRight = new System.Windows.Forms.TextBox();
            this.txtCheckNumber = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormInstructions
            // 
            this.lblFormInstructions.BackColor = System.Drawing.Color.CadetBlue;
            this.lblFormInstructions.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblFormInstructions.Location = new System.Drawing.Point(15, 38);
            this.lblFormInstructions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFormInstructions.Name = "lblFormInstructions";
            this.lblFormInstructions.Size = new System.Drawing.Size(1538, 115);
            this.lblFormInstructions.TabIndex = 0;
            this.lblFormInstructions.Text = "Enter a number in text. Click the button to show if the number in the middle text" +
    " box is between the numbers in the left and right. The right number should be la" +
    "rger than the left";
            this.lblFormInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRangeLeft
            // 
            this.lblRangeLeft.BackColor = System.Drawing.Color.LightBlue;
            this.lblRangeLeft.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblRangeLeft.Location = new System.Drawing.Point(40, 192);
            this.lblRangeLeft.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRangeLeft.Name = "lblRangeLeft";
            this.lblRangeLeft.Size = new System.Drawing.Size(360, 58);
            this.lblRangeLeft.TabIndex = 1;
            this.lblRangeLeft.Text = "Left Number";
            this.lblRangeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRangeRight
            // 
            this.lblRangeRight.BackColor = System.Drawing.Color.LightBlue;
            this.lblRangeRight.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblRangeRight.Location = new System.Drawing.Point(1160, 192);
            this.lblRangeRight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRangeRight.Name = "lblRangeRight";
            this.lblRangeRight.Size = new System.Drawing.Size(360, 58);
            this.lblRangeRight.TabIndex = 2;
            this.lblRangeRight.Text = "Right Number";
            this.lblRangeRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCheckDescription
            // 
            this.lblCheckDescription.BackColor = System.Drawing.Color.LightBlue;
            this.lblCheckDescription.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCheckDescription.Location = new System.Drawing.Point(604, 346);
            this.lblCheckDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCheckDescription.Name = "lblCheckDescription";
            this.lblCheckDescription.Size = new System.Drawing.Size(360, 58);
            this.lblCheckDescription.TabIndex = 3;
            this.lblCheckDescription.Text = "Number Checked";
            this.lblCheckDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.BackColor = System.Drawing.Color.LightYellow;
            this.lblUserMessage.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblUserMessage.Location = new System.Drawing.Point(40, 625);
            this.lblUserMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(1488, 115);
            this.lblUserMessage.TabIndex = 10;
            this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRangeLeft
            // 
            this.txtRangeLeft.BackColor = System.Drawing.Color.White;
            this.txtRangeLeft.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtRangeLeft.Location = new System.Drawing.Point(44, 280);
            this.txtRangeLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRangeLeft.Name = "txtRangeLeft";
            this.txtRangeLeft.Size = new System.Drawing.Size(356, 50);
            this.txtRangeLeft.TabIndex = 4;
            this.txtRangeLeft.TabStop = false;
            // 
            // txtRangeRight
            // 
            this.txtRangeRight.BackColor = System.Drawing.Color.White;
            this.txtRangeRight.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtRangeRight.Location = new System.Drawing.Point(1164, 269);
            this.txtRangeRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRangeRight.Name = "txtRangeRight";
            this.txtRangeRight.Size = new System.Drawing.Size(356, 50);
            this.txtRangeRight.TabIndex = 5;
            this.txtRangeRight.TabStop = false;
            // 
            // txtCheckNumber
            // 
            this.txtCheckNumber.BackColor = System.Drawing.Color.White;
            this.txtCheckNumber.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtCheckNumber.Location = new System.Drawing.Point(608, 430);
            this.txtCheckNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.Size = new System.Drawing.Size(356, 50);
            this.txtCheckNumber.TabIndex = 6;
            this.txtCheckNumber.TabStop = false;
            this.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGreen;
            this.btnClear.Location = new System.Drawing.Point(110, 508);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(240, 67);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clea&R";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightGreen;
            this.btnCheck.Location = new System.Drawing.Point(648, 519);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(240, 67);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGreen;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1217, 528);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 67);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&Xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmChoices
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1568, 790);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCheckNumber);
            this.Controls.Add(this.txtRangeRight);
            this.Controls.Add(this.txtRangeLeft);
            this.Controls.Add(this.lblCheckDescription);
            this.Controls.Add(this.lblRangeRight);
            this.Controls.Add(this.lblRangeLeft);
            this.Controls.Add(this.lblFormInstructions);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmChoices";
            this.Text = "Carcamo Choices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}