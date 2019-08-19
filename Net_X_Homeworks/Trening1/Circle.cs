using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    public class Circle
    {
        public const double PI = 3.1415926535;
        public double radius;

        public Circle()
        {
            radius = 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getLength(double radius)
        {
            return radius * 2 * PI;
        }

        public double getSquare(double radius)
        {
            return PI * radius * radius;
        }
    }
}
