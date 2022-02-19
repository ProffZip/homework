using App;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        static void Task1()
        {
            var stringList = new MyList<string>();
            stringList.Add("hello");
            stringList.Add("world");
            stringList.Add("olehh");
            Console.WriteLine(stringList.mass);
            var numberList = new MyList<int>();
            numberList.Add(2);
            numberList.Add(4);
            numberList.Add(8);
            Console.WriteLine(numberList.mass);
        }
        static void Task2()
        {
            var dictionary = new MyDictionary<string, int>();
            dictionary.Add("hello", 222);
            dictionary.Add("lorem ipsum", 555);
            Console.WriteLine(dictionary.mass);
            var dictionary2 = new MyDictionary<int, string>();
            dictionary2.Add(3535, "djhdhdhd");
            dictionary2.Add(3535, "lorem ipsum");
            Console.WriteLine(dictionary2.mass);
        }
        static void Task3()
        {
            var list = new MyList<string>();
            list.Add("hello");
            list.Add("world");
            list.Add("big");
            var elements = Container<string>.GetArray(list);
            string result = "";
            for (var i = 0; i < elements.Length; i++)
            {
                result += $" {elements[i]} ";
            }
            Console.WriteLine(result);
        }
        static void Task4()
        {
            Console.WriteLine(MyClass<int>.FacrotyMethod());
        }
       
    }
}
