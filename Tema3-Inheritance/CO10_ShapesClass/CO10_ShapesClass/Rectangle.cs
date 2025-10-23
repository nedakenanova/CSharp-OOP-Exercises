using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO10_ShapesClass
{
    internal class Rectangle:Shape
    {
        public double Width;
        public double Height;
        public override double GetArea()
        {
            return Width*Height;
        }
        public override double GetPerimeter()
        {
            return 2*(Width+Height);
        }
        public Rectangle(string name, double width, double height) : base(name) {
            if (width <= 0)
                throw new ArgumentException("Width must be greater than zero.", nameof(width));

            if (height <= 0)
                throw new ArgumentException("Height must be greater than zero.", nameof(height));

            Height = height;
        }
    }
}
