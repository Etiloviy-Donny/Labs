using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LabRab16
{
    internal class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string login;
        private string password;

        public string Login
        {
            get { return login; }
            set
            {
                if (login != value && !string.IsNullOrWhiteSpace(value))
                {
                    login = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return password; }

            set
            {
                if (login != value && !string.IsNullOrWhiteSpace(value))
                {
                    password = value;
                    OnPropertyChanged();
                }

            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = " ")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
