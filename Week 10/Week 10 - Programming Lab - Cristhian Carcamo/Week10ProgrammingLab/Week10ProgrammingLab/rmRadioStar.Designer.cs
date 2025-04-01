namespace Week10ProgrammingLab
{
    partial class frmRadioStar
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
            this.lblLeftOperand = new System.Windows.Forms.Label();
            this.lblRightOperand = new System.Windows.Forms.Label();
            this.txtLeftOperand = new System.Windows.Forms.TextBox();
            this.txtRightOperand = new System.Windows.Forms.TextBox();
            this.grpMathOperations = new System.Windows.Forms.GroupBox();
            this.rdoModulus = new System.Windows.Forms.RadioButton();
            this.rdoDivision = new System.Windows.Forms.RadioButton();
            this.rdoMultiplication = new System.Windows.Forms.RadioButton();
            this.rdoSubtraction = new System.Windows.Forms.RadioButton();
            this.rdoAddition = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chkVerbose = new System.Windows.Forms.CheckBox();
            this.grpMathOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeftOperand
            // 
            this.lblLeftOperand.AutoSize = true;
            this.lblLeftOperand.Location = new System.Drawing.Point(70, 70);
            this.lblLeftOperand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLeftOperand.Name = "lblLeftOperand";
            this.lblLeftOperand.Size = new System.Drawing.Size(143, 25);
            this.lblLeftOperand.TabIndex = 0;
            this.lblLeftOperand.Text = "&Left Operand:";
            // 
            // lblRightOperand
            // 
            this.lblRightOperand.AutoSize = true;
            this.lblRightOperand.Location = new System.Drawing.Point(56, 129);
            this.lblRightOperand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRightOperand.Name = "lblRightOperand";
            this.lblRightOperand.Size = new System.Drawing.Size(157, 25);
            this.lblRightOperand.TabIndex = 2;
            this.lblRightOperand.Text = "&Right Operand:";
            // 
            // txtLeftOperand
            // 
            this.txtLeftOperand.BackColor = System.Drawing.Color.LightYellow;
            this.txtLeftOperand.Location = new System.Drawing.Point(232, 70);
            this.txtLeftOperand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLeftOperand.Name = "txtLeftOperand";
            this.txtLeftOperand.Size = new System.Drawing.Size(196, 31);
            this.txtLeftOperand.TabIndex = 1;
            // 
            // txtRightOperand
            // 
            this.txtRightOperand.BackColor = System.Drawing.Color.LightYellow;
            this.txtRightOperand.Location = new System.Drawing.Point(232, 123);
            this.txtRightOperand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRightOperand.Name = "txtRightOperand";
            this.txtRightOperand.Size = new System.Drawing.Size(196, 31);
            this.txtRightOperand.TabIndex = 3;
            // 
            // grpMathOperations
            // 
            this.grpMathOperations.Controls.Add(this.rdoModulus);
            this.grpMathOperations.Controls.Add(this.rdoDivision);
            this.grpMathOperations.Controls.Add(this.rdoMultiplication);
            this.grpMathOperations.Controls.Add(this.rdoSubtraction);
            this.grpMathOperations.Controls.Add(this.rdoAddition);
            this.grpMathOperations.Location = new System.Drawing.Point(62, 215);
            this.grpMathOperations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpMathOperations.Name = "grpMathOperations";
            this.grpMathOperations.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpMathOperations.Size = new System.Drawing.Size(400, 288);
            this.grpMathOperations.TabIndex = 4;
            this.grpMathOperations.TabStop = false;
            this.grpMathOperations.Text = "Math Operations Available";
            // 
            // rdoModulus
            // 
            this.rdoModulus.AutoSize = true;
            this.rdoModulus.Location = new System.Drawing.Point(32, 221);
            this.rdoModulus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoModulus.Name = "rdoModulus";
            this.rdoModulus.Size = new System.Drawing.Size(164, 29);
            this.rdoModulus.TabIndex = 4;
            this.rdoModulus.TabStop = true;
            this.rdoModulus.Text = "Modulus (%)";
            this.rdoModulus.UseVisualStyleBackColor = true;
            // 
            // rdoDivision
            // 
            this.rdoDivision.AutoSize = true;
            this.rdoDivision.Location = new System.Drawing.Point(32, 177);
            this.rdoDivision.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoDivision.Name = "rdoDivision";
            this.rdoDivision.Size = new System.Drawing.Size(145, 29);
            this.rdoDivision.TabIndex = 3;
            this.rdoDivision.TabStop = true;
            this.rdoDivision.Text = "Division (/)";
            this.rdoDivision.UseVisualStyleBackColor = true;
            // 
            // rdoMultiplication
            // 
            this.rdoMultiplication.AutoSize = true;
            this.rdoMultiplication.Location = new System.Drawing.Point(32, 133);
            this.rdoMultiplication.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoMultiplication.Name = "rdoMultiplication";
            this.rdoMultiplication.Size = new System.Drawing.Size(197, 29);
            this.rdoMultiplication.TabIndex = 2;
            this.rdoMultiplication.TabStop = true;
            this.rdoMultiplication.Text = "Multiplication (*)";
            this.rdoMultiplication.UseVisualStyleBackColor = true;
            // 
            // rdoSubtraction
            // 
            this.rdoSubtraction.AutoSize = true;
            this.rdoSubtraction.Location = new System.Drawing.Point(32, 88);
            this.rdoSubtraction.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoSubtraction.Name = "rdoSubtraction";
            this.rdoSubtraction.Size = new System.Drawing.Size(179, 29);
            this.rdoSubtraction.TabIndex = 1;
            this.rdoSubtraction.TabStop = true;
            this.rdoSubtraction.Text = "Subtraction (-)";
            this.rdoSubtraction.UseVisualStyleBackColor = true;
            // 
            // rdoAddition
            // 
            this.rdoAddition.AutoSize = true;
            this.rdoAddition.Location = new System.Drawing.Point(32, 47);
            this.rdoAddition.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoAddition.Name = "rdoAddition";
            this.rdoAddition.Size = new System.Drawing.Size(153, 29);
            this.rdoAddition.TabIndex = 0;
            this.rdoAddition.TabStop = true;
            this.rdoAddition.Text = "Addition (+)";
            this.rdoAddition.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(75, 560);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 44);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(255, 560);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(456, 560);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(50, 643);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(556, 131);
            this.lblMessage.TabIndex = 9;
            // 
            // chkVerbose
            // 
            this.chkVerbose.AutoSize = true;
            this.chkVerbose.Location = new System.Drawing.Point(61, 503);
            this.chkVerbose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkVerbose.Name = "chkVerbose";
            this.chkVerbose.Size = new System.Drawing.Size(264, 29);
            this.chkVerbose.TabIndex = 8;
            this.chkVerbose.Text = "Turn on Verbose Mode";
            this.chkVerbose.UseVisualStyleBackColor = true;
            // 
            // frmRadioStar
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(625, 783);
            this.Controls.Add(this.chkVerbose);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpMathOperations);
            this.Controls.Add(this.txtRightOperand);
            this.Controls.Add(this.txtLeftOperand);
            this.Controls.Add(this.lblRightOperand);
            this.Controls.Add(this.lblLeftOperand);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmRadioStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons in Action";
            this.Load += new System.EventHandler(this.frmRadioStar_Load);
            this.grpMathOperations.ResumeLayout(false);
            this.grpMathOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeftOperand;
        private System.Windows.Forms.Label lblRightOperand;
        private System.Windows.Forms.TextBox txtLeftOperand;
        private System.Windows.Forms.TextBox txtRightOperand;
        private System.Windows.Forms.GroupBox grpMathOperations;
        private System.Windows.Forms.RadioButton rdoModulus;
        private System.Windows.Forms.RadioButton rdoDivision;
        private System.Windows.Forms.RadioButton rdoMultiplication;
        private System.Windows.Forms.RadioButton rdoSubtraction;
        private System.Windows.Forms.RadioButton rdoAddition;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkVerbose;
    }
}