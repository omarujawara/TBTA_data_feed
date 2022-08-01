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
using System.Diagnostics;

namespace TBTA_data_feed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataFeedAPI feedAPI = new DataFeedAPI();
        AlertsDataTable alerts = new AlertsDataTable();
        JamsDataTable jams = new JamsDataTable();

        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private async void AlertTableButton_Click(object sender, RoutedEventArgs e)
        {
            await feedAPI.GetWazeFeed();
            DataFeedAPI.Root r = new DataFeedAPI.Root();
            Debug.WriteLine($"startTime = {r.startTime}");
            alerts.Show();
        }

        private async void JamTableButton_Click(object sender, RoutedEventArgs e)
        {
            await feedAPI.GetWazeFeed();
            jams.Show();
        }
        
    }
}
