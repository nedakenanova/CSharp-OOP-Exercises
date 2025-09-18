using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO6_RectangleClass
{
    internal class Rectangle
    {
        public double Width {  get; set; }
        public double  Height { get; set; } 
        public Rectangle(double width, double height)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException(nameof(width), "Width must be > 0");
            if (height <= 0) throw new ArgumentOutOfRangeException(nameof(height), "Height must be > 0");
            Width = width;
            Height = height;
        }
        public double GetArea()
        {
            return Width * Height;
        }
        public double GetPerimeter()
        {
            double p = (2 * Width) + (Height * 2);
            return p;
        }
        public override string ToString()
        {
            return $"Rectangle: Width = {Width}, Height = {Height}, Area = {GetArea()}, Perimeter ={GetPerimeter()}";
        }
    }
}
