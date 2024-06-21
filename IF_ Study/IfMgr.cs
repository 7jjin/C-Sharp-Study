using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF__Study
{
    public class IfMgr
    {
        public void Run()
        {
            //여기부터 프로그램 시작
            PrintResult(GetDigit());

        }

        private void PrintResult(int digit)
        {
            if (digit > 90) {
                Console.WriteLine("우수");
            }
        }

        private int GetDigit()
        {
            Console.WriteLine("숫자를 입력하세요");
            string val = Console.ReadLine();
            return ConvertString2Int(val);

        }

        private int ConvertString2Int(string str)
        {
            int result = 0;
            bool ret = int.TryParse(str, out result);
            if (ret)
            {
                return result;
            }
            else
            {
                return -1;
            }
        }

    }
}
