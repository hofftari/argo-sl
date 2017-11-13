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
        public string GetAllCampaignTemplates()
        {
            return GetReadResponseString("templates");
        }
        public string GetList(string listId)
        {
            return GetReadResponseString(string.Format("lists/{0}", listId));
        }
        public string GetListMembers(string listId)
        {
            return GetReadResponseString(string.Format("lists/{0}/members", listId));
        }
        public string GetCampaign(string campaignId)
        {
            return GetReadResponseString("campaigns/" + campaignId);
        }
        public string GetAllCampaigns()
        {
            return GetReadResponseString("campaigns");
        }
        public string GetAllLists()
        {
            return GetReadResponseString("lists");
        }
        public string EditCampaign(string campaignId, string campaignObject)
        {
            return GetPatchResponseString("campaigns/" + campaignId, campaignObject);
        }
        public string SearchForMember(string query)
        {
            return GetReadResponseString("search-members?query=" + query);
        }
        public string CreateList(string list)
        {
            return GetPostResponseString("lists", list);
        }
        public string UpsertListMembers(string listId, string memberObject)
        {
            return GetPostResponseString(string.Format("lists/{0}", listId), memberObject);
        }
        public string SetListMemberStatus(string listId, string memberId, string memberObject)
        {
            return GetPutResponseString(string.Format("lists/{0}/members/{1}", listId, memberId), memberObject);
        }
        public string RemoveListMember(string listId, string memberId)
        {
            return GetDeleteResponseString(string.Format("lists/{0}/members/{1}", listId, memberId));
        }
        public string CreateCampaign()
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
