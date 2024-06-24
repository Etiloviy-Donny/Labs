namespace Task1
{
    internal class Program
    {
        private static string _login;
        private static string _password;

        public static bool IsCorrectUserData(string login, string password, string confirmPassword)
        {
            bool IsLoginCorrect = !string.IsNullOrEmpty(login);
            bool IsPasswordCorrect = !string.IsNullOrEmpty(password);
            bool IsConfirmCorrect = password == confirmPassword;

            if (IsLoginCorrect && IsPasswordCorrect && password == confirmPassword)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            Console.WriteLine("Подтвердите пароль");
            string confirmPassword = Console.ReadLine();

            if (IsCorrectUserData(login, password, confirmPassword))
            {
                Console.WriteLine("Вы зарагистрированны!");
                _login = login;
                _password = password;
            }
            else
                Console.WriteLine("Ошибка регистрации");
        }
    }
}
