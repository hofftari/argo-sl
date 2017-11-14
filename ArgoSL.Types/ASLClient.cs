using ArgoSL.Types.Interfaces;
using System.Net.Http;
using System;
using Newtonsoft.Json;

namespace ArgoSL.Types
{
    public class ASLClient : ISLClient
    {
        private static string format = "json";
        private string realTimeInfoApiKey;
        private string stationInfoApiKey;
        private string apiRootUrl;
        private int timeWindow;
        public IHttpClient ApiClient { get; }
        public ASLClient(IHttpClient apiClient)
        {
            ApiClient = apiClient;
            realTimeInfoApiKey = Properties.Settings.Default.RealTimeApiKey;
            stationInfoApiKey = Properties.Settings.Default.StationInfoApiKey;
            apiRootUrl = Properties.Settings.Default.ApiRootUrl;
            timeWindow = Properties.Settings.Default.TimeWindow;
        }
        public RealTimeInfo GetRealTimeInfoForStation(string stationId)
        {
            return JsonConvert.DeserializeObject<RealTimeInfo>(GetRealTimeInfoStringForStation(stationId));
        }
        public string GetRealTimeInfoStringForStation(string stationId)
        {
            return GetReadResponseString(string.Format("{0}/realtimedeparturesV4.json?key={1}&siteid={2}&timewindow={3}", apiRootUrl, realTimeInfoApiKey, stationId, timeWindow));
        }
        public string SearchForStation(string searchString)
        {
            return GetReadResponseString(string.Format("{0}/typeahead.json?key={1}&searchstring={2}&stationsonly=true&maxresults=10", apiRootUrl, stationInfoApiKey, searchString));
        }
        public StationInfo GetSearchResultsForStation(string searchString)
        {
            return JsonConvert.DeserializeObject<StationInfo>(SearchForStation(searchString));
        }
        private string GetReadResponseString(string path)
        {
            string content = "";

            HttpResponseMessage response = ApiClient.GetAsync(path).Result;

            if (response.IsSuccessStatusCode)
            {
                content = response.Content.ReadAsStringAsync().Result;
            }

            return content;
        }
    }
}
