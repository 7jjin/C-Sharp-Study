using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Circle cir = new Circle(10);
            Console.WriteLine($"사각형의 면적은 : {rect.Area()}");
            Console.WriteLine($"원의 면적은 : {cir.Area()}");
        }
    }
}
