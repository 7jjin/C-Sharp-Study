using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // 배열 선언
            int[] kor = new int[10];

            // 선언 즉시 초기화
            string[] name = new string[3] {"조","진","형"};

            // 2차원 배열
            int[,] kor_1 = new int[10,10];
            int[,] kor_2 = new int[,] { {10,20,30 }, { 10, 20, 30 } };
            kor[0] = 1;

            Student[] student = new Student[10];
            student[0] = new Student("조");
            student[1] = new Student("진");
            Console.WriteLine(kor[0]);
            Console.WriteLine(name[0]);
        }
    }
    class Student
    {
        public int kor;
        public string name;
        public Student(string name)
        {
            this.name = name;
        }
    }
}
