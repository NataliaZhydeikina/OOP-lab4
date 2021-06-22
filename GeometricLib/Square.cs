using System;

namespace GeometricLib
{
    public class Square:Shape
    {
        float a;
        public Square(float a)
        {
            this.a = a;
        }
        public override double area()
        {
            return Math.Round(Math.Pow(a, 2), 2);
        }
        public override double perimeter()
        {
            return Math.Round(4*a, 2);
        }
        public override string ToString()
        {
            return "square with side length " + a;
        }
    }
}
