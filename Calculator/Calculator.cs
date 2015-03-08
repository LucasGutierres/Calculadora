using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {

        public double add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double sub(double num1, double num2)
        {

            return num1 - num2;
        }

        public double multi(double num1, double num2)
        {

            return num1 * num2;
        }

        public double div(double num1, double num2)
        {

            return num1 / num2;
        }

        public double sqrt(double num1)
        {

            return Math.Sqrt(num1);
        }

        public double porce(double num1, double num2)
        {

            return num1 / 100 * num2;
        }

        public double restDiv(double num1, double num2)
        {

            return num1 % num2;
        }

        public double poten(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public double sin(double num1) {

            return Math.Sin(num1);
        }

        public double cos(double num1)
        {

            return Math.Cos(num1);
        }

        public double tan(double num1)
        {

            return Math.Tan(num1);
        }
    }
}
