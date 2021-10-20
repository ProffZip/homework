using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your license code");
            string code = Console.ReadLine();
            ApplicationLicense license = new ApplicationLicense();
            license.LicenseCode = code;
            license.LicenseCheck(license);
            Console.ReadLine();

        }
    }
}
