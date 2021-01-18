using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class shape
    {
        private string color;
        private bool filled;
        
        public shape()
        {
            this.Color = "Red";
            this.Filled = true;
        }

        protected shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public virtual double getArea()
        {
            return 0;
        }

        public virtual double getParameter()
        {
            return 0;
        }
    }
}
