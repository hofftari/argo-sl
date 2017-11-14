using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ArgoSL.Types.Interfaces
{
    public interface IHttpClient
    {
        HttpClient ApiClient { get; }
        Uri ApiRoot { get; set; }
        Task<HttpResponseMessage> GetAsync(string relativeRequestUri);
        Task<HttpResponseMessage> PostAsync(string relativeRequestUri, string content);
        Task<HttpResponseMessage> PutAsync(string relativeRequestUri, string content);
        Task<HttpResponseMessage> PatchAsync(string relativeRequestUri, string content);
        Task<HttpResponseMessage> DeleteAsync(string relativeRequestUri);
    }
}
