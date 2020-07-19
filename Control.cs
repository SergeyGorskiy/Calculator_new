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

                if (double.TryParse(input, out double secondValue))
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

        Calculator calculator = new Calculator();

        public double Calculate(double firstValue, double secondValue, string command)
        {
            while (true)
            {
                if (command == "+")
                {
                    var result = calculator.Sum(firstValue, secondValue);
                    return result;
                }
                if (command == "-")
                {
                    var result = calculator.Dif(firstValue, secondValue);
                    return result;
                }
                if (command == "*")
                {
                    var result = calculator.Mult(firstValue, secondValue);
                    return result;
                }
                if (command == "/")
                {
                    var result = calculator.Div(firstValue, secondValue);
                    return result;
                }

            }

        }

    }
}
