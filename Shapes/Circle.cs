using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        private readonly double radius;

        public double Area => Math.PI * radius * radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
    }
}
