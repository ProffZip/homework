using System;
using System.Diagnostics;


public class Person
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public Person()
    {
        name = "Johnny";
    }
}

public class A : Person
{
    private string surname;

    public string Surname
    {
        get
        {
            return surname;
        }
        set
        {
            surname = value;
        }
    }
    public A()
    {
        surname = "Joestar";
    }
}
public class B : A
{
    private int age;
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
    public B()
    {
        age = 15;
    }

    public void Show()
    {
        Trace.WriteLine(Name);
        Trace.WriteLine(Surname);
        Trace.WriteLine(Age);
    }
}