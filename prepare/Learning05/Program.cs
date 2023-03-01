using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Shape> _myShapeList = new List<Shape>();
        Square _mySquare = new Square("Red", 20);
        Circle _myCircle = new Circle("Blue", 15);
        Rectangle _myRectangle = new Rectangle("Green", 15, 20);
        _myShapeList.Add(_mySquare);
        _myShapeList.Add(_myCircle);
        _myShapeList.Add(_myRectangle);
        
        Console.Clear();
        foreach (Shape shape in _myShapeList)
        {
            shape.GetShapeInfo();
        }
    }
}