using System;

public class Title
{
    private string _title;
    public string BookTitle
    {
        get
        {
            return _title;
        }
        set
        {
            this._title = value;
        }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Here you can read the:" + '\n'+BookTitle);
        Console.ResetColor();
    }
}
