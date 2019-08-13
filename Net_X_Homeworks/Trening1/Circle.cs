using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    public class Circle
    {
        public const double PI = Math.PI;
        public double radius;

        public Circle()
        {
            radius = 0;
        }

        public Circle(double _radius)
        {
            this.radius = _radius;
        }

        public double getLength(double rad)
        {
            return rad * 2 * PI;
        }

        public double getSquare(double rad)
        {
            return PI * rad * rad;
        }
    }
}
