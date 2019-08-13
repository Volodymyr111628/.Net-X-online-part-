using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    public class RectangleWithAutoProps
    {
        public Point TopLeftPoint{ get; set; }
        public Point BottomRightPoint { get; set; }

        public double getPerimeter()
        {
            return (Math.Abs(TopLeftPoint.getX() - BottomRightPoint.getX()) + Math.Abs(TopLeftPoint.getY() - BottomRightPoint.getY())) * 2;
        }

        public double getSquare()
        {
            return Math.Abs(TopLeftPoint.getX() - BottomRightPoint.getX()) * Math.Abs(TopLeftPoint.getY() - BottomRightPoint.getY());
        }
    }
}
