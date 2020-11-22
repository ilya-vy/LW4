using System;

namespace ЛБ4_З1
{
    class BaseClass
    {
        public string argument;
        public virtual void ShowArgumentInfo(string argument)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Argument value: " + argument + " Argument type: " + argument.GetType());
        }
    }
}
