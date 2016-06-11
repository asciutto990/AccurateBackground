using AccurateBackground.Enums;
using AccurateBackground.Interfaces;

namespace AccurateBackground.Models
{
    public class Product : ProductBase
    {
        public string id { get; set; }

        public string status { get; set; }
        public string result { get; set; }
        public bool flag { get; set; }
    }
}
