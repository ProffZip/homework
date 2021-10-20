using System;
using System.Diagnostics;

public class A
{
    public A(B b)
    {
        str = B.argument;
    }
    private string str;
    public void Display() 
    {
        B1 example1 = new B1();
        B2 example2 = new B2();
        B3 example3 = new B3();
        Trace.WriteLine(B1.argument1);
        Trace.WriteLine(B2.argument2);
        Trace.WriteLine(B3.argument3);


    }

}
