using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount of points of figure(3-5)");
            int n = Console.Read()-48;// я искренне не знаю откуда оно взяло 48 но оно его почему-то добавляет к значению n
            Point[] points= new Point[n]; 
                Console.WriteLine("enter "+n+" points {x(enter)y(enter)name(enter)}\nplease notice: you should enter the points in the right order, \nthe way they are in your figure");
            for (int i = 0; i < n; i++ )//по сути точки должны быть введены по/против часовой
            {                           //иначе оно начнёт считать отрезки в том порядке в котором вы его вводили
                Console.WriteLine("X:"); //и получится звезда а не пятиугольник
                Console.ReadLine();
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y:");
                
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name:");
               
                string name = Console.ReadLine();
                Point point = new Point(x,y,name);
                points[i] = point;
            }
            
            
            double LengthSide(Point a, Point b)
            {
                double Lengt = Math.Sqrt((b.X - a.X) ^ 2 + (b.Y - a.Y) ^ 2);
                return Lengt;
            }

            
            void PerimeterCalculator()
            {
                double perimeter = 0;
                for (int i = 0; i < n-1; i++)
                {
                    perimeter += LengthSide(points[i],points[i+1]);
                }

                perimeter += LengthSide(points[n-2], points[0]);//это крч растояние от последней до первой точки
                Console.WriteLine(perimeter);

            }

            switch (points.Length)//прошу не убивайте это единственное как я придумал перевести массив в аргументы
            {
                case 3:
                    Figure figure3 = new Figure(points[0], points[1], points[2]);
                    Console.WriteLine("The perimeter of "+ figure3.FigureName+" is");
                    PerimeterCalculator();
                    Console.ReadLine();
                    break;
                case 4:
                    Figure figure4 = new Figure(points[0], points[1], points[2], points[3]);
                    Console.WriteLine("The perimeter of " + figure4.FigureName + " is");
                    PerimeterCalculator();
                    Console.ReadLine();
                    break;
                case 5:
                    Figure figure5 = new Figure(points[0], points[1], points[2], points[3], points[4]);
                    Console.WriteLine("The perimeter of " + figure5.FigureName + " is");
                    PerimeterCalculator();
                    Console.ReadLine();
                    break;


            }






        }
        
    }
}
