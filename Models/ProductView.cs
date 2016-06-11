using AccurateBackground.Interfaces;

namespace AccurateBackground.Models
{
    public class ProductView : ProductBase
    {
        public ProductView(string pt)
        {
            productType = pt;
        }
    }
}
