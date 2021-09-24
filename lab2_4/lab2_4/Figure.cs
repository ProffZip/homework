using System;
using System.Runtime.InteropServices;

public class Figure
{
    private string _FigureName;

    public string FigureName
    {
        get
        {
            return _FigureName;
        }
    }
    public Figure(Point a, Point b, Point c)
    {
        _FigureName = a.Name + b.Name + c.Name;
    }
    public Figure(Point a, Point b, Point c, Point d)
    {
        _FigureName = a.Name + b.Name + c.Name + d.Name;
    }
    public Figure(Point a, Point b, Point c, Point d, Point e)
    {
        _FigureName = a.Name + b.Name + c.Name + d.Name + e.Name;
    }

   
    
}
