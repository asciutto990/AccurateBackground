using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class Education
    {
        public string school { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode? country { get; set; }

        public string region { get; set; }
        public string city { get; set; }
        public string degree { get; set; }
        public string major { get; set; }

        /// <summary>
        /// Format date as year and month: yyyy-mm
        /// </summary>
        public string startDate { get; set; }

        /// <summary>
        /// Format date as year and month: yyyy-mm
        /// </summary>
        public string endDate { get; set; }

        public bool graduated { get; set; }

        /// <summary>
        /// Format date as year and month: yyyy-mm
        /// </summary>
        public string graduationDate { get; set; }

        public bool presentlyEnrolled { get; set; }
    }
}
