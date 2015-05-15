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
using DomoticaApp.Resources;

namespace DomoticaApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            if ((!(appSettings.Contains("IP"))) || (!(appSettings.Contains("PORT"))))
            {
                appSettings.Add("IP", "");
                appSettings.Add("PORT", "");
            }
        }
        
        public static int AddIntegers(int a, int b)  {
            return (a + b);
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/settingsPage.xaml", UriKind.Relative));
        }

        private void settingsBtn_Loaded(object sender, RoutedEventArgs e)
        {
            if (!(appSettings["IP"].ToString() == ""))
            {
                ipAddressTB.Text = appSettings["IP"].ToString();
            }
            else
            {
                ipAddressTB.Text = "IP not set...";
            }
            if (!(appSettings["PORT"].ToString() == ""))
            {
                portTB.Text = appSettings["PORT"].ToString();
            }
            else
            {
                portTB.Text = "Port not set...";
            }
        }
    }
}