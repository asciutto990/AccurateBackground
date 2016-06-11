using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class Reference
    {
        public string name { get; set; }
        public string relationship { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode? country { get; set; }

        public string region { get; set; }
        public string postalCode { get; set; }
    }
}
