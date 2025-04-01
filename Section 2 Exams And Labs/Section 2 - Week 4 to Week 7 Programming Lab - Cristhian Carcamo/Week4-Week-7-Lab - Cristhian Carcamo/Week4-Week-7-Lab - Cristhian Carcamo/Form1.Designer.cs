namespace Week4_Week_7_Lab___Cristhian_Carcamo
{
    partial class Form1
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
            this.lblConvertFrom = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtConvertFrom = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnBase6 = new System.Windows.Forms.Button();
            this.btnBase9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConvertFrom
            // 
            this.lblConvertFrom.AutoSize = true;
            this.lblConvertFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertFrom.Location = new System.Drawing.Point(45, 39);
            this.lblConvertFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConvertFrom.Name = "lblConvertFrom";
            this.lblConvertFrom.Size = new System.Drawing.Size(421, 31);
            this.lblConvertFrom.TabIndex = 0;
            this.lblConvertFrom.Text = "Enter Decimal Number (Base-10):";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(45, 118);
            this.lblBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(235, 31);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Enter Base (2-16):";
            // 
            // txtConvertFrom
            // 
            this.txtConvertFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertFrom.Location = new System.Drawing.Point(495, 39);
            this.txtConvertFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConvertFrom.Name = "txtConvertFrom";
            this.txtConvertFrom.Size = new System.Drawing.Size(298, 38);
            this.txtConvertFrom.TabIndex = 2;
            this.txtConvertFrom.Tag = "Number to convert";
            this.txtConvertFrom.TextChanged += new System.EventHandler(this.txtConvertFrom_TextChanged);
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(321, 115);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(298, 38);
            this.txtBase.TabIndex = 3;
            this.txtBase.Tag = "Base";
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(495, 178);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(300, 62);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "&Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.Enabled = false;
            this.btnBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinary.Location = new System.Drawing.Point(45, 266);
            this.btnBinary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(195, 62);
            this.btnBinary.TabIndex = 5;
            this.btnBinary.Text = "&Binary";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnHex
            // 
            this.btnHex.Enabled = false;
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.Location = new System.Drawing.Point(296, 266);
            this.btnHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(195, 62);
            this.btnHex.TabIndex = 6;
            this.btnHex.Text = "&Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.Enabled = false;
            this.btnOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctal.Location = new System.Drawing.Point(543, 266);
            this.btnOctal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(195, 62);
            this.btnOctal.TabIndex = 7;
            this.btnOctal.Text = "&Octal";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnBase6
            // 
            this.btnBase6.Enabled = false;
            this.btnBase6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase6.Location = new System.Drawing.Point(126, 359);
            this.btnBase6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBase6.Name = "btnBase6";
            this.btnBase6.Size = new System.Drawing.Size(195, 62);
            this.btnBase6.TabIndex = 8;
            this.btnBase6.Text = "Base &6";
            this.btnBase6.UseVisualStyleBackColor = true;
            this.btnBase6.Click += new System.EventHandler(this.btnBase6_Click);
            // 
            // btnBase9
            // 
            this.btnBase9.Enabled = false;
            this.btnBase9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase9.Location = new System.Drawing.Point(495, 359);
            this.btnBase9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBase9.Name = "btnBase9";
            this.btnBase9.Size = new System.Drawing.Size(195, 62);
            this.btnBase9.TabIndex = 9;
            this.btnBase9.Text = "Base &9";
            this.btnBase9.UseVisualStyleBackColor = true;
            this.btnBase9.Click += new System.EventHandler(this.btnBase9_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(228, 468);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 62);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(415, 468);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 62);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageTitle.Location = new System.Drawing.Point(45, 547);
            this.lblMessageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(107, 31);
            this.lblMessageTitle.TabIndex = 12;
            this.lblMessageTitle.Text = "Result:";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.LightBlue;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(119, 590);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(674, 77);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(829, 703);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMessageTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBase9);
            this.Controls.Add(this.btnBase6);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtConvertFrom);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblConvertFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Number Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvertFrom;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtConvertFrom;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnBase6;
        private System.Windows.Forms.Button btnBase9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Label lblMessage;
    }
}