namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonAns = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSeven.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(42, 120);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(100, 60);
            this.buttonSeven.TabIndex = 0;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEight.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.Location = new System.Drawing.Point(158, 120);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(100, 60);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonNine.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.Location = new System.Drawing.Point(275, 120);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(100, 60);
            this.buttonNine.TabIndex = 2;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPlus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(393, 120);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(100, 60);
            this.buttonPlus.TabIndex = 3;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonMinus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(510, 120);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(100, 60);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDivision.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(510, 197);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(100, 60);
            this.buttonDivision.TabIndex = 9;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonMulti.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulti.Location = new System.Drawing.Point(393, 197);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(100, 60);
            this.buttonMulti.TabIndex = 8;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = false;
            this.buttonMulti.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSix.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(275, 197);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(100, 60);
            this.buttonSix.TabIndex = 7;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonFive.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(158, 197);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(100, 60);
            this.buttonFive.TabIndex = 6;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonFour.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.Location = new System.Drawing.Point(42, 197);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(100, 60);
            this.buttonFour.TabIndex = 5;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonAC
            // 
            this.buttonAC.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAC.Location = new System.Drawing.Point(393, 274);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(100, 60);
            this.buttonAC.TabIndex = 13;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = false;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonThree.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.Location = new System.Drawing.Point(275, 274);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(100, 60);
            this.buttonThree.TabIndex = 12;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonTwo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(158, 274);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(100, 60);
            this.buttonTwo.TabIndex = 11;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEqual.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(510, 274);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(100, 136);
            this.buttonEqual.TabIndex = 19;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonAns
            // 
            this.buttonAns.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAns.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAns.Location = new System.Drawing.Point(393, 350);
            this.buttonAns.Name = "buttonAns";
            this.buttonAns.Size = new System.Drawing.Size(100, 60);
            this.buttonAns.TabIndex = 18;
            this.buttonAns.Text = "Ans";
            this.buttonAns.UseVisualStyleBackColor = false;
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPoint.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoint.Location = new System.Drawing.Point(275, 350);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(100, 60);
            this.buttonPoint.TabIndex = 17;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonZero.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(42, 350);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(216, 60);
            this.buttonZero.TabIndex = 15;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonOne.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(42, 274);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(100, 60);
            this.buttonOne.TabIndex = 10;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.Button_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(42, 55);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(568, 47);
            this.textBoxResult.TabIndex = 20;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.ForeColor = System.Drawing.Color.DimGray;
            this.labelCurrentOperation.Location = new System.Drawing.Point(42, 32);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 17);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Calculator
            // 
            this.AcceptButton = this.buttonOne;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(656, 422);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonAns);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonAC);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonAns;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

