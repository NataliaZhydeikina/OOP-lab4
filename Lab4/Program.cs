using System;
using GeometricLib;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(50);
            Console.WriteLine("circle: "+circle1);
            Console.WriteLine("circle's area: "+circle1.area());
            Console.WriteLine("circle's perimeter: " + circle1.perimeter());
            Square square1 = new Square(25);
            Console.WriteLine("square: " + square1);
            Console.WriteLine("square's area: " + square1.area());
            Console.WriteLine("square's perimeter: " + square1.perimeter());
        }
    }
}
