using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DomoticaApp
{
    public partial class PanoramaPage1 : PhoneApplicationPage
    {
        public PanoramaPage1()
        {
          InitializeComponent();
        }

        private void settingsBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/settingsPage.xaml", UriKind.Relative));
        }
    }
    /*
    public partial class SensorDataPage : PhoneApplicationPage
    {
        public SensorDataPage()
        {
         //   InitializeComponent();
        }
    }

    public partial class SettingsPage : PhoneApplicationPage
    {
        public SettingsPage()
        {
         //   InitializeComponent();
        }
    }
    */
}