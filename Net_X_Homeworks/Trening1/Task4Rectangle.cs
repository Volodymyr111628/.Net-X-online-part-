using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    class Task4Rectangle
    {
        public static double getPerimeter(Point topLeftPoint,Point bottomRightPoint)
        {
            return (Math.Abs(topLeftPoint.getX() - bottomRightPoint.getX()) + Math.Abs(topLeftPoint.getY() - bottomRightPoint.getY())) * 2;
        }

        public static double getSquare(Point topLeftPoint, Point bottomRightPoint)
        {
            return Math.Abs(topLeftPoint.getX() - bottomRightPoint.getX()) * Math.Abs(topLeftPoint.getY() - bottomRightPoint.getY());
        }
    }
}
