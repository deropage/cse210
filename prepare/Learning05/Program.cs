using System;

class Program
{
    static void Main(string[] args)
    {
        Square _mySquare = new Square("Red",20);
        Console.Write($"The Color of your square is {_mySquare.GetColor()} and its area is {_mySquare.GetArea()}");
    }
}