using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : IShape
    {
        public readonly double AB = 0;
        public readonly double BC = 0;
        public readonly double AC = 0;

        public bool IsTriangleRectangular => Math.Pow(AC,2) == Math.Pow(AB, 2) + Math.Pow(BC, 2) || Math.Pow(AB, 2) == Math.Pow(AC, 2) + Math.Pow(BC, 2) ||
             Math.Pow(BC, 2) == Math.Pow(AC, 2) + Math.Pow(AB, 2);

        public double Area
        {
            get
            {
                var p = (AB + BC + AC) / 2;
                return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            }
        }

        public Triangle(double a, double b, double c)
        {
            AB = a;
            BC = b;
            AC = c;
        }
    }
}
