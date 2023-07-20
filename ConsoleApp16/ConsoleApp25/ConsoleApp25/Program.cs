using System;

abstract class Shape
{
    public abstract int GetArea();

    public int GetShape()
    {
        Console.WriteLine("helloo bye");
        return 0;
    }
}

class Square : Shape
{
    private int _side;
    public override int GetArea() => _side * _side;
    public int GetShape()
    {
        Console.WriteLine("helloo 123456789bye");
        return 0;
    }

    static void Main()
    {
        Square sq = new Square();
        Console.WriteLine($"Area of the square = {sq.GetArea()}");
        sq.GetShape();
    }
}
