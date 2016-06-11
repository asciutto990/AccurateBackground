using AccurateBackground.Enums;

namespace AccurateBackground.Models
{
    public class Product
    {
        public string id { get; set; }

        /// <summary>
        /// Values for 'productType' are constants on the 'ProductType' class. For example: ProductType.TERB
        /// </summary>
        public string productType { get; set; }

        public string status { get; set; }
        public string result { get; set; }
        public bool flag { get; set; }

        public string name
        {
            get
            {
                switch (productType)
                {
                    case ProductType.NCRIM:
                        return "National Criminal Database";
                    case ProductType.FM:
                        return "County Criminal (As Needed)";
                    case ProductType.TERB:
                        return "Global Watch";
                    case ProductType.MOV:
                        return "SSN/National Address Locator";
                    case ProductType.MVR:
                        return "Motor Vehicle Report";
                    case ProductType.EDU:
                        return "Education Verification";
                    case ProductType.EMP:
                        return "Employment Verification";
                    case ProductType.FACIS1:
                        return "FACIS Level 1";
                    case ProductType.FACIS:
                        return "FACIS Level 3";
                    case ProductType.SON:
                        return "National Sex Offender Registry";
                    case ProductType.PLV:
                        return "Professional License Verification";
                    case ProductType.REF1:
                        return "Professional Reference";
                    case ProductType.DL5CUP:
                        return "5 Panel Drug Test (eCUP)";
                    case ProductType.DL5:
                        return "5 Panel Drug Test (Lab-Based)";
                    case ProductType.DL7:
                        return "7 Panel Drug Test (Lab-Based)";
                    case ProductType.DL10:
                        return "10 Panel Drug Test (Lab-Based)";
                    case ProductType.OFAC:
                        return "Office of Foreign Asset Control (OFAC)";
                    case ProductType.CIV:
                        return "Single County Civil Search";
                    case ProductType.I9FA:
                        return "I-9 Form";
                    case ProductType.EVA:
                        return "E-Verify";
                    case ProductType.FEDCR:
                        return "Federal Criminal District Search (single)";
                    case ProductType.FEDBK:
                        return "Federal Bankruptcy";
                    case ProductType.FEDCV:
                        return "Federal Civil Search";
                    default:
                        return null;
                }
            }
        }

        public string description
        {
            get
            {
                switch (productType)
                {
                    case ProductType.NCRIM:
                        return "Our National Criminal Database is a proprietary database compiled from US court records. The data is sourced from county courts, statewide criminal databases, as well as sex offender and correctional databases. The National Criminal Database is updated on a weekly or monthly basis depending on the original source.";
                    case ProductType.FM:
                        return "The County Criminal History will confirm potential criminal history uncovered by the National Criminal Database as required by the FCRA. These searches return results of offenses, charges, file numbers, file dates, disposition and sentences. Our organization has the capability to conduct searches in any county in the United States. Note: The Basic NCRIM+ package price does not include additional statutory/access fees that could be incurred during the process.";
                    case ProductType.TERB:
                        return "Global Watch helps your company comply with the USA Patriot Act, Bank Secrecy Act, Politically Exposed Persons (PEP) Screening, Office of Foreign Assets Control (OFAC), and many other terrorist and fraud searches by gathering current data from top U.S. and Global official sanction and embargo lists.";
                    case ProductType.MOV:
                        return "Provides summaries of the applicant’s name, name variations, and previous addresses for further investigation.";
                    case ProductType.FACIS1:
                        return "Federal Databases Only";
                    case ProductType.FACIS:
                        return "Federal and all State Databases";
                    default:
                        return null;
                }
            }
        } 
    }
}