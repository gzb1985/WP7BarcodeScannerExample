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

namespace WP7BarcodeScannerExample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();
        }

        private void oneDBarcodeScan_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BarCode.xaml", UriKind.Relative));
        }

        private void twoDBarcodeScan_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BarCode.xaml?type=qrcode", UriKind.Relative));
        }
    }
}