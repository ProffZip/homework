using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the exchange rate of currencies to UAH");

            Console.WriteLine("USD:");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("EUR:");
            double eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("RUB:");
            double rub = Convert.ToDouble(Console.ReadLine());

            Converter converter = new Converter(usd, eur, rub);

            Console.WriteLine("Do you want to convert UAH into smth(1) or smth into UAH(2)?");
            int a = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Which currency would you like to use?");

            Console.WriteLine("USD(1), EUR(2), RUB(3)");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the sum to convert");
            double sum = Convert.ToDouble(Console.ReadLine());

            converter.ConvUAH(a, b, sum, converter);

        }
    }
}
