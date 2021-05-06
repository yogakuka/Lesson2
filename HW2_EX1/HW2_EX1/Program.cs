using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                if (b > c)
                {
                    
                    Console.WriteLine($"третье число ({c}) самое маленькое");
                }
                else
                {
                    Console.WriteLine($"второе число({b}) самое маленькое");
                }
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine($"третье число({c}) самое маленькое ");
                }
                else
                {
                    Console.WriteLine($"первое число({a}) самое маленькое");
                }
            }
            

            
        }
    }
}
