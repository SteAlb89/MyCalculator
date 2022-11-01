using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorProject
{
    // TODO: if the first digit is 0 clear or replace with next digit if not also 0  
    // TODO : implement the red buttons 
    // TODO : if you divide a number by 0 , print Error
    public partial class Form1 : Form
    {
        private char sign;
        private double firstNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOneClick(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void ButtonPunct_Click(object sender, EventArgs e)
        {
            // If the display doesn't contain point
            if (!display.Text.Contains('.'))
            {
                display.Text += ".";
            }
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (display.Text[0] == '0')
            {
                display.Text = "0";
            }
            else
            {
                display.Text += "0";
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '+';
            display.Text += "+";
            display.Clear();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '-';
            display.Text += "-";
            display.Clear();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case '+':
                   display.Text = (firstNumber + Convert.ToDouble(display.Text)).ToString();
                    break;
                case '-':
                    display.Text = (firstNumber - Convert.ToDouble(display.Text)).ToString();
                    break;
                case '*':
                    display.Text = (firstNumber * Convert.ToDouble(display.Text)).ToString();
                    break;
                case 'v':
                    display.Text = (Math.Sqrt(firstNumber)).ToString();
                    break;
                case '^':
                    display.Text = Math.Pow(firstNumber,Convert.ToDouble(display.Text)).ToString();
                    break;
                case '/':
                    if (display.Text.Equals("0"))
                    {
                        display.Text = "Error";
                    }
                    else
                    {
                        display.Text = (firstNumber / Convert.ToDouble(display.Text)).ToString();
                    }
                    break;
                    
            }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            
            firstNumber = Convert.ToDouble(display.Text);
            sign = '/';
            display.Text += "/";
            display.Clear();
           
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '*';
            display.Text += "*";
            display.Clear();
        }

        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = 'v';
            display.Text += "v";
            display.Clear();
        }

        private void ButtonToThePowerOf_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '^';
            display.Text += "^";
            display.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
