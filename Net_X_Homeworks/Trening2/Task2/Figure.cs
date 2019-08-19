﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening2.Task2
{
    public abstract class Figure
    {
        
        public double X { get; }
        public double Y { get; }

        public Figure()
        {
            X = 0;
            Y = 0;
        }

        public Figure(double _x,double _y)
        {
            X = _x;
            Y = _y;
        }

        public abstract void Draw();
    }
}
