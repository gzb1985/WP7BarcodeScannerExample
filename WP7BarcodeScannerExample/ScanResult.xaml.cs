using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;

namespace WP7BarcodeScannerExample
{
    public partial class ScanResult : PhoneApplicationPage
    {
        public ScanResult()
        {
            InitializeComponent();
            scanResult.Text = "";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string result = "";
            if (NavigationContext.QueryString.TryGetValue("result", out result))
            {
                scanResult.Text += result + "\r\n";
            }
            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            var lastPage = NavigationService.BackStack.FirstOrDefault();
            if (lastPage != null && lastPage.Source.ToString().Contains("/BarCode.xaml"))
            {
                NavigationService.RemoveBackEntry();
            }

            base.OnNavigatingFrom(e);
        }
    }
}