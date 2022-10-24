using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Rectangle
    {
        static public double GetSquare(double r)
        {
            return Math.PI*(r*r);
        }
        static public double GetPerimeter(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetPoint(double r, double x, double y)
        {
            return Math.Sqrt(((x * x) + (y * y)));
        }
    }
}
