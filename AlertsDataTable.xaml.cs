using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net.Http;
using System.Diagnostics;
using System.Text.Json;

namespace TBTA_data_feed 
{
    /// <summary>
    /// Interaction logic for DataTable.xaml
    /// </summary>

    public partial class AlertsDataTable : Window
    {
        public AlertsDataTable()
        {
            InitializeComponent();
            
            //AlertGridXAML.DataContext = 
        }
        public class Alert
        {
            public string? country { get; set; }
            public string? city { get; set; }
            public int reportRating { get; set; }
            public int confidence { get; set; }
            public int reliability { get; set; }
            public string? type { get; set; }
            public string? uuid { get; set; }
            public int roadType { get; set; }
            public int magvar { get; set; }
            public string? subtype { get; set; }
            public string? street { get; set; }
            public string? reportDescription { get; set; }
            public Location? location { get; set; }
            public ulong pubMillis { get; set; }
            public int? nThumbsUp { get; set; }
        }
        public class Location
        {
            public double x { get; set; }
            public double y { get; set; }
        }
    }
}
