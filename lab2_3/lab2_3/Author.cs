using System;

public class Author
{
    private string _author;
    public string BookAuthor
    {
        get
        {
            return _author;
        }
        set
        {
            this._author = value;
        }

    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("By:" + '\n'+BookAuthor);
        Console.ResetColor();
    }
}
