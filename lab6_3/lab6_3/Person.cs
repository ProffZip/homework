using System;

public abstract class Person : IWhatDo
{
    public static string name;
    public static int age;
    public abstract void Do();
}
