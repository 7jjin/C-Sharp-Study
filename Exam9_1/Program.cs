using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    internal class Program
    {
        static void Main(string[] args) { 
            //학생
            //학년, 반, 번호
            //사람
            //성명, 혈액형, 국적, 주소, 전화번호...
            //동물
            //나이, 성별, 몸무게
            Student student = new Student();
            Console.WriteLine(student.ToString()); 
        }
    }
}
