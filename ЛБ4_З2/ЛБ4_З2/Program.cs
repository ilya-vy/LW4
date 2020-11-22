using System;
using System.Diagnostics;

namespace ЛБ4_З2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClassB baseclassb = new BaseClassB();
            DerivedClassB_1 derivedClassB_1 = new DerivedClassB_1();
            DerivedClassB_2 derivedClassB_2 = new DerivedClassB_2();
            DerivedClassB_3 derivedClassB_3 = new DerivedClassB_3();

            Console.WriteLine("Enter argument 1 value: ");
            baseclassb.Arg1 = Console.ReadLine();

            Console.WriteLine("Enter argument 2 value: ");
            baseclassb.Arg2 = Console.ReadLine();

            baseclassb.ShowArgInfo();
            derivedClassB_1.ShowArgInfo();
            derivedClassB_2.ShowArgInfo();
            derivedClassB_3.ShowArgInfo();

            Console.ReadKey();
        }
    }
}
