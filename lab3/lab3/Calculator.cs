using System;

public class Calculator
{
	private string _line;
    private double[] _num;
    private char _action;

    public string Line
    {
        get
        {
            return _line;
        }
    }
    public char Action
    {
        get
        {
            return _action;
        }
    }

    public double[] Nums
    {
        get
        {
            return _num;
        }
        
    }

    public Calculator(string line)
    {
        _line = line;
        double[] Nums = new double[2];
        _num = Nums;
    }
    public void Calculating(Calculator calculator)
    {
        NumDivide(calculator);
        Count(calculator);
    }
    public void NumDivide(Calculator calculator)
    {
        string line = calculator.Line.Trim(' ', '=', '/', '|', '?', '!', 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z');
        string line1 = line.Replace('.', ',');
        string[] num = line1.Split('+', '*', '-');
        calculator.Nums[0] = Convert.ToDouble(num[0]);
        calculator.Nums[1] = Convert.ToDouble(num[1]);

    }
    public void Count(Calculator calculator)
    {
        if (calculator.Line.Contains("+"))
        {
            Console.WriteLine("Your sum is "+Plus(calculator));
        }
        else
        {
            if (calculator.Line.Contains("-"))
            {
                Console.WriteLine("Your difference is " + Minus(calculator));
            }
            else
            {
                if (calculator.Line.Contains("*"))
                {
                    Console.WriteLine("Your product is " + Mult(calculator));
                }
                else
                {
                    Console.WriteLine("You've entered the wrong operator, please restart");
                    
                }

            }
        }
        
    }

    public double Plus(Calculator calculator)
    {
        double sum = calculator.Nums[0] + calculator.Nums[1];
        return sum;
    }
    public double Minus(Calculator calculator)
    {
        double min = calculator.Nums[0] - calculator.Nums[1];
        return min;
    }
    public double Mult(Calculator calculator)
    {
        double mult = calculator.Nums[0] * calculator.Nums[1];
        return mult;
    }


}
