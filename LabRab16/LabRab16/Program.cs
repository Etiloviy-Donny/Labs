using System.ComponentModel;

namespace LabRab16
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            User user = new User() { Login = "User", Password = "123456yuio" };
            user.PropertyChanged += User_PropertyChanged;
            user.Login = "Login";
            user.Password = "password";
        }

        static void User_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine($"{e.PropertyName} изменено");
        }
    }
}
