using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;
using System.Collections;

namespace Calculator
{
    public partial class Calculadora : Form
    {
        string operation;
        bool conta_ready = false;
        double num1 = 0;
        double num2 = 0;
        Calculator calc;

        public Calculadora()
        {
            InitializeComponent();
            Box.Text = "0";
            calc = new Calculator();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void numClick(object sender, EventArgs e)
        {
            if (conta_ready || Box.Text == "0")
                Box.Clear();

            conta_ready = false;
            Button NumClick = (Button)sender;
            Box.Text = Box.Text + NumClick.Text;
            operationShow.Text = operationShow.Text + NumClick.Text;

        }

        private void operatorClick(object sender, EventArgs e)
        {
            num2 = 0;
            num1 = 0;
            if (num1 != 0)
                num2 = Double.Parse(Box.Text);

            Button b = (Button)sender;
            operation = b.Text;
            num1 = Double.Parse(Box.Text);
            operationShow.Text = operationShow.Text + b.Text;

            if (num1 != 0 && num2 != 0)
            {
                switch (operation)
                {
                    case "+":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.add(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "-":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.sub(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "/":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.div(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "*":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.multi(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "%":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.porce(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "R":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.restDiv(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "^":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.poten(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                }
                conta_ready = false;
            }

            if (num1 != 0)
            {
                switch (operation)
                {
                    case "sen":
                        Box.Text = Convert.ToString(calc.sin(num1));
                        num1 = 0;
                        break;
                   
                    case "cos":
                        Box.Text = Convert.ToString(calc.cos(num1));
                        num1 = 0;
                        break;
                   
                    case "tan":
                        Box.Text = Convert.ToString(calc.tan(num1));
                        num1 = 0;
                        break;
                  
                    case "√":
                        Box.Text = Convert.ToString(calc.sqrt(num1));
                        num1 = 0;
                        break;
                }
                conta_ready = false;
            }
            conta_ready = true;
        }

        private void equalsClick(object sender, EventArgs e)
        {
            if (num1 != 0)
            {
                switch (operation)
                {
                    case "+":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.add(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "-":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.sub(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "/":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.div(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "*":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.multi(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "por":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.porce(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "%":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.restDiv(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                    case "^":
                        num2 = Double.Parse(Box.Text);
                        Box.Text = Convert.ToString(calc.poten(num1, num2));
                        num1 = 0;
                        num2 = 0;
                        break;
                }
                conta_ready = false;
            }
        }

        private void clearClick(object sender, EventArgs e)
        {
            Box.Text = "";
            operationShow.Text = string.Empty;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}