using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C015_AbstractShapeClass
{
    internal class Triangle:Shape
    { 
        public double A {  get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(string name, double a, double b, double c) :base(name)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Invalid triangle sides");

            A = a;
            B = b;
            C = c;
        }
        public override double GetPerimeter() => A + B + C;
        public override double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

    }
}
