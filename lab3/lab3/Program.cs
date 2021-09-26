using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple calculator \nwhere you can add(+), subtract(-) and multiply(*) two numbers\n\nYou can enter your expression in one line or like this: \nNum1-enter-Operator-enter-Num2");
        a:
            try
            {
                Console.WriteLine("\n\nPlease enter your expression:");
                string line = Console.ReadLine();
                try
                {
                    Calculator calculator = new Calculator(line);
                    calculator.Calculating(calculator);
                }
                catch(IndexOutOfRangeException)
                {
               
                    double line1 = Convert.ToDouble(line);
                    char action = Convert.ToChar(Console.ReadLine());
                    double line2 = Convert.ToDouble(Console.ReadLine());
                    switch (action)
                    {
                        case '+':
                            Console.WriteLine("Your sum is " + (line1 + line2));
                            break;
                        case '-':
                            Console.WriteLine("Your difference is " + (line1 - line2));
                            break;
                        case '*':
                            Console.WriteLine("Your product is " + (line1 * line2));
                            break;
                        default:
                            Console.WriteLine("You've entered the wrong operator");
                            goto a;
                    }

                }
            
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a correct expression");
                goto a;
            }
            Console.ReadLine();
        }

    }
}
