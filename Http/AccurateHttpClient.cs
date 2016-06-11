using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AccurateBackground.Http
{
    public class AccurateHttpClient : HttpClient
    {
        public new Task<HttpResponseMessage> GetAsync(string endpoint)
        {
            var uri = new Uri(BaseAddress + endpoint);
            return base.GetAsync(uri);
        }

        public Task<HttpResponseMessage> PostAsync<T>(string endpoint, T input)
        {
            var uri = new Uri(BaseAddress + endpoint);
            var requestContent = AccurateHttpRequestFactory<T>.BuildPostRequest(input);
            return base.PostAsync(uri, requestContent);
        }

        public Task<HttpResponseMessage> PutAsync<T>(string endpoint, T input)
        {
            var uri = new Uri(BaseAddress + endpoint);
            var requestContent = AccurateHttpRequestFactory<T>.BuildPutRequest(input);
            return base.PutAsync(uri, requestContent);
        }
    }
}