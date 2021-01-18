using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class circle:shape
    {
        private double radius = 1.0;
        public circle()
        {
            this.Radius = 1.0;
                
        }
        public circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }
        public override double getArea()
        {
            return base.getArea();
            return 3.14 * (radius*radius);
        }
        public override double getParameter()
        {
            return base.getParameter();
            return 2 * 3.14 * radius;
        }
    }
}
