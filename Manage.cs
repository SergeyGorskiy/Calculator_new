using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_new
{
    public class Manage
    {
        private readonly Control _control = new Control();

        public double Reset(double firstValue, double secondValue, string command)
        {
            var result = _control.Calculate(firstValue, secondValue, command);

            Console.WriteLine($"\nРезультат операции: {result}");

            while (true)
            {
                Console.WriteLine("\nХотите совершить действие с результатом, нажмите: 1. " +
                 "\n\nХотите завершить - нажмите любую клавишу.");

                var command1 = Console.ReadLine();

                if (command1 == "1")
                {
                    Console.WriteLine($"Число №1: \n{result}");

                    var secondValue2 = _control.InputSecondValue();

                    var command2 = _control.InputCommand();

                    var result2 = _control.Calculate(result, secondValue2, command2);

                    result = result2;

                    Console.WriteLine($"\nРезультат операции: {result}");
                }
                else
                {
                    Console.WriteLine("\nСпасибо. Всего хорошего.");

                    return 0;
                }
            }
        }
    }
}
