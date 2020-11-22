using System;
using System.Collections.Generic;
using System.Text;

namespace ЛБ4_З4
{
    class ApplicationLicense
    {
        public string LicenceKey;
        public ApplicationLicense(string licenceKey)
        {
            LicenceKey = licenceKey;
        }
        public bool AllowCommon()
        {
            if (LicenceKey == "")
            {
                Console.WriteLine("Бесплатная версия");
                return true;
            }
            else return false;
        }
        public bool AllowTrial()
        {
            if (LicenceKey == "trial")
            {
                Console.WriteLine("Пробная версия");
                return true;
            }
            else return false;
        }
        public bool AllowPro()
        {
            if (LicenceKey == "pro")
            {
                Console.WriteLine("Платная версия");
                return true;
            }
            else return false;
        }
    }
}
