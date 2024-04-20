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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace УПпрактика
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {

            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void Visitor_Click(object sender, RoutedEventArgs e)
        {
            Visitormenu visitormenu = new Visitormenu();
            visitormenu.Show();
            this.Hide();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
