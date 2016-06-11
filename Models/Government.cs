using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class Government
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode? country { get; set; }

        public string type { get; set; }
        public string number { get; set; }
    }
}