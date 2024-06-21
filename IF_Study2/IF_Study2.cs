using MyLibrary;
using System;
namespace IF_Study2
{
    public class IF_Study2
    {
        public void Run()
        {
            //여기부터 프로그램 시작
            PrintResult(Util.GetDigit());
        }

        private void PrintResult(int digit)
        {
            if (digit > 90)
            {
                Console.WriteLine("우수");
            }
            else
            {
                Console.WriteLine("보통");
            }
        }

        
    }
}
