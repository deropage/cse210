using System;

class Circle : Shape
{
    private double _radius;
    public Circle (string color, double radius):base(color)
    {
        _radius = radius;
        SetName("Circle");
    }

    public override double GetArea()
    {
        return (Math.PI * Math.Pow(_radius,2));
    }

}