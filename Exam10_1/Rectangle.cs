using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10_1
{
    internal class Rectangle : Figure
    {
        int x1, y1;
        int x2, y2;
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;    
        }

        public override double Area()
        {
            return (Width * Height);
        }
    }
}
