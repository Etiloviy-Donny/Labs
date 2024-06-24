using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class User
    {
        public static string _login;
        public static string _password;

        public string Login { get; internal set; }
        public string Password { get; internal set; }

        public static bool IsCorrectUserData(string login, string password, string confirmPassword)
        {
            bool IsLoginCorrect = !string.IsNullOrEmpty(login);
            bool IsPasswordCorrect = !string.IsNullOrEmpty(password);
            bool IsConfirmCorrect = password == confirmPassword;

            if (IsLoginCorrect && IsPasswordCorrect && password == confirmPassword)
                return true;
            return false;
        }
    }
}
