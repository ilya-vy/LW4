using System;

namespace ЛБ4_З1
{
    class DerivedClass : BaseClass
    {
        public override void ShowArgumentInfo(string argument)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Argument value: " + argument + " Argument type: " + argument.GetType());
        }
    }
}
