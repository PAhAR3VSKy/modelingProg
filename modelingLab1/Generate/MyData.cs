using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generate
{
    public class MyData
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public MyData(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
