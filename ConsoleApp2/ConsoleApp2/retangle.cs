using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class retangle:shape
    {
        private double width;
        private double length;
        public retangle()
        {
            this.width = 1.0;
            this.length = 1.0;
        }
        public retangle(double width,double length, string color, bool filled):base(color,filled)
        {
            this.width = width;
            this.length = length;
        }
    }
}
