using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO10_ShapesClass
{
    internal class Circle:Shape
    {
        public double Radius {  get; set; }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public Circle(string name, double radius) :base (name)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("Radius cannot be 0 or smaller", nameof(radius));
            }
            Radius = radius;
        }
    }
}
