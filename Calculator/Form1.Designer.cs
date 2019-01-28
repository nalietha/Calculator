namespace Calculator
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnSQRT = new System.Windows.Forms.Button();
            this.btnPosNeg = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnFraction = new System.Windows.Forms.Button();
            this.btnXYExpo = new System.Windows.Forms.Button();
            this.btnExpo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNegitive = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.lblPart2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnSQRT
            // 
            this.btnSQRT.Location = new System.Drawing.Point(22, 52);
            this.btnSQRT.Margin = new System.Windows.Forms.Padding(1);
            this.btnSQRT.Name = "btnSQRT";
            this.btnSQRT.Size = new System.Drawing.Size(47, 33);
            this.btnSQRT.TabIndex = 0;
            this.btnSQRT.Text = "SQRT";
            this.btnSQRT.UseVisualStyleBackColor = true;
            this.btnSQRT.Click += new System.EventHandler(this.btnSQRT_Click);
            // 
            // btnPosNeg
            // 
            this.btnPosNeg.Location = new System.Drawing.Point(22, 230);
            this.btnPosNeg.Margin = new System.Windows.Forms.Padding(1);
            this.btnPosNeg.Name = "btnPosNeg";
            this.btnPosNeg.Size = new System.Drawing.Size(47, 33);
            this.btnPosNeg.TabIndex = 1;
            this.btnPosNeg.Text = "+/-";
            this.btnPosNeg.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(22, 194);
            this.btnOne.Margin = new System.Windows.Forms.Padding(1);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(47, 33);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(22, 159);
            this.btnFour.Margin = new System.Windows.Forms.Padding(1);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(47, 33);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(22, 123);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(1);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(47, 33);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Location = new System.Drawing.Point(22, 88);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(47, 33);
            this.btnClearEntry.TabIndex = 5;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnFraction
            // 
            this.btnFraction.Location = new System.Drawing.Point(167, 52);
            this.btnFraction.Margin = new System.Windows.Forms.Padding(1);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(47, 33);
            this.btnFraction.TabIndex = 6;
            this.btnFraction.Text = "1/X";
            this.btnFraction.UseVisualStyleBackColor = true;
            this.btnFraction.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnXYExpo
            // 
            this.btnXYExpo.Location = new System.Drawing.Point(120, 52);
            this.btnXYExpo.Margin = new System.Windows.Forms.Padding(1);
            this.btnXYExpo.Name = "btnXYExpo";
            this.btnXYExpo.Size = new System.Drawing.Size(45, 33);
            this.btnXYExpo.TabIndex = 7;
            this.btnXYExpo.Text = "X^Y";
            this.btnXYExpo.UseVisualStyleBackColor = true;
            this.btnXYExpo.Click += new System.EventHandler(this.btnXYExpo_Click);
            // 
            // btnExpo
            // 
            this.btnExpo.Location = new System.Drawing.Point(71, 52);
            this.btnExpo.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(47, 33);
            this.btnExpo.TabIndex = 8;
            this.btnExpo.Text = "X^2";
            this.btnExpo.UseVisualStyleBackColor = true;
            this.btnExpo.Click += new System.EventHandler(this.btnExpo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(71, 88);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 33);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.Location = new System.Drawing.Point(120, 88);
            this.btnDEL.Margin = new System.Windows.Forms.Padding(1);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(45, 33);
            this.btnDEL.TabIndex = 10;
            this.btnDEL.Text = "DEL";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(167, 88);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(1);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(47, 33);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(71, 123);
            this.btnEight.Margin = new System.Windows.Forms.Padding(1);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(47, 33);
            this.btnEight.TabIndex = 14;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(120, 123);
            this.btnNine.Margin = new System.Windows.Forms.Padding(1);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(45, 33);
            this.btnNine.TabIndex = 13;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(167, 123);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(1);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(47, 33);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(71, 159);
            this.btnFive.Margin = new System.Windows.Forms.Padding(1);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(47, 33);
            this.btnFive.TabIndex = 17;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(120, 159);
            this.btnSix.Margin = new System.Windows.Forms.Padding(1);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(45, 33);
            this.btnSix.TabIndex = 16;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnNegitive
            // 
            this.btnNegitive.Location = new System.Drawing.Point(167, 159);
            this.btnNegitive.Margin = new System.Windows.Forms.Padding(1);
            this.btnNegitive.Name = "btnNegitive";
            this.btnNegitive.Size = new System.Drawing.Size(47, 33);
            this.btnNegitive.TabIndex = 15;
            this.btnNegitive.Text = "-";
            this.btnNegitive.UseVisualStyleBackColor = true;
            this.btnNegitive.Click += new System.EventHandler(this.btnNegitive_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(71, 194);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(1);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(47, 33);
            this.btnTwo.TabIndex = 20;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(120, 194);
            this.btnThree.Margin = new System.Windows.Forms.Padding(1);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(45, 33);
            this.btnThree.TabIndex = 19;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(167, 194);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(1);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(47, 33);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(71, 230);
            this.btnZero.Margin = new System.Windows.Forms.Padding(1);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(47, 33);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(118, 230);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(1);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(47, 33);
            this.btnDecimal.TabIndex = 22;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(167, 230);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(1);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(47, 33);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(22, 21);
            this.Display.Margin = new System.Windows.Forms.Padding(1);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(192, 20);
            this.Display.TabIndex = 24;
            // 
            // lblPart2
            // 
            this.lblPart2.AutoSize = true;
            this.lblPart2.Location = new System.Drawing.Point(22, 7);
            this.lblPart2.Name = "lblPart2";
            this.lblPart2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPart2.Size = new System.Drawing.Size(13, 13);
            this.lblPart2.TabIndex = 26;
            this.lblPart2.Text = "L";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 287);
            this.Controls.Add(this.lblPart2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNegitive);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnExpo);
            this.Controls.Add(this.btnXYExpo);
            this.Controls.Add(this.btnFraction);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnPosNeg);
            this.Controls.Add(this.btnSQRT);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Nathans Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnSQRT;
        private System.Windows.Forms.Button btnPosNeg;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnFraction;
        private System.Windows.Forms.Button btnXYExpo;
        private System.Windows.Forms.Button btnExpo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNegitive;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Label lblPart2;
    }
}

