using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class License
    {
        /// <summary>
        /// allowed values: drivers-license , professional-license. Only required if license information is entered
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// type of license (*only required for category professional-license)
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// License number
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Issuing Authority (i.e. DMV )
        /// </summary>
        public string issuingAuthority { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode? country { get; set; }

        public string region { get; set; }
        public string city { get; set; }
    }

}
