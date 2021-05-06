using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            int d = DigitCount(a);
            Console.WriteLine($"Количество цифр в числе {a} равно - {d}");
            Console.ReadLine();
        }
        private static int DigitCount(int number)
        {
            int i = 0;
            int k = 1;
            while (true)
            {
                i++;
                k *= 10;
                if (Math.Abs(number) < k)
                {
                    return i;
                }
            }
        }
    }
}
