using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DomoticaApp
{
    public partial class settingsPage : PhoneApplicationPage
    {
        IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;

        public settingsPage()
        {
            InitializeComponent();
        }

        private void saveBTN_Click(object sender, RoutedEventArgs e)
        {
            appSettings.Remove("IP");
            appSettings.Add("IP", ipAddressTB.Text);
         
            appSettings.Remove("PORT");
            appSettings.Add("PORT", portTB.Text);

            NavigationService.GoBack();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            ipAddressTB.Text = appSettings["IP"].ToString();
            portTB.Text = appSettings["PORT"].ToString();
        }
    }
}