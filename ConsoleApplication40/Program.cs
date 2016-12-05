using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 输入一个数，判断其中有几个2
/// </summary>
namespace ConsoleApplication40
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            //输入一个数字
            int totalNum = 0;
            int num = Convert.ToInt32(Console.ReadLine ( ));

            //取下数字的每一位
            int gewei = num % 10;
            int shiwei = num / 10 % 10;
            int baiwei = num / 100 % 10;
            int qianwei = num / 1000 % 10;
            int wanwei = num / 10000 % 10;
            int wanwei2 = num / 100000 % 10;
            int wanwei3 = num / 1000000 % 10;
            int wanwei4 = num / 10000000 % 10;
            int wanwei5 = num / 100000000 % 10;

            //判断是否为2 
            if (gewei == 2)
            {
                ++totalNum;
            }
            if (shiwei == 2)
            {
                ++totalNum;
            }
            if (baiwei == 2)
            {
                ++totalNum;
            }
            if (qianwei == 2)
            {
                ++totalNum;
            }
            if (wanwei == 2)
            {
                ++totalNum;
            }
            if (wanwei2 == 2)
            {
                ++totalNum;
            }
            if (wanwei3 == 2)
            {
                ++totalNum;
            }
            if (wanwei4 == 2)
            {
                ++totalNum;
            }
            if (wanwei5 == 2)
            {
                ++totalNum;
            }
            Console.WriteLine (totalNum);
        }
    }
}
