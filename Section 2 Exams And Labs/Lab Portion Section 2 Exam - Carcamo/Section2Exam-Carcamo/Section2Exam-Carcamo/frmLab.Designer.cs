namespace Section2Exam_Carcamo
{
    partial class frmLab
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
            this.btnShowModulus = new System.Windows.Forms.Button();
            this.btnShowFactorial = new System.Windows.Forms.Button();
            this.btnShowFibonacci = new System.Windows.Forms.Button();
            this.btnDoModulus = new System.Windows.Forms.Button();
            this.btnDoFactorial = new System.Windows.Forms.Button();
            this.btnDoFibonacci = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowModulus
            // 
            this.btnShowModulus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowModulus.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowModulus.Location = new System.Drawing.Point(45, 47);
            this.btnShowModulus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowModulus.Name = "btnShowModulus";
            this.btnShowModulus.Size = new System.Drawing.Size(307, 78);
            this.btnShowModulus.TabIndex = 0;
            this.btnShowModulus.Text = "Show Modulus";
            this.btnShowModulus.UseVisualStyleBackColor = false;
            this.btnShowModulus.Click += new System.EventHandler(this.btnShowModulus_Click);
            // 
            // btnShowFactorial
            // 
            this.btnShowFactorial.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowFactorial.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFactorial.Location = new System.Drawing.Point(379, 47);
            this.btnShowFactorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowFactorial.Name = "btnShowFactorial";
            this.btnShowFactorial.Size = new System.Drawing.Size(395, 78);
            this.btnShowFactorial.TabIndex = 1;
            this.btnShowFactorial.Text = "Show Factorial";
            this.btnShowFactorial.UseVisualStyleBackColor = false;
            this.btnShowFactorial.Click += new System.EventHandler(this.btnShowFactorial_Click);
            // 
            // btnShowFibonacci
            // 
            this.btnShowFibonacci.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowFibonacci.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFibonacci.Location = new System.Drawing.Point(798, 47);
            this.btnShowFibonacci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowFibonacci.Name = "btnShowFibonacci";
            this.btnShowFibonacci.Size = new System.Drawing.Size(396, 78);
            this.btnShowFibonacci.TabIndex = 2;
            this.btnShowFibonacci.Text = "Show Fibonacci";
            this.btnShowFibonacci.UseVisualStyleBackColor = false;
            this.btnShowFibonacci.Click += new System.EventHandler(this.btnShowFibonacci_Click);
            // 
            // btnDoModulus
            // 
            this.btnDoModulus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDoModulus.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoModulus.Location = new System.Drawing.Point(45, 147);
            this.btnDoModulus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoModulus.Name = "btnDoModulus";
            this.btnDoModulus.Size = new System.Drawing.Size(327, 78);
            this.btnDoModulus.TabIndex = 3;
            this.btnDoModulus.Text = "&Do Modulus";
            this.btnDoModulus.UseVisualStyleBackColor = false;
            this.btnDoModulus.Click += new System.EventHandler(this.btnDoModulus_Click);
            // 
            // btnDoFactorial
            // 
            this.btnDoFactorial.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDoFactorial.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoFactorial.Location = new System.Drawing.Point(394, 147);
            this.btnDoFactorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoFactorial.Name = "btnDoFactorial";
            this.btnDoFactorial.Size = new System.Drawing.Size(407, 78);
            this.btnDoFactorial.TabIndex = 4;
            this.btnDoFactorial.Text = "&Do Factorial";
            this.btnDoFactorial.UseVisualStyleBackColor = false;
            this.btnDoFactorial.Click += new System.EventHandler(this.btnDoFactorial_Click);
            // 
            // btnDoFibonacci
            // 
            this.btnDoFibonacci.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDoFibonacci.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoFibonacci.Location = new System.Drawing.Point(809, 147);
            this.btnDoFibonacci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoFibonacci.Name = "btnDoFibonacci";
            this.btnDoFibonacci.Size = new System.Drawing.Size(385, 78);
            this.btnDoFibonacci.TabIndex = 5;
            this.btnDoFibonacci.Text = "&Do Fibonacci";
            this.btnDoFibonacci.UseVisualStyleBackColor = false;
            this.btnDoFibonacci.Click += new System.EventHandler(this.btnDoFibonacci_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Chocolate;
            this.btnClear.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(45, 594);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(225, 78);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Chocolate;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(720, 594);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 78);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOperand1
            // 
            this.txtOperand1.BackColor = System.Drawing.Color.SpringGreen;
            this.txtOperand1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand1.Location = new System.Drawing.Point(360, 267);
            this.txtOperand1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(406, 50);
            this.txtOperand1.TabIndex = 8;
            this.txtOperand1.TabStop = false;
            // 
            // txtOperand2
            // 
            this.txtOperand2.BackColor = System.Drawing.Color.Honeydew;
            this.txtOperand2.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand2.Location = new System.Drawing.Point(360, 344);
            this.txtOperand2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(406, 50);
            this.txtOperand2.TabIndex = 9;
            this.txtOperand2.TabStop = false;
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand1.Location = new System.Drawing.Point(45, 270);
            this.lblOperand1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(270, 40);
            this.lblOperand1.TabIndex = 10;
            this.lblOperand1.Text = "Operando 1:";
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand2.Location = new System.Drawing.Point(45, 348);
            this.lblOperand2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(270, 40);
            this.lblOperand2.TabIndex = 11;
            this.lblOperand2.Text = "Operando 2:";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.LightCyan;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(45, 422);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1149, 140);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1414, 703);
            this.Controls.Add(this.btnShowModulus);
            this.Controls.Add(this.btnShowFactorial);
            this.Controls.Add(this.btnShowFibonacci);
            this.Controls.Add(this.btnDoModulus);
            this.Controls.Add(this.btnDoFactorial);
            this.Controls.Add(this.btnDoFibonacci);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.lblOperand1);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.lblMessage);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations Cristhian Carcamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowModulus;
        private System.Windows.Forms.Button btnShowFactorial;
        private System.Windows.Forms.Button btnShowFibonacci;
        private System.Windows.Forms.Button btnDoModulus;
        private System.Windows.Forms.Button btnDoFactorial;
        private System.Windows.Forms.Button btnDoFibonacci;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.Label lblMessage;
    }
}