using System.Collections;
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
            var keyValuePairs = GetKeyValuePairs(input);
            var content = new FormUrlEncodedContent(keyValuePairs);
            content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded");
            return content;
        }

        private static IEnumerable<KeyValuePair<string, string>> GetKeyValuePairs(T input)
        {
            foreach (var keyValuePair in GetKeyValuePairsOfNonGenericTypes(input)) 
                yield return keyValuePair;

            foreach (var keyValuePair1 in GetKeyValuePairsOfGenericTypes(input)) 
                yield return keyValuePair1;
        }

        private static IEnumerable<KeyValuePair<string, string>> GetKeyValuePairsOfNonGenericTypes(T input)
        {
            return input.GetType().GetProperties()
                .Where(x => x.GetValue(input, null) != null && !x.GetValue(input, null).GetType().IsGenericType)
                .Select(prop => new KeyValuePair<string, string>(prop.Name, GetValueOfProperty(prop, input)));
        }

        private static IEnumerable<KeyValuePair<string, string>> GetKeyValuePairsOfGenericTypes(T input)
        {
            var genericTypes = input.GetType().GetProperties()
                .Where(x => x.GetValue(input, null) != null && x.GetValue(input, null).GetType().IsGenericType);

            foreach (var genericType in genericTypes)
            {
                var name = genericType.Name;
                var nestedObjects = (IList) genericType.GetValue(input, null);
                foreach (var obj in nestedObjects)
                {
                    var obj1 = obj;
                    var properties = obj.GetType().GetProperties().Where(y => y.GetValue(obj1, null) != null);
                    foreach (var prop in properties)
                    {
                        yield return new KeyValuePair<string, string>(
                            name + "[" + nestedObjects.IndexOf(obj) + "]." + prop.Name,
                            GetValueOfProperty(prop, obj));
                    }
                }
            }
        }

        private static string GetValueOfProperty(PropertyInfo prop, object obj)
        {
            bool boolParsed;
            var value = prop.GetValue(obj, null).ToString();
            return bool.TryParse(value, out boolParsed) ? value.ToLower() : value;
        }
    }
}
