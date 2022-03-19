using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";


        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }
        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }



        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void svenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {

            function = '*';
            first = userInput;
            userInput = "";
        }

        private void dvideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void ACbutton_Click(object sender, EventArgs e)
        {   
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0"; 
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secNum;
        
            double.TryParse(first, out firstNum);
            double.TryParse(second, out secNum);


            this.calculatorDisplay.Text = "";
            this.userInput =String.Empty;
            this.first = String.Empty;
            this.second = String.Empty;


            // Plus
            if (function == '+')
            {
                result = firstNum + secNum;
                calculatorDisplay.Text = result.ToString();
            }

            // Minus
            else if (function == '-')
            {
                result = firstNum - secNum;
                calculatorDisplay.Text = result.ToString();
            }

            // Divide
            else if (function == '/')
            {
                if (secNum == 0)
                {
                    calculatorDisplay.Text = "Cannot divide by zero";
                }
                else
                {
                    result = firstNum / secNum;
                    calculatorDisplay.Text = result.ToString();
                }

            }
            // Multiply
            else if (function == '*')
            {
                result = firstNum * secNum;
                calculatorDisplay.Text = result.ToString();
            }

            else
            {
                calculatorDisplay.Text = "0";
            }
        
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";

        }
        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += ".";
            calculatorDisplay.Text += userInput;
        }
    }
}
