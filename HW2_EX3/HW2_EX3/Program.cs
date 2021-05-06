using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 0;
            bool a = true;
            while (a)
            {
                Console.WriteLine("Напишите положительное число");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {

                }
                else
                {
                    if (number >= 0)
                    {
                        sum = sum + number;
                    }
                   
                }
                if(number == 0)
                {
                    a = false;
                    Console.WriteLine($"сумма всех нечетных положительных чисел равна {sum}");
                    Console.ReadLine();
                    
                }
                
            }


        }    
    }
}
