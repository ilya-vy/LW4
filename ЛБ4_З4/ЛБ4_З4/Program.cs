using System;

namespace ЛБ4_З4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ программы: ");
            Scan scan = new Scan(Console.ReadLine());

            scan.AllowTrial();
            scan.AllowCommon();
            scan.AllowPro();

            Console.WriteLine("Выберите действие: q - quickscan|d - deepscan ");
            string action = Console.ReadLine();
            if (action == "q") scan.CheckLicenseAndStartQuickScan();
            if (action == "d") scan.CheckLicenseAndStartDeepScan();

            Console.WriteLine("Press any key to exit: ");

            Console.ReadKey();
        }
    }
}
