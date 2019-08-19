using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening2.Task4
{
    class Square:Figure,IDrawable
    {
        public Square() : base() { }

        public Square(double x, double y) : base(x, y) { }

        public new void Draw()
        {
            Console.WriteLine("In class Square");
        }
    }
}
