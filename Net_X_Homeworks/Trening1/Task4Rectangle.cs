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
            double height = topLeftPoint.getY() - bottomRightPoint.getY();
            double width = topLeftPoint.getX() - bottomRightPoint.getX();
            if (height < 0)
                height *= -1;
            if (width < 0)
                width *= -1;
            return (height + width) * 2;
        }

        public static double getSquare(Point topLeftPoint, Point bottomRightPoint)
        {
            double height = topLeftPoint.getY() - bottomRightPoint.getY();
            double width = topLeftPoint.getX() - bottomRightPoint.getX();
            if (height < 0)
                height *= -1;
            if (width < 0)
                width *= -1;
            return height * width;
        }
    }
}
