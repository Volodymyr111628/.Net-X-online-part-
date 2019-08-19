using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening2.Task2
{
    public class Square:Figure
    {
        public Square() : base() { }

        public Square(double x, double y) : base(x, y) { }
       
        public override void Draw()
        {
            Console.WriteLine("In class Square");
        }
    }
}
