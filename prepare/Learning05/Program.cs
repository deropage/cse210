using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square _mySquare = new Square("Red", 20);
        Circle _myCircle = new Circle("Blue", 15);
        Rectangle _myRectangle = new Rectangle("Green", 15, 20);

        _mySquare.GetShapeInfo();
        _myCircle.GetShapeInfo();
        _myRectangle.GetShapeInfo();
    }
}