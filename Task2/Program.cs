using System;

namespace Task2
{
    internal class Program
    {
        private static string _login;
        private static string _password;
        static void Main(string[] args)
        {
            User user1 = new User();
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            Console.WriteLine("Подтвердите пароль");
            string confirmPassword = Console.ReadLine();

            if (user1.IsCorrectUserData(login, password, confirmPassword))
            {
                Console.WriteLine("Вы зарагистрированны!");
                user1.Login = _login;
                user1.Password = _password;
            }
            else
                Console.WriteLine("Ошибка регистрации");
        }
    }
}
