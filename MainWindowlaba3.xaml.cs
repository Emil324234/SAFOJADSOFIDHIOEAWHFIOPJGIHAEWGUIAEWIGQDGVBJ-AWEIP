using prct3Lab3.DS3DataSetTableAdapters;
using System.Windows;

namespace prct3Lab3
{
    public partial class MainWindow : Window
    {
        private PlayersTableAdapter players = new PlayersTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            WeaponGRD.ItemsSource = players.GetPlayers();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WeaponGRD.Columns[0].Visibility = Visibility.Collapsed;
            WeaponGRD.Columns[2].Visibility = Visibility.Collapsed;
        }
    }
}
