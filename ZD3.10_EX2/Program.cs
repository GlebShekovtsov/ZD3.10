using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD3._10_EX2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Сколько карт у вас в руке?");
            int cardNum = Convert.ToInt32(Console.ReadLine());
            int cardSum = 0;
            string cardRate;
            for(int i = 1; i <= cardNum; i++)
            {
                Console.WriteLine($"Введите номинал карты под номером {i}");
                int value;
                cardRate = Console.ReadLine();
                switch (cardRate)
                {
                    case "2":
                        value = 2;
                        cardSum += value;
                        break;
                    case "3":
                        value = 3;
                        cardSum += value;
                        break;
                    case "4":
                        value = 4;
                        cardSum += value;
                        break;
                    case "5":
                        value = 5;
                        cardSum += value;
                        break;
                    case "6":
                        value = 6;
                        cardSum += value;
                        break;
                    case "7":
                        value = 7;
                        cardSum += value;
                        break;
                    case "8":
                        value = 8;
                        cardSum += value;
                        break;
                    case "9":
                        value = 9;
                        cardSum += value;
                        break;
                    case "10":
                        value = 10;
                        cardSum += value;
                        break;
                    case "J":
                        value = 10;
                        cardSum += value;
                        break;
                    case "Q":
                        value = 10;
                        cardSum += value;
                        break;
                    case "K":
                        value = 10;
                        cardSum += value;
                        break;
                    case "T":
                        value = 10;
                        cardSum += value;
                        break;
                    default:
                        Console.WriteLine("Введите корректное значение");
                        break;
                }
                
            }
            Console.WriteLine($"Сумма всех карт в колоде: {cardSum}");
            Console.ReadKey();
        }
    }
}
