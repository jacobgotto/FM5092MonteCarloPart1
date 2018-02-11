namespace WindowsFormsApp2
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
            this.tbUnder = new System.Windows.Forms.TextBox();
            this.TbStrike = new System.Windows.Forms.TextBox();
            this.TbVol = new System.Windows.Forms.TextBox();
            this.TbTenor = new System.Windows.Forms.TextBox();
            this.TbRate = new System.Windows.Forms.TextBox();
            this.TbSteps = new System.Windows.Forms.TextBox();
            this.TbPaths = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.raBCall = new System.Windows.Forms.RadioButton();
            this.rdbPut = new System.Windows.Forms.RadioButton();
            this.rTBresults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbUnder
            // 
            this.tbUnder.Location = new System.Drawing.Point(165, 58);
            this.tbUnder.Name = "tbUnder";
            this.tbUnder.Size = new System.Drawing.Size(131, 26);
            this.tbUnder.TabIndex = 0;
            // 
            // TbStrike
            // 
            this.TbStrike.Location = new System.Drawing.Point(566, 58);
            this.TbStrike.Name = "TbStrike";
            this.TbStrike.Size = new System.Drawing.Size(131, 26);
            this.TbStrike.TabIndex = 1;
            // 
            // TbVol
            // 
            this.TbVol.Location = new System.Drawing.Point(165, 123);
            this.TbVol.Name = "TbVol";
            this.TbVol.Size = new System.Drawing.Size(131, 26);
            this.TbVol.TabIndex = 2;
            // 
            // TbTenor
            // 
            this.TbTenor.Location = new System.Drawing.Point(165, 186);
            this.TbTenor.Name = "TbTenor";
            this.TbTenor.Size = new System.Drawing.Size(131, 26);
            this.TbTenor.TabIndex = 3;
            // 
            // TbRate
            // 
            this.TbRate.Location = new System.Drawing.Point(566, 123);
            this.TbRate.Name = "TbRate";
            this.TbRate.Size = new System.Drawing.Size(131, 26);
            this.TbRate.TabIndex = 4;
            // 
            // TbSteps
            // 
            this.TbSteps.Location = new System.Drawing.Point(566, 186);
            this.TbSteps.Name = "TbSteps";
            this.TbSteps.Size = new System.Drawing.Size(131, 26);
            this.TbSteps.TabIndex = 5;
            // 
            // TbPaths
            // 
            this.TbPaths.Location = new System.Drawing.Point(165, 256);
            this.TbPaths.Name = "TbPaths";
            this.TbPaths.Size = new System.Drawing.Size(131, 26);
            this.TbPaths.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Underlying Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Strike Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Volatility (as percent):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Risk-Free Rate (as percent):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tenor (in years):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of Steps:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number of Paths:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(301, 384);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(259, 100);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // raBCall
            // 
            this.raBCall.AutoSize = true;
            this.raBCall.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.raBCall.Location = new System.Drawing.Point(232, 329);
            this.raBCall.Name = "raBCall";
            this.raBCall.Size = new System.Drawing.Size(111, 24);
            this.raBCall.TabIndex = 15;
            this.raBCall.Text = "Call Option";
            this.raBCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.raBCall.UseVisualStyleBackColor = true;
            // 
            // rdbPut
            // 
            this.rdbPut.AutoSize = true;
            this.rdbPut.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbPut.Location = new System.Drawing.Point(471, 327);
            this.rdbPut.Name = "rdbPut";
            this.rdbPut.Size = new System.Drawing.Size(109, 24);
            this.rdbPut.TabIndex = 16;
            this.rdbPut.Text = "Put Option";
            this.rdbPut.UseVisualStyleBackColor = true;
            // 
            // rTBresults
            // 
            this.rTBresults.Location = new System.Drawing.Point(31, 548);
            this.rTBresults.Name = "rTBresults";
            this.rTBresults.Size = new System.Drawing.Size(768, 159);
            this.rTBresults.TabIndex = 24;
            this.rTBresults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 763);
            this.Controls.Add(this.rTBresults);
            this.Controls.Add(this.rdbPut);
            this.Controls.Add(this.raBCall);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbPaths);
            this.Controls.Add(this.TbSteps);
            this.Controls.Add(this.TbRate);
            this.Controls.Add(this.TbTenor);
            this.Controls.Add(this.TbVol);
            this.Controls.Add(this.TbStrike);
            this.Controls.Add(this.tbUnder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUnder;
        private System.Windows.Forms.TextBox TbStrike;
        private System.Windows.Forms.TextBox TbVol;
        private System.Windows.Forms.TextBox TbTenor;
        private System.Windows.Forms.TextBox TbRate;
        private System.Windows.Forms.TextBox TbSteps;
        private System.Windows.Forms.TextBox TbPaths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton raBCall;
        private System.Windows.Forms.RadioButton rdbPut;
        private System.Windows.Forms.RichTextBox rTBresults;
    }
}

