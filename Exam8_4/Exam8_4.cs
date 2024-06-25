using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_4
{
    internal class Exam8_4
    {
        public void Run()
        {
            string name = GetName();
            string sex = GetSex();
            int score = Util.GetDigit();
            test(name,sex,score);
        }

        private void test(string name, string sex, int score)
        {
            if()
        }

        private string GetName()
        {
            Console.WriteLine("이름을 입력하세요");
            string val = Console.ReadLine();
            return val;
        }
        private Enum GetSex()
        {
            Console.WriteLine("성별을 입력하세요");
            string val = Console.ReadLine();
            if (val == "남성")
            {
                return SexEnum.남성;
            }
            else if (val == "여성")
            {
                return SexEnum.여성;
            }
            else
            {
                return SexEnum.해당없음;
            }
        }
    }
}
