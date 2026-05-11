using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace App.Components.Views
{
    /// <summary>
    /// Lógica de interacción para Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void lblAccouncreate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Label clickeado");
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
