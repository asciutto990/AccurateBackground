using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using Newtonsoft.Json;

namespace AccurateBackground.Http
{
    public static class AccurateHttpRequestFactory<T>
    {
        public static StringContent BuildPostRequest(T input)
        {
            var serializedObject = JsonConvert.SerializeObject(input);
            var content = new StringContent(serializedObject);
            content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            return content;
        }

        public static FormUrlEncodedContent BuildPutRequest(T input)
        {
            var keyValuePair = input.GetType().GetRuntimeProperties()
                .Where(x => x.GetValue(input, null) != null)
                .Select(x => new KeyValuePair<string, string>(x.Name, x.GetValue(input, null).ToString()));

            var message = new FormUrlEncodedContent(keyValuePair);
            message.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded");
            return message;
        }
    }
}
