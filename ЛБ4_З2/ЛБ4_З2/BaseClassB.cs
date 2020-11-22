using System;

namespace ЛБ4_З2
{
    class BaseClassB
    {
        public string Arg1;
        public string Arg2;
        public BaseClassB() { Arg1 = "Неизвестно"; Arg2 = "19"; }
        public virtual void ShowArgInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Argument value: " + Arg1 + " Argument type: " + Arg1.GetType());
        }
    }
}
