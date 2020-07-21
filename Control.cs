using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_new
{
    public class Control
    {
        public double InputFirstValue()
        {
            while (true)
            {
                Console.WriteLine("Введите число №1: ");

                var input = Console.ReadLine();

                if (double.TryParse(input, out double firstValue))
                {
                    return firstValue;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
        }

        public double InputSecondValue()
        {
            while (true)
            {
                Console.WriteLine("Введите число №2: ");

                var input = Console.ReadLine();

                if (double.TryParse(input, out var secondValue))
                {
                    return secondValue;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
        }

        public string InputCommand()
        {
            while (true)
            {
                Console.WriteLine("Введите команду (+,-,*,/): ");
                var command = Console.ReadLine();

                if (command == "+" || command == "-" || command == "*" || command == "/")
                {
                    return command;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
        }

        private readonly Calculator _calculator = new Calculator();

        public double Calculate(double firstValue, double secondValue, string command)
        {
            while (true)
            {
                switch (command)
                {
                    case "+":
                    {
                        var result = _calculator.Sum(firstValue, secondValue);
                        return result;
                    }
                    case "-":
                    {
                        var result = _calculator.Dif(firstValue, secondValue);
                        return result;
                    }
                    case "*":
                    {
                        var result = _calculator.Mult(firstValue, secondValue);
                        return result;
                    }
                    case "/":
                    {
                        var result = _calculator.Div(firstValue, secondValue);
                        return result;
                    }
                }
            }

        }

    }
}
