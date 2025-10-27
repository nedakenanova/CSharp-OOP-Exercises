using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C015_AbstractShapeClass
{
    internal abstract class Shape
    {
        public string Name {  get; set; }
        protected Shape(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "Name cannot be null or empty");

            Name = name;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();

    }
}
