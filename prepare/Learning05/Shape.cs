using System;

public abstract class Shape
{
    private string _color;
    private string _shapeName;


    public Shape(string color)
    {
        _color = color;

    }

    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();

    public string GetName()
    {
        return _shapeName;
    }
    public void SetName(string name)
    {
        _shapeName = name;
    }

    public void GetShapeInfo()
    {
        Console.WriteLine($"The Color of your {_shapeName} is {GetColor()} and its area is {GetArea()}");
    }

}