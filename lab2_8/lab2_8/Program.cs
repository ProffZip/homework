using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your order info");
            Console.WriteLine("Account id:");
            int account = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Customer name:");
            string customer = Console.ReadLine();

            Console.WriteLine("Povider of goods:");
            string provider = Console.ReadLine();

            Invoice invoice = new Invoice(account, customer, provider);

            Console.WriteLine("Please select the goods:\nCar, phone, bike");
            invoice.Article = Console.ReadLine();
            Console.WriteLine("Please enter the quantity:");
            invoice.Quantity = Convert.ToInt32( Console.ReadLine());
            invoice.InvoiceInfo(invoice);
            Console.ReadLine();
        }
    }
}
