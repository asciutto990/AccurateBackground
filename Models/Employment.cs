using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class Employment
    {
        /// <summary>
        /// name of company candidate was previously employed. Only required if PrevEmployed is “true.”
        /// </summary>
        public string employer { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode? country { get; set; }

        public string region { get; set; }
        public string city { get; set; }

        /// <summary>
        /// In the format: yyyy-mm, start date at company. Only required if employment information is entered.
        /// </summary>
        public string startDate { get; set; }

        /// <summary>
        /// In the format: yyyy-mm, end date at company. Only required if employment information is entered.
        /// </summary>
        public string endDate { get; set; }

        /// <summary>
        /// Current employer? presentlyEmployed will default as “false” when no value is provided
        /// </summary>
        public bool presentlyEmployed { get; set; }

        public string position { get; set; }
        public string supervisor { get; set; }
        public string reasonForLeaving { get; set; }

        /// <summary>
        /// ok to contact employer? okToCall will default as “true” when no value is provided
        /// </summary>
        public bool okToCall { get; set; }

        public string phone { get; set; }

        public string salary { get; set; }
    }
}
