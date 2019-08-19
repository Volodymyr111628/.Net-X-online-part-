using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening2.Task3
{
    public class Figure
    {
        public double X { get; }
        public double Y { get; }

        public Figure()
        {
            X = 0;
            Y = 0;
        }

        public Figure(double x,double y)
        {
            X = x;
            Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("In class Figure");
        }
    }
}
