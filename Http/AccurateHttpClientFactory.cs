using System;
using System.Configuration;
using System.Net.Http.Headers;
using System.Text;

namespace AccurateBackground.Http
{
    public static class AccurateHttpClientFactory
    {
        private const string BaseUrl = "https://api.accuratebackground.com/v3/";

        public static AccurateHttpClient Get()
        {
            var client = new AccurateHttpClient()
            {
                BaseAddress = new Uri(BaseUrl)
            };

            var clientId = ConfigurationManager.AppSettings["AccurateBackgroundClientId"];
            var clientSecret = ConfigurationManager.AppSettings["AccurateBackgroundClientSecret"];
            if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
                throw new InvalidOperationException(
                    "Please provide an AccurateBackgroundClientId and AccurateBackgroundClientSecret value in your App Settings");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var credentials = string.Format("{0}:{1}", clientId, clientSecret);
            var encodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encodedCredentials);
            return client;
        }
    }
}
