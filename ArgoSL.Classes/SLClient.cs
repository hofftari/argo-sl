using ArgoSL.Classes.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ArgoSL.Classes
{
    public class SLClient : ISLClient
    {
        public IHttpClient ApiClient { get; }
        public SLClient(IHttpClient apiClient)
        {
            ApiClient = apiClient;
        }
        public string GetRealTimeInfoForStation(string station)
        {
            throw new NotImplementedException();
        }
        private string GetReadResponseString(string path)
        {
            string content = "";

            HttpResponseMessage response = ApiClient.GetAsync(ApiClient.ApiRoot.ToString() + "/" + path).Result;

            if (response.IsSuccessStatusCode)
            {
                content = response.Content.ReadAsStringAsync().Result;
            }

            return content;
        }
        private string GetPostResponseString(string path, string content)
        {
            string responseContent = "";

            HttpResponseMessage response = ApiClient.PostAsync(ApiClient.ApiRoot.ToString() + "/" + path, content).Result;

            if (response.IsSuccessStatusCode)
            {
                responseContent = response.Content.ReadAsStringAsync().Result;
            }

            return responseContent;
        }
        private string GetPutResponseString(string path, string content)
        {
            string responseContent = "";

            HttpResponseMessage response = ApiClient.PutAsync(ApiClient.ApiRoot.ToString() + "/" + path, content).Result;

            if (response.IsSuccessStatusCode)
            {
                responseContent = response.Content.ReadAsStringAsync().Result;
            }

            return responseContent;
        }
        private string GetPatchResponseString(string path, string content)
        {
            string responseContent = "";

            HttpResponseMessage response = ApiClient.PatchAsync(ApiClient.ApiRoot.ToString() + "/" + path, content).Result;

            if (response.IsSuccessStatusCode)
            {
                responseContent = response.Content.ReadAsStringAsync().Result;
            }

            return responseContent;
        }
        private string GetDeleteResponseString(string path)
        {
            string responseContent = "";

            HttpResponseMessage response = ApiClient.DeleteAsync(ApiClient.ApiRoot.ToString() + "/" + path).Result;

            if (response.IsSuccessStatusCode)
            {
                responseContent = response.Content.ReadAsStringAsync().Result;
            }

            return responseContent;
        }

    }
}
