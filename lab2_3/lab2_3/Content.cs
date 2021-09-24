using System;

public class Content
{
    private string _content;
    public string BookContent
    {
        get
        {
            return _content;
        }
        set
        {
            this._content = value;
        }
    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Content:"+'\n'+BookContent);
        Console.ResetColor();
    }

}
