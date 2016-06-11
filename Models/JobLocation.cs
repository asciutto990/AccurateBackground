using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class JobLocation
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode? country { get; set; }

        public string region { get; set; }
        public string region2 { get; set; }
        public string city { get; set; }
    }
}