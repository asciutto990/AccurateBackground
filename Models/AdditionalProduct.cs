using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class AdditionalProduct
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductType productType { get; set; }
    }
}