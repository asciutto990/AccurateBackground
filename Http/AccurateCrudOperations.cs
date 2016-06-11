﻿using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AccurateBackground.Http
{
    public static class AccurateCrudOperations
    {
        public static async Task<TOutput> GetAsync<TOutput>(string endpoint)
        {
            using (var client = AccurateHttpClientFactory.Get())
            {
                var response = await client.GetAsync(endpoint).ConfigureAwait(false);
                var stringifiedResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<TOutput>(stringifiedResponse);
            }
        }

        public static async Task<TOutput> CreateAsync<TInput, TOutput>(string endpoint, TInput input)
        {
            using (var client = AccurateHttpClientFactory.Get())
            {
                var response = await client.PostAsync(endpoint, input).ConfigureAwait(false);
                var stringifiedResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<TOutput>(stringifiedResponse);
            }
        }

        public static async Task<TOutput> UpdateAsync<TInput, TOutput>(string endpoint, TInput input)
        {
            using (var client = AccurateHttpClientFactory.Get())
            {
                var response = await client.PutAsync(endpoint, input).ConfigureAwait(false);
                var stringifiedResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<TOutput>(stringifiedResponse);
            }
        }
    }
}