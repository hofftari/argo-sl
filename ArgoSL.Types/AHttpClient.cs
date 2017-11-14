using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using ArgoSL.Types.Interfaces;

namespace ArgoSL.Types
{
    public class AHttpClient : IHttpClient
    {
        private static HttpClient _ApiClient;
        public HttpClient ApiClient
        {
            get
            {
                if (_ApiClient == null)
                {
                    _ApiClient = new HttpClient();
                    return _ApiClient;
                }
                else
                {
                    return _ApiClient;
                }
            }
        }
        public Uri ApiRoot { get; set; }
        public AHttpClient()
        {
            
        }
        //public AHttpClient(string user, string apiRoot, string apiKey)
        //{
        //    ApiRoot = new Uri(apiRoot);
        //    var byteArray = Encoding.ASCII.GetBytes(user + ":" + apiKey);
        //    ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        //}
        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return ApiClient.GetAsync(new Uri(requestUri));
        }
        public Task<HttpResponseMessage> PostAsync(string relativeRequestUri, string content)
        {
            return ApiClient.PostAsync(new Uri(ApiRoot, relativeRequestUri), new StringContent(content));
        }
        public Task<HttpResponseMessage> PutAsync(string relativeRequestUri, string content)
        {
            return ApiClient.PutAsync(new Uri(ApiRoot, relativeRequestUri), new StringContent(content));
        }
        public Task<HttpResponseMessage> DeleteAsync(string relativeRequestUri)
        {
            return ApiClient.DeleteAsync(new Uri(ApiRoot, relativeRequestUri));
        }
        public Task<HttpResponseMessage> PatchAsync(string relativeRequestUri, string content)
        {
            var method = new HttpMethod("PATCH");

            var request = new HttpRequestMessage(method, new Uri(ApiRoot, relativeRequestUri));
            request.Content = new StringContent(content);

            return ApiClient.SendAsync(request);
        }

    }
}
