using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10_1
{

    internal class Circle : Figure
    {
        public Double Diameter { get; set; }

        public Circle(Double diameter)
        {
            Diameter = diameter;
        }

        public override double Area()
        {
            return Diameter / 2 * 3.14;
        }
    }

}
