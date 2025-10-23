using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO10_ShapesClass
{
    internal  class Shape
    {
        public string Name { get; set; }
      public   virtual double GetArea()
      {
            return 0;
      }
        public virtual double GetPerimeter() { return 0; }
        public Shape(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException($"Name cannot be null");
            }
            Name = name;
        }


    }
}
