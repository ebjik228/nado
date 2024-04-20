using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace УПпрактика
{
    /// <summary>
    /// Логика взаимодействия для Visitormenu.xaml
    /// </summary>
    public partial class Visitormenu : Window
    {
        public Visitormenu()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Teams_Click(object sender, RoutedEventArgs e)
        {
            Teams teams = new Teams();
            teams.Show();
            this.Hide();
        }

        private void Player_Click(object sender, RoutedEventArgs e)
        {
            //Player player = new Player();
            //player.Show();
            //this.Hide();
        }

        private void Matchups_Click(object sender, RoutedEventArgs e)
        {
            Matchups matchups = new Matchups();
            matchups.Show();
            this.Hide();
        }

        private void Photo_Click(object sender, RoutedEventArgs e)
        {
            Photos photos = new Photos();
            photos.Show();
            this.Hide();
        }
    }
}
