using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using System.Text.Json;




namespace TBTA_data_feed
{
    internal class DataFeedAPI
    {
        HttpClient client = new HttpClient();
        int? size,x;
        Root? dataList = new Root();
        public async Task GetWazeFeed()
        {
            string wazeUrl = "https://www.waze.com/partnerhub-api/waze-feed-access-token/e4d80438-9dc1-4588-8e3a-93cddf1bb913?format=1";
            string response = await client.GetStringAsync(wazeUrl);
            Debug.WriteLine("*********************************");
            Debug.WriteLine(response);
            Debug.WriteLine("*********************************");
  
            dataList = JsonSerializer.Deserialize<Root>(response);
            Root root = new Root();
            x = dataList.alerts.Count;
            root.startTime = dataList?.startTime;
            Debug.WriteLine("*************************After deserialization***********************");
            Debug.WriteLine(dataList?.alerts?.Count);
            size = dataList?.alerts?.Count;
            Debug.WriteLine($"*************************size ===> {size} ***********************");


        }
       

        public class Jam
        {
            public string? country { get; set; }
            public string? city { get; set; }
            public int level { get; set; }
            public List<Line>? line { get; set; }
            public double speedKMH { get; set; }
            public int length { get; set; }
            public string? turnType { get; set; }
            public string? type { get; set; }
            public ulong uuid { get; set; }
            public string? endNode { get; set; }
            public double speed { get; set; }
            public List<Segment>? segments { get; set; }
            public int roadType { get; set; }
            public int delay { get; set; }
            public string? street { get; set; }
            public ulong id { get; set; }
            public ulong pubMillis { get; set; }
            public string? blockingAlertUuid { get; set; }
        }

        public class Line
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        

        public class Root
        {
            public List<AlertsDataTable.Alert>? alerts { get; set; }
            public long endTimeMillis { get; set; }
            public long startTimeMillis { get; set; }
            public string? startTime { get; set; }
            public string? endTime { get; set; }
            public List<Jam>? jams { get; set; }
        }

        public class Segment
        {
        }


    }
}

