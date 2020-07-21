using System;

namespace Calculator_new
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var control = new Control();

            var firstValue = control.InputFirstValue();

            var secondValue = control.InputSecondValue();

            var command = control.InputCommand();

            var manage = new Manage();

            manage.Reset(firstValue, secondValue, command);
        }
    }
}
