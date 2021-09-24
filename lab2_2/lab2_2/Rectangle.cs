using System;

public class Rectangle
{
    private double _side1, _side2;

	public Rectangle(double Side1, double Side2)
    {
        _side1 = Side1;
        _side2 = Side2;
    }
    public double Area
    {
        get
        {
            return AreaCalculator();
        }
    }
    public double Perimeter
    {
        get
        {
            return PerimeterCalculator();
        }
    }

    public double AreaCalculator()
    {
        double Area = _side1 * _side2;
        return Area;
    }
    public double PerimeterCalculator()
    {
        double Perimeter = (_side1 + _side2)*2;
        return Perimeter;
    }
    

}
