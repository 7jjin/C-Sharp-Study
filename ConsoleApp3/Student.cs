using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace jhjo
{
    // Class fullname => namespace.class_name
    /// <summary>
    /// jhjo.student 클래스 정의
    /// </summary>
    public class Student
    {
        private string name;
        private string address;
        private int age;

        #region 생성자
        public Student(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public Student(string name) : this(name, null) { }
        public Student() : this(null) { }

        //public Student()
        //{
        //    Console.WriteLine("jhjo.Student() 생성자 호출됨");
        //}
        //public Student(string name)
        //{
        //    this.name = name;
        //}
        //public Student(string name, string address)
        //{
        //    this.name = name;
        //    this.address = address;
        //}
        #endregion
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            if(age<0 || age > 121)
            {
                Console.WriteLine("나이는 음수나 120세를 넘을 수 없습니다.");
                return;
            }
            this.age = age;
        }




        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name=name;
        }
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        // 조건이 필요없을 때 
        public string Name { get; set; }


        public void printName()
        {
            Console.WriteLine("name = " + name);
        }
        public void printAddress()
        {
            Console.WriteLine("address = " + address);
        }
    }
}
