using System;

namespace Calculator_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Control control = new Control();

            var firstValue = control.InputFirstValue();

            var secondValue = control.InputSecondValue();

            var command = control.InputCommand();

            Manage manage = new Manage();

            var result = manage.Reset(firstValue, secondValue, command);
        }
    }
}
