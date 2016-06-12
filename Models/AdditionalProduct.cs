using AccurateBackground.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Models
{
    public class AdditionalProduct
    {
        public AdditionalProduct(string product_type)
        {
            productType = product_type;
        }

        public string productType { get; set; }
    }
}