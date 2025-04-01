namespace LabExamOne
{
    partial class ExamOne
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtMessage.Location = new System.Drawing.Point(27, 35);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(1516, 50);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TabStop = false;
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.BackColor = System.Drawing.Color.LightYellow;
            this.lblLastMessage.Font = new System.Drawing.Font("Courier New", 14F);
            this.lblLastMessage.Location = new System.Drawing.Point(9, 841);
            this.lblLastMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(1520, 56);
            this.lblLastMessage.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnClear.Location = new System.Drawing.Point(52, 713);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 77);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "&Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSend.Location = new System.Drawing.Point(264, 713);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(200, 77);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "&Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBlank
            // 
            this.btnBlank.BackColor = System.Drawing.Color.Black;
            this.btnBlank.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnBlank.ForeColor = System.Drawing.Color.White;
            this.btnBlank.Location = new System.Drawing.Point(520, 722);
            this.btnBlank.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(400, 77);
            this.btnBlank.TabIndex = 2;
            this.btnBlank.TabStop = false;
            this.btnBlank.Text = "BLANK";
            this.btnBlank.UseVisualStyleBackColor = false;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnExit.Location = new System.Drawing.Point(974, 722);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 77);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ExamOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1568, 1083);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblLastMessage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBlank);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ExamOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam 1 Lab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.Button btnExit;
    }
}