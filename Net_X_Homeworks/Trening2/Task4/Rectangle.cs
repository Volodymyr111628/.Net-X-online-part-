using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening2.Task4
{
    class Rectangle:Figure,IDrawable
    {
        public Rectangle() : base() { }

        public Rectangle(double x, double y) : base(x, y) { }

        public new void Draw()
        {
            Console.WriteLine("In class Rectangle");
        }
    }
}
