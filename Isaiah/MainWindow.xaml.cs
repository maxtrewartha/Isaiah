using Microsoft.Win32;
using System.Windows;
using System;

namespace Isaiah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        const string PersonalizationKey = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize";
        public MainWindow()
        {
            InitializeComponent();
            if((int)Registry.GetValue(PersonalizationKey, "EnableTransparency", 0) == 1)
            {
                TransparentEffect.IsChecked = true;
            }
        }

        private void SetPersonalizationKey(string key, int value, RegistryValueKind kind)
        {
            Registry.SetValue(PersonalizationKey, key, value, kind);
        }
      

        private void SystemLightModeButton_Click(object sender, RoutedEventArgs e)
        {
            SetPersonalizationKey("SystemUsesLightTheme", 1, RegistryValueKind.DWord);
        }

        private void SystemDarkModeButton_Click(object sender, RoutedEventArgs e)
        {
            SetPersonalizationKey("SystemUsesLightTheme", 0, RegistryValueKind.DWord);
        }

        private void AppsLightModeButton_Click(object sender, RoutedEventArgs e)
        {
            SetPersonalizationKey("AppsUseLightTheme", 1, RegistryValueKind.DWord);
        }

        private void AppsDarkModeButton_Click(object sender, RoutedEventArgs e)
        {
            SetPersonalizationKey("AppsUseLightTheme", 0, RegistryValueKind.DWord);
        }

        private void TransparentEffect_Checked(object sender, RoutedEventArgs e)
        {
            SetPersonalizationKey("EnableTransparency", 1, RegistryValueKind.DWord);
        }

        private void TransparentEffect_Unchecked(object sender, RoutedEventArgs e)
        {
            SetPersonalizationKey("EnableTransparency", 0, RegistryValueKind.DWord);
        }
    }
}
