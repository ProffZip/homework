using System;

public class Converter
{

    private double _usd;
    private double _eur;
    private double _rub;
    public double USD
    {
        get
        {
            return _usd;
        }
    }
    public double EUR
    {
        get
        {
            return _eur;
        }
    }
    public double RUB
    {
        get
        {
            return _rub;
        }
    }
    
    
    public Converter(double usd, double eur, double rub )
    {
        _usd = usd;
        _eur = eur;
        _rub = rub;
       
    }
    public void ConvUAH(int a, int b, double sum, Converter converter)
    {
        switch (a)
        {
            case 1:// convert uah INTO smth
                switch (b)//decide into what
                {
                    case 1:
                        double UahUsd = sum / converter.USD;
                        Console.WriteLine(sum + "UAH is"+UahUsd+"USD");
                        Console.ReadLine();
                        break;
                    case 2:
                        double UahEur = sum / converter.EUR;
                        Console.WriteLine(sum + "UAH is"+ UahEur+"EUR" );
                        Console.ReadLine();
                        break;
                    case 3:
                        double UahRub = sum / converter.RUB;
                        Console.WriteLine(sum + "UAH is" + UahRub+"RUB"  );
                        Console.ReadLine();
                        break;
                }
                break;
            case 2:// convert smth INTO uah
                switch (b)//decide what
                {
                    case 1:
                        double UsdUah = sum * converter.USD;
                        Console.WriteLine(sum + "USD is"+UsdUah+"UAH");
                        Console.ReadLine();
                        break;
                    case 2:
                        double EurUah = sum * converter.EUR;
                        Console.WriteLine(sum + "EUR is"+EurUah+"UAH");
                        Console.ReadLine();
                        break;
                    case 3:
                        double RubUah = sum * converter.USD;
                        Console.WriteLine(sum + "RUB is"+RubUah+"UAH");
                        Console.ReadLine();
                        break;
                }
                break;

        }

    }

}
