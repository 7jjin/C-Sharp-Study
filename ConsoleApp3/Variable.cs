using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Variable
    {
        static void Main(string[] args)
        {
            int a=1;
            a = 1;
            Console.WriteLine("a = " + a);
            Func1(a);
            Console.WriteLine("a = " + a);  // 여기서의 a는 지역변수 a이다.
            
        }
        static private void Func1(int a)
        {
            a = 2;
            Console.WriteLine("a = " + a);
        }
    }
}
