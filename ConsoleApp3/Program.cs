using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jhjo;
// using을 사용하면 다른 네임스페이스의 클래스를 가져다 쓸 수 있다. (벽이 허물어진 느낌)
// 따라서 클래스를 선언할 때 네임스페이스를 안써도 된다. 하지만 같은 클래스가 현재 네임스페이스에 존재한다면
// 네임스페이스 써야지

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.SetName("조진형");
            student1.SetAge(1000);
            student1.SetAge(-1);


            Console.WriteLine(student1.GetName());
        }
    }
}
