﻿using System;
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
    /// Логика взаимодействия для Photos.xaml
    /// </summary>
    public partial class Photos : Window
    {
        public Photos()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Visitormenu visitormenu = new Visitormenu();
            visitormenu.Show();
            this.Hide();
        }
    }
}
