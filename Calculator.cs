using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_new
{
    public class Calculator
    {
        public double Sum(double firstValue, double secondValue) => firstValue + secondValue;
        public double Dif(double firstValue, double secondValue) => firstValue - secondValue;
        public double Mult(double firstValue, double secondValue) => firstValue * secondValue;
        public double Div(double firstValue, double secondValue) => firstValue / secondValue;
    }
}
