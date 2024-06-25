using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    internal class Student:Human
    {
        public int Grede { get; set; }
        public int StudentClass { get; set; }
        public int StudentId { get; set; }
        public void test()
        {
            Console.WriteLine("시험을 보다");
        }

    }
}
