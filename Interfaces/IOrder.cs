using System.Collections.Generic;
using AccurateBackground.Enums;
using AccurateBackground.Models;

namespace AccurateBackground.Interfaces
{
    public interface IOrder
    {
        string candidateId { get; set; }
        PackageType packageType { get; set; }
        Workflow workflow { get; set; }
        JobLocation jobLocation { get; set; }
        bool copyOfReport { get; set; }
        string[] referenceCodes { get; set; }
        string clientComments { get; set; }
        List<AdditionalProduct> additionalProductTypes { get; set; }
    }
}
