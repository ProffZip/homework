using System;
using System.Diagnostics;

public class Data
{
    private string _data;
	public Data(string str)
    {
        _data = str;
    } 
    public void DataType()
    {
        Trace.WriteLine("type STRING : " + _data);
        if (int.TryParse(_data, out int a))
        {
            Trace.WriteLine("type http://INT : "+a);
        }
        if (double.TryParse(_data, out double b))
        {
            Trace.WriteLine("type http://DOUBLE : " + b);
        }
        if (char.TryParse(_data, out char d))
        {
            Trace.WriteLine("type CHAR : " + d);
        }
        if (bool.TryParse(_data, out bool e))
        {
            Trace.WriteLine("type BOOL : " + e);
        }
        if (byte.TryParse(_data, out byte f))
        {
            Trace.WriteLine("type http://BYTE : " + f);
        }

    }
}
