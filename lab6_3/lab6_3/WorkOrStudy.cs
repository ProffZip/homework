using System;

public class WorkOrStudy : Person
{
    public WorkOrStudy()
    {
        Do();
    }
    public override void Do()
    {
        if (age >= 18)
        {
            Console.Write(name);
            IWhatDo.Work();
        }
        else if (age < 18)
        {
            Console.Write(name);
            IWhatDo.Study();
        }
    }
}
