using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C015_AbstractShapeClass
{
    internal class Rectangle:Shape
    {
        public double Width {  get; set; }
        public double Height { get; set; }
        public Rectangle(string name,double width, double height):base(name)
        {
            if(width < 0 || height < 0)
            {
                throw new ArgumentException("The statements arent true");
            }
            Width = width;
            Height = height;
        }
        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => 2 * (Width + Height);

    }
}
