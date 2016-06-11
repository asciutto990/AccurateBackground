using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class Conviction
    {
        /// <summary>
        /// Format date as yyyy-mm-dd
        /// </summary>
        public string convictionDate { get; set; }

        public string description { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode? country { get; set; }
        public string region { get; set; }
        public string region2 { get; set; }
        public string city { get; set; }
    }
}
