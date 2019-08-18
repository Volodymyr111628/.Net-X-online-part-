using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    public static class Task4Circle
    {
        public static double PI = 3.1415926535;
        public static double getLength(double radius)
        {
            return radius * 2 * PI;
        }

        public static double getSquare(double radius)
        {
            return PI * radius * radius;
        }
    }
}
