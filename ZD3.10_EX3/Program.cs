using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD3._10_EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            bool check = false;
            while (counter < num/2 + 1)
            {

                if (num % counter == 0)
                {
                    
                    check = true; 
                    
                }
                counter++;
                
            }
            Console.WriteLine(check);
            Console.ReadKey();
        }
    }
}
