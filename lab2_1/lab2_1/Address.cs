using System;

public class Address
{
    private int _index;

    public int Index
    {
        get
        {
            return _index;
        }
        set
        {
            this._index = value;
        }
    }

    private int _apartment;

    public int Apartment
    {
        get
        {
            return _apartment;
        }
        set
        {
            this._apartment = value;
        }
    }
    private int _house;

    public int House
    {
        get
        {
            return _house;
        }
        set
        {
            this._house = value;
        }
    }
    private string _country;

    public string Country
    {
        get
        {
            return _country;
        }
        set
        {
            this._country = value;
        }
    }
    private string _city;

    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            this._city = value;
        }
    }
    private string _street;

    public string Street
    {
        get
        {
            return _street;
        }
        set
        {
            this._street = value;
        }
    }
    public void WriteAddress()
    {
        Console.WriteLine($"Country: {_country}");
        Console.WriteLine($"Index: {_index}");
        Console.WriteLine($"City: {_city}");
        Console.WriteLine($"Street: {_street}");
        Console.WriteLine($"House: {_house}");
        Console.WriteLine($"Apartment: {_apartment}");
    }

}
