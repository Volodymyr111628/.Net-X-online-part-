using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    public class RectangleWithAutoProps
    {
        public Point topLeftPoint;
        public Point bottomRightPoint;

        public double RectangleSquare { get; set; }
        public double RectanglePerimeter { get; set; }
        
        public RectangleWithAutoProps()
        {
            topLeftPoint = new Point();
            bottomRightPoint = new Point();
            RectangleSquare = 0;
            RectanglePerimeter = 0;
        }

        public RectangleWithAutoProps(double x1, double y1, double x2, double y2)
        {
            topLeftPoint = new Point(x1, y1);
            bottomRightPoint = new Point(x2, y2);
            double height = topLeftPoint.getY() - bottomRightPoint.getY();
            double width = topLeftPoint.getX() - bottomRightPoint.getX();
            if (height < 0)
                height *= -1;
            if (width < 0)
                width *= -1;
            RectangleSquare = height * width;
            RectanglePerimeter = (height + width) * 2;
        }
    }
}
