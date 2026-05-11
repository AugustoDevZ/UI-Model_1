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
using System.Windows.Navigation;
using System.Windows.Shapes;
using App.Components.Layouts.Body;
using App.Components.Views;
using App.Config;

namespace Zrutas.UI.Views.Frames
{
    /// <summary>
    /// Lógica de interacción para Setting.xaml
    /// </summary>
    public partial class Setting : Page
    {
        public Setting()
        {
            InitializeComponent();
            btnTeme.Content = AppSetting.CurrentTheme.ToString();
        }

        private void btnTeme_Click(object sender, RoutedEventArgs e)
        {
            //frContent.Navigate(new ThemeSelector());

            Dashboard mainWindow = (Dashboard)Application.Current.MainWindow;


            mainWindow.frBody.Navigate(new ThemeSelector());
            mainWindow.frBody.Visibility = Visibility.Visible;
        }
    }
}
