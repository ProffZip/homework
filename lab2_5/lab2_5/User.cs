using System;

public class User
{
    private string _login;
    private string _name;
    private string _lastname;
    private int _age;
    private string _date;
    public string Login
    {
        get
        {
            return _login;
        }
        set
        {
            this._login = value;
        }
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            this._name = value;
        }
    }
    public string LastName
    {
        get
        {
            return _lastname;
        }
        set
        {
            this._lastname = value;
        }
    }
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            this._age = value;
        }
    }
    public string Date
    {
        get
        {
            return _date;
        }
    }

    public User(string login, string name, string lastname, int age)
    {
        _login = login;
        _name = name;
        _lastname = lastname;
        _age = age;
        _date = DateTime.Today.ToString("D");
    }

    public void UserInfo(User user)
    {
        Console.WriteLine("Current info is:\nLogin:"+user.Login+"\nName:"+user.Name+ "\nLast Name:" + user.LastName+ "\nAge:" + user.Age+ "\nDate of creation:" + user.Date);
        Console.ReadLine();
        
    }
}
