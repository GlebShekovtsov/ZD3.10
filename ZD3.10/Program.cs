using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD3._10EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Введенное число - чётное");
            }
            else
            {
                Console.WriteLine("Введенное число - нечётное");
            }
            Console.ReadKey();
        }
    }
}
