using System;

namespace lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Show();
            }
        }
        public static void Show()
        {
            Console.WriteLine("");
            Console.WriteLine("Введите имя: ");
            Person.name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            try
            {
                Person.age = Convert.ToInt32(Console.ReadLine());
                WorkOrStudy ws1 = new WorkOrStudy();
            }
            catch
            {
                Console.WriteLine("Проверьте на правильность ввод возраста");
                Show();
            }
        }
    }
}
