namespace Module3Exercise2Project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //Added region
        #region windows form defsigner generated code

        private void InitializeComponent()
        {
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button(); // Renamed from button2 to match the handler
            this.btnR = new System.Windows.Forms.Button(); //Changed to btnR since it's the right button
            this.btnL = new System.Windows.Forms.Button(); // More sense as btnL for left
            this.btnExit = new System.Windows.Forms.Button(); // Better name than button5
            this.lblMessage = new System.Windows.Forms.Label(); //
            this.SuspendLayout();
            //
            // btnRed
            //
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(21, 16);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(93, 45);
            this.btnRed.TabIndex = 0; //First in tab order
            this.btnRed.Text = "&R"; // added quick access key
            this.btnRed.ForeColor = System.Drawing.Color.Red;//Hid the text by matching colors
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            //
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(376, 16); // Align top with label
            this.btnBlue.Name = "btnBlue"; // Fixed the name
            this.btnBlue.Size = new System.Drawing.Size(93, 45);
            this.btnBlue.TabIndex = 1; // Second in sequence
            this.btnBlue.Text = "&B"; // Add keyboard shortcut
            this.btnBlue.ForeColor = System.Drawing.Color.Blue; // Maded text invisible
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click); // Fixed handler name
            // 
            // btnR
            //
            this.btnR.Location = new System.Drawing.Point(376, 175); // label's bottom
            this.btnR.Name = "btnR"; // Updated name
            this.btnR.Size = new System.Drawing.Size(93, 45);
            this.btnR.TabIndex = 3; // Fourth in tab order
            this.btnR.Text = "&R"; //Added shortcut key
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click); // New name
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(21, 175); // Same bottom as message
            this.btnL.Name = "btnL"; // Updated the name
            this.btnL.Size = new System.Drawing.Size(93, 45);
            this.btnL.TabIndex = 2; // third when tabbing
            this.btnL.Text = "&L"; // quick access letter
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);// Fixed event name
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(133, 200); // Put it under the label
            this.btnExit.Name = "btnExit"; //better name now
            this.btnExit.Size = new System.Drawing.Size(219, 45);// Same width as label
            this.btnExit.TabIndex = 4;//Last in tab sequence
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            this.CancelButton = this.btnExit; //Added escape key support
            // 
            // lblMessage
            //
            this.lblMessage.BackColor = System.Drawing.Color.Yellow;
            this.lblMessage.ForeColor = System.Drawing.Color.Black; // Changed to black text
            this.lblMessage.Location = new System.Drawing.Point(133, 16);
            this.lblMessage.Name = "lblMessage"; // Descriptive name
            this.lblMessage.Size = new System.Drawing.Size(219, 184);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message"; //default text
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 16F); // Made text bigger
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; //Centered it
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 343);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue; // Changed from button2
        private System.Windows.Forms.Button btnR;//Was button3 before
        private System.Windows.Forms.Button btnL; // Previously button4
        private System.Windows.Forms.Button btnExit; // Old button5
        private System.Windows.Forms.Label lblMessage; //just label1
    }
}