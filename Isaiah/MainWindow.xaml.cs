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
using Microsoft.Win32;

namespace Isaiah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        const string keyName = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetAppLightMode(int mode)
        {
            // Mode 0 is Dark
            // Mode 1 is Light
            Registry.SetValue(keyName, "AppsUseLightTheme", mode, RegistryValueKind.DWord);
        }

        private void SetSystemLightMode(int mode)
        {
            Registry.SetValue(keyName, "SystemUsesLightTheme", mode, RegistryValueKind.DWord);
        }

        private void SystemLightModeButton_Click(object sender, RoutedEventArgs e)
        {
            SetSystemLightMode(1);
        }

        private void SystemDarkModeButton_Click(object sender, RoutedEventArgs e)
        {
            SetSystemLightMode(0);
        }

        private void AppsLightModeButton_Click(object sender, RoutedEventArgs e)
        {
            SetAppLightMode(1);
        }

        private void AppsDarkModeButton_Click(object sender, RoutedEventArgs e)
        {
            SetAppLightMode(0);
        }
    }
}
