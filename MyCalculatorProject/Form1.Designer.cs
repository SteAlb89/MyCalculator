namespace MyCalculatorProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.display = new System.Windows.Forms.TextBox();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSplit = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.ButtonMultiplication = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonPunct = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonToThePowerOf = new System.Windows.Forms.Button();
            this.ButtonSquareRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.display.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.display.Size = new System.Drawing.Size(460, 63);
            this.display.TabIndex = 0;
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.BackColor = System.Drawing.Color.DimGray;
            this.ButtonEqual.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonEqual.Location = new System.Drawing.Point(244, 457);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(110, 80);
            this.ButtonEqual.TabIndex = 1;
            this.ButtonEqual.Text = "=";
            this.ButtonEqual.UseVisualStyleBackColor = false;
            this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.DimGray;
            this.ButtonClear.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonClear.Location = new System.Drawing.Point(244, 99);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(110, 80);
            this.ButtonClear.TabIndex = 3;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSplit
            // 
            this.ButtonSplit.BackColor = System.Drawing.Color.DimGray;
            this.ButtonSplit.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonSplit.Location = new System.Drawing.Point(362, 99);
            this.ButtonSplit.Name = "ButtonSplit";
            this.ButtonSplit.Size = new System.Drawing.Size(110, 80);
            this.ButtonSplit.TabIndex = 4;
            this.ButtonSplit.Text = "/";
            this.ButtonSplit.UseVisualStyleBackColor = false;
            this.ButtonSplit.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.Color.DimGray;
            this.ButtonMinus.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonMinus.Location = new System.Drawing.Point(362, 187);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(110, 80);
            this.ButtonMinus.TabIndex = 8;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonNine.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonNine.Location = new System.Drawing.Point(244, 187);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(110, 80);
            this.ButtonNine.TabIndex = 7;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = false;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonEight.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonEight.Location = new System.Drawing.Point(128, 187);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(110, 80);
            this.ButtonEight.TabIndex = 6;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = false;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonSeven.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSeven.Location = new System.Drawing.Point(12, 187);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(110, 80);
            this.ButtonSeven.TabIndex = 5;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = false;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.Color.DimGray;
            this.ButtonPlus.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonPlus.Location = new System.Drawing.Point(362, 457);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(110, 80);
            this.ButtonPlus.TabIndex = 16;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonThree.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonThree.Location = new System.Drawing.Point(244, 366);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(110, 80);
            this.ButtonThree.TabIndex = 15;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = false;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonTwo.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonTwo.Location = new System.Drawing.Point(128, 366);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(110, 80);
            this.ButtonTwo.TabIndex = 14;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = false;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button12.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button12.Location = new System.Drawing.Point(12, 366);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(110, 80);
            this.button12.TabIndex = 13;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.ButtonOneClick);
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.BackColor = System.Drawing.Color.DimGray;
            this.ButtonMultiplication.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonMultiplication.Location = new System.Drawing.Point(362, 276);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(110, 80);
            this.ButtonMultiplication.TabIndex = 12;
            this.ButtonMultiplication.Text = "*";
            this.ButtonMultiplication.UseVisualStyleBackColor = false;
            this.ButtonMultiplication.Click += new System.EventHandler(this.ButtonMultiplication_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonSix.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonSix.Location = new System.Drawing.Point(244, 276);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(110, 80);
            this.ButtonSix.TabIndex = 11;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = false;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonFive.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonFive.Location = new System.Drawing.Point(128, 276);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(110, 80);
            this.ButtonFive.TabIndex = 10;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = false;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonFour.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonFour.Location = new System.Drawing.Point(12, 276);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(110, 80);
            this.ButtonFour.TabIndex = 9;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = false;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonPunct
            // 
            this.ButtonPunct.BackColor = System.Drawing.Color.DimGray;
            this.ButtonPunct.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonPunct.Location = new System.Drawing.Point(12, 100);
            this.ButtonPunct.Name = "ButtonPunct";
            this.ButtonPunct.Size = new System.Drawing.Size(110, 79);
            this.ButtonPunct.TabIndex = 19;
            this.ButtonPunct.Text = ".";
            this.ButtonPunct.UseVisualStyleBackColor = false;
            this.ButtonPunct.Click += new System.EventHandler(this.ButtonPunct_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonZero.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonZero.Location = new System.Drawing.Point(12, 457);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(226, 80);
            this.ButtonZero.TabIndex = 17;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonToThePowerOf
            // 
            this.ButtonToThePowerOf.BackColor = System.Drawing.Color.DimGray;
            this.ButtonToThePowerOf.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonToThePowerOf.ForeColor = System.Drawing.Color.Black;
            this.ButtonToThePowerOf.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonToThePowerOf.Location = new System.Drawing.Point(128, 100);
            this.ButtonToThePowerOf.Name = "ButtonToThePowerOf";
            this.ButtonToThePowerOf.Size = new System.Drawing.Size(110, 80);
            this.ButtonToThePowerOf.TabIndex = 20;
            this.ButtonToThePowerOf.Text = "^";
            this.ButtonToThePowerOf.UseVisualStyleBackColor = false;
            this.ButtonToThePowerOf.Click += new System.EventHandler(this.ButtonToThePowerOf_Click);
            // 
            // ButtonSquareRoot
            // 
            this.ButtonSquareRoot.BackColor = System.Drawing.Color.DimGray;
            this.ButtonSquareRoot.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonSquareRoot.ForeColor = System.Drawing.Color.Black;
            this.ButtonSquareRoot.Location = new System.Drawing.Point(362, 366);
            this.ButtonSquareRoot.Name = "ButtonSquareRoot";
            this.ButtonSquareRoot.Size = new System.Drawing.Size(110, 80);
            this.ButtonSquareRoot.TabIndex = 21;
            this.ButtonSquareRoot.Text = "v";
            this.ButtonSquareRoot.UseVisualStyleBackColor = false;
            this.ButtonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 543);
            this.Controls.Add(this.ButtonSquareRoot);
            this.Controls.Add(this.ButtonToThePowerOf);
            this.Controls.Add(this.ButtonPunct);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.ButtonMultiplication);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonNine);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.ButtonSeven);
            this.Controls.Add(this.ButtonSplit);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonEqual);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stefan Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSplit;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button ButtonMultiplication;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonPunct;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonToThePowerOf;
        private System.Windows.Forms.Button ButtonSquareRoot;
    }
}

