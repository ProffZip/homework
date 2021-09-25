using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your info here:\nLogin:");
            string login = Console.ReadLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            User user = new User(login, name, lastname, age);
            user.UserInfo(user);

        }
    }
}
