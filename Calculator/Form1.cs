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
        private double result;
        private string operation;
        private bool isOperationPerformed;

        public Calculator()
        {
            InitializeComponent();
            result = 0;
            operation = "";
            isOperationPerformed = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || isOperationPerformed)
                textBoxResult.Clear();
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                {
                    textBoxResult.Text = textBoxResult.Text + button.Text;
                }
            }
            else
                textBoxResult.Text = textBoxResult.Text + button.Text;
            isOperationPerformed = false;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                buttonEqual.PerformClick();
                operation = button.Text;
                labelCurrentOperation.Text = result + " " + button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(textBoxResult.Text);
                labelCurrentOperation.Text = result + " " + button.Text;
                isOperationPerformed = true;
            } 
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            result = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBoxResult.Text = (result + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (result - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (result * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (result / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
