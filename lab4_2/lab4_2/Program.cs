using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B example = new B();
            B.Arg();
            A exampleA = new A(example);
            exampleA.Display();
        }
    }
}
