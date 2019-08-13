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
            return (Math.Abs(topLeftPoint.getX() - bottomRightPoint.getX()) + Math.Abs(topLeftPoint.getY() - bottomRightPoint.getY())) * 2;
        }

        public double getSquare()
        {
            return Math.Abs(topLeftPoint.getX() - bottomRightPoint.getX()) * Math.Abs(topLeftPoint.getY() - bottomRightPoint.getY());
        }
    }
}
