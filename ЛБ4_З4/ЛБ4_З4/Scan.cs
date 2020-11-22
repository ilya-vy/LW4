using System;
using System.Threading;

namespace ЛБ4_З4
{
    class Scan : ApplicationLicense
    {
        public Scan(string licenceKey) : base(licenceKey)
        {

        }
        public void CheckLicenseAndStartQuickScan()
        {
            if (AllowTrial() == true || AllowPro() == true)
            {
                Console.Write("Quick scanning was started ");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(300);
                    Console.Write(".");
                }
                Console.WriteLine(" There are no infected files");
            }
            else Console.WriteLine("To start Quick you should have the TRIAL or PRO version");
        }
        public void CheckLicenseAndStartDeepScan()
        {
            if (AllowPro() == true)
            {
                Console.WriteLine("Deep scanning was started ");

                Console.WriteLine("\n Gate 1 ");
                for (int i = 0; i < 12; i++)
                {
                    Thread.Sleep(200);
                    Console.Write(".");
                }
                Console.WriteLine("\n Gate 2 ");
                for (int i = 0; i < 12; i++)
                {
                    Thread.Sleep(50);
                    Console.Write(".");
                }
                Console.WriteLine("\n Gate 3 ");
                for (int i = 0; i < 12; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(".");
                }
                Console.WriteLine("\n Gate 4 ");
                for (int i = 0; i < 12; i++)
                {
                    Thread.Sleep(250);
                    Console.Write(".");
                }
                Console.WriteLine("\n There are no infected files");
            }
            else Console.WriteLine("To start DEEP SCAN you should have the PRO version");
        }
    }
}
