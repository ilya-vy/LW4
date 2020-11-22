using System;

namespace ЛБ4_З1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseclass = new BaseClass();
            DerivedClass derivedclass = new DerivedClass();

            baseclass.argument = "POWER";

            baseclass.ShowArgumentInfo(baseclass.argument);
            derivedclass.ShowArgumentInfo(baseclass.argument);

            Console.ReadKey();
        }
    }
}