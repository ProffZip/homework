using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 02217;
            address.House = 32;
            address.Apartment = 69;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Kyoto";
            address.WriteAddress();
            Console.ReadKey();

        }

       
    }
}
