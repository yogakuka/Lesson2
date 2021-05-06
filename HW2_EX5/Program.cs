using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 3;
            string login = "root";
            string password = "GeekBrains";
            bool User = false;
            string UsersLogin;
            string UsersPassword;
            do
            {
                Console.WriteLine("Ваш логин");
                UsersLogin = Console.ReadLine();
                Console.WriteLine("Пароль");
                UsersPassword = Console.ReadLine();
                if (UsersLogin == login & UsersPassword == password)
                {

                    User = true;
                    tries = 0;
                }
                else
                {
                    Console.WriteLine("Введен неправильный логин или пароль");
                    Console.WriteLine("Попробуйте еще раз");
                    tries--;
                }
            } while (tries > 0);
            if (User)
            {
                Console.WriteLine("Вы прошли авторизацию");
            }
            else
            {
                Console.WriteLine("Превышено количество попыток для ввода пароля");
            }
        }
    }
}
