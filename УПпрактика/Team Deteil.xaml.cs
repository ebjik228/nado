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
    /// Логика взаимодействия для Team_Deteil.xaml
    /// </summary>
    public partial class Team_Deteil : Window
    {
        public Team_Deteil()
        {
            InitializeComponent();

            dGridRoster.ItemsSource = BasketballSystemEntities.GetContext().PlayerInTeam.ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Teams teams = new Teams();
            teams.Show();
            this.Hide();
        }
    }
}
