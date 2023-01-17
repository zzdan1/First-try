using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umno
{
    class Program
    {
        static void Main(string[] args)
        {
        begin:;
            Console.WriteLine("Введите два числа, которые хотите перемножить");
            int num1 = Convert.ToInt32 (Console.ReadLine());
            int num2 = Convert.ToInt32 (Console.ReadLine());
            num1 = num1 * num2;
            Console.WriteLine(num1);
            Console.WriteLine("Выйти? Да-yes");
            string c = Console.ReadLine();
            if(c!="yes")
            {
                goto begin;
            }
        }

    }
}
