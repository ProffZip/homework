using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your surname, than name:");
            string surname =Console.ReadLine();
            string name = Console.ReadLine();
            Employee employee = new Employee(surname, name);
            Console.WriteLine("Please enter your position(worker, manager, director):");
            employee.Pos = Console.ReadLine();
            Console.WriteLine("Please enter your experience in full years:");
            employee.Exp = Convert.ToDouble( Console.ReadLine());
            employee.EmployeeInfo(employee);
            Console.ReadLine();

        }
    }
}
