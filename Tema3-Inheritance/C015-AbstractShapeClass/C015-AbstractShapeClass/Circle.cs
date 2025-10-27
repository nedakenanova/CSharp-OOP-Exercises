using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C015_AbstractShapeClass
{
    internal class Circle:Shape
    { private double Radius {  get; set; }
        public Circle(string name,double radius):base(name)
        {
            Radius = radius;
            if (radius <= 0)
            {
                throw new ArgumentException("The radius is not proper",nameof(radius));
            }


        }
        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;

    }
}
