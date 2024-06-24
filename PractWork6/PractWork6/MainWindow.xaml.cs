using System.Collections.Generic;
using System.Windows;

namespace PractWork6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Game> games = new List<Game>
            {
                new Game { IdGame = 1, Name = "WarThunder", Description = "Это многопользовательский онлайн экшен с танками",Category="Shooter", Price = 0 },
                new Game { IdGame = 2, Name = "DarkSouls 3", Description = "однопользовтаельская игра с элементами РПГ", Category = "RPG", Price = 2499 },
                new Game { IdGame = 3, Name = "Cyberpunk 2077", Description = "Однопользовательская игра с множеством багов", Category = "RPG", Price = 3500 },
                new Game { IdGame = 4, Name = "Hotline Miami", Description = "РЕЗНЯ", Category = "Shooter", Price = 500 },
                new Game { IdGame = 5, Name = "Dota 2", Description = "MOBA от валве", Category = "MOBA", Price = 0 }
            };
            GameDataGrid.ItemsSource = games;

            List<Category> categories = new List<Category>
            {
                new Category {NameCategory = "Shooter"},
                new Category {NameCategory = "RPG"},
                new Category {NameCategory = "MOBA"},
            };
            categoryComboBox.ItemsSource = categories;
        }
    }
}
