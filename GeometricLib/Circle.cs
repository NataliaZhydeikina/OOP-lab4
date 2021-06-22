using System;

namespace GeometricLib
{
    public class Circle : Shape
    {
        float radius;
        public Circle(float r) {
            radius = r;
        }
        public override double area() {
            return Math.Round(Math.PI * Math.Pow(radius, 2),2);
        }
        public override double perimeter()
        {
            return Math.Round(2 * Math.PI * radius, 2);
        }
        public override string ToString()
        {
            return "circle with radius "+radius;
        }
    }
}
