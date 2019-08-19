﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening2.Task4
{
    public class Figure: IDrawable
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

        public void Draw()
        {
            Console.WriteLine("In class Figure");
        }
    }
}
