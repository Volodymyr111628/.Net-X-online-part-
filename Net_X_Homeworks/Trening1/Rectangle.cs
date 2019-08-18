using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    public class Rectangle
    {
        public Point topLeftPoint;
        public Point bottomRightPoint;

        public Rectangle()
        {
            topLeftPoint = new Point();
            bottomRightPoint = new Point();
        }

        public Rectangle(double x1, double y1, double x2, double y2)
        {
            topLeftPoint = new Point(x1, y1);
            bottomRightPoint = new Point(x2, y2);
        }

        public double getPerimeter()
        {
            double height = topLeftPoint.getY() - bottomRightPoint.getY();
            double width = topLeftPoint.getX() - bottomRightPoint.getX();
            if (height < 0)
                height *= -1;
            if (width < 0)
                width *= -1;
            return (height + width) * 2;
        }

        public double getSquare()
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
