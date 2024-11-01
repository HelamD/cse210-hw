using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(4);
        square._color = "Red";
        square.GetArea();
    }
}