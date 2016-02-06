using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication3
{
    class Program
    {   
        // <param name="s">число в виде строки, которое нужно проверить</param>
        // <returns> ответ правда или ложь, простое ли число</returns>
        static bool IsPrime(string s)
        {
            //конвертация от типа строки в тип целое число
            int x = int.Parse(s);
            int cnt = 0;
            //подсчет кол-ва делителей отличных от 1 и самого числа
            for (int j = 2; j <= Math.Sqrt(x); ++j)
            {
                if (x % j == 0)
                {
                    cnt++;
                }
            }

            return cnt == 0 && x != 1;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
            {
                if (IsPrime(args[i]))
                {
                    Console.WriteLine(args[i] + "is prime");
                }
                else
                {
                    Console.WriteLine(args[i] + "is not prime");
                }
            }
        }
    }
}
