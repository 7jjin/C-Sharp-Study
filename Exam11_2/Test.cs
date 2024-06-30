using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11_2
{
    internal class Test
    {
        public void Run()
        {
            Student[] students = new Student[]
            { 
                new Student("이교준",89,1),
                new Student("김성훈",78,2)
            };
            Array.Sort(students);
            foreach(Student st in students) Console.WriteLine(st);
            FileStream stream  = new FileStream(@"d:\temp\aa.txt", FileMode.Open);
            // 아래 using문 아래서 관리하고 dispose하고 다함.
            using (StreamReader reader = new StreamReader(stream)) {
                string buffer;
                while ((buffer = reader.ReadLine()) != null)
                {
                    Console.WriteLine(buffer);
                }
            }
        }
       
             
    }
    class Student : IComparable,IDisposable
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }
        public Student(string name, int score, int id)
        {
            Name = name;
            Score = score;
            Id = id;
        }
        public override string ToString()
        {
            return $"{Name}[{Id}][{Score}]";
        }

        public int CompareTo(object? obj)
        {
            Student st = obj as Student;
            int ret = Score - st.Score;
            return ret;
        }

        ~Student()
        {

        }
        bool disposed; //false
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                // C#에서 사용하는 IDisposable을 구현한 객체들 정리
            }
            else
            {
                // .NET Framwork에서 관리되지 않는 자원들 정리
            }
            disposed = true;
        }
    }
}
