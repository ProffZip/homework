using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side1:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side2:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            rectangle.AreaCalculator();
            rectangle.PerimeterCalculator();
            Console.WriteLine("Area ="+ rectangle.Area);
            Console.WriteLine("Perimeter =" + rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
