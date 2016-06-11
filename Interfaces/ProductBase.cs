using AccurateBackground.Enums;

namespace AccurateBackground.Interfaces
{
    public abstract class ProductBase
    {
        /// <summary>
        /// Values for 'productType' are constants on the 'ProductType' class. For example: ProductType.TERB
        /// </summary>
        public string productType { get; set; }

        public string name
        {
            get { return GetProductName(); }
        }

        public string description 
        {
            get { return GetProductDescription(); }
        }

        /// <summary>
        /// A 'null' add on price does not mean the product is free. Accurate Background documentation says to call for pricing and setup.
        /// </summary>
        public decimal? addOnPrice
        {
            get { return GetProductAddOnPrice(); }
        }

        private string GetProductName()
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

        private string GetProductDescription()
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
                    return "Accurate Background’s National SSN/Address Locater is primarily used to identify counties where applicants reside. This search gathers information from a multitude of venues such as credit bureaus, public records (real property) and moving records from mailing houses. Accurate Background’s National SSN/Address Locater searches credit headers and association algorithms in over 20 billion records, which uncover recent relocations as well as historical addresses. This nationwide search provides summaries of the applicant’s name, name variations (such as maiden or previous names), date of birth, current address, and phone number.Our National SSN/Address Locater is a comprehensive tool which differentiates our service from others who use traditional credit report headers. Using our tool, Accurate Background tends to identify 30-50% more counties. (Most traditional credit headers are limited to three prior addresses.)";
                case ProductType.MVR:
                    return "The Motor Vehicle Report queries the applicant’s State Department of Motor Vehicles and provides a 3 to 5 year driving history on the applicant. Out of state driving related charges and vehicle-related crimes are frequently included on the report.";
                case ProductType.EDU:
                    return "The Education Verification confirms credential earned by academic institution.";
                case ProductType.EMP:
                    return "The Employment Verification contacts past or current employer to verify information provided on application.";
                case ProductType.FACIS1:
                    return "Accurate Background provides information drawn from more than 1000 government agencies and over 555,000 records of sanctioned health care providers including the DHHS OIG, State Medicaid Fraud Control Units, State Health Departments, Tri-Care, Licensing & Disciplinary Agencies, DEA, FDA, and GSA. We search the Federal, Medicare, Medicaid Sanctions listing of individuals or entities that are prohibited from participating in government programs and information on fraud abuse specific to the medical industry. FACIS® is a registered trademark of Verisys Corporation.";
                case ProductType.FACIS:
                    return "Accurate Background provides information drawn from more than 1000 government agencies and over 555,000 records of sanctioned health care providers including the DHHS OIG, State Medicaid Fraud Control Units, State Health Departments, Tri-Care, Licensing & Disciplinary Agencies, DEA, FDA, and GSA. We search the Federal, Medicare, Medicaid Sanctions listing of individuals or entities that are prohibited from participating in government programs and information on fraud abuse specific to the medical industry. FACIS® is a registered trademark of Verisys Corporation.";
                case ProductType.PLV:
                    return "Confirm that your applicant is fully licensed in their field (ex. medical practitioners, certified public accountants, insurance agents etc.) Accurate Background contacts the issuing state authority to verify license status. When available, date of issuance and expiration will also be provided along with any disciplinary action on file.";
                case ProductType.REF1:
                    return "Brief phone interviews are conducted with former supervisors using customized open-ended questions to facilitate a meaningful dialogue. Our clients are welcome to develop their own set of questions or use a recommended template that Accurate Background can provide.";
                case ProductType.OFAC:
                    return "The OFAC of the U.S. Department of the Treasury administers and enforces economic and trade sanctions based on U.S. foreign policy and national security goals against targeted foreign countries, terrorists, international narcotics traffickers, and those engaged in activities related to the proliferation of weapons of mass destruction. OFAC acts under Presidential wartime and national emergency powers, as well as authority granted by specific legislation, to impose controls on transactions and freeze foreign assets under U.S. jurisdiction. This information is obtained directly from the Office of Foreign Assets Control through an electronic download and searched for the specific subjects of the inquiry.";
                case ProductType.CIV:
                    return "Provide a summary of civil suits filed by or against the applicant. Accurate will provide a summary of the complaint and final order, or if a case is pending, a summary of the status of the suit.";
                case ProductType.FEDBK:
                    return "Accurate Background’s Federal Bankruptcy product searches the federal district within the state for any bankruptcies filed by the applicant and/or a business entity. Searches are conducted using the case number, party name, Social Security number, or tax identification number. Accurate Background will provide your organization with a summary of the case history and the final order from the applicable Federal Court, or if a case is pending, a summary of the status of the case.";
                case ProductType.FEDCV:
                    return "Searches the federal district within the state for any claims filed by the applicant against the United States Government (such as discrimination, copyright infringements or civil right issues). Accurate Background will provide a summary of the complaint and the final order, or if a case is pending, a summary of the status of the suit.";
                case ProductType.FEDCR:
                    return "Accurate Background’s Federal Criminal Searches retrieve state level records from Federal District courts to discover crimes committed against the United States Government. Federal Criminal Searches reveal offenses such as bank robbery, tax evasion, Internet crimes, and mail fraud.";
                default:
                    return null;
            }
        }

        private decimal? GetProductAddOnPrice()
        {
            switch (productType)
            {
                case ProductType.NCRIM:
                    return 8;
                case ProductType.TERB:
                    return 4;
                case ProductType.MOV:
                    return 4;
                case ProductType.MVR:
                    return 4;
                case ProductType.EDU:
                    return 11;
                case ProductType.EMP:
                    return 11;
                case ProductType.FACIS1:
                    return 7;
                case ProductType.FACIS:
                    return 11;
                case ProductType.PLV:
                    return 9;
                case ProductType.REF1:
                    return 21;
                case ProductType.OFAC:
                    return 6;
                case ProductType.CIV:
                    return 14;
                case ProductType.FEDCR:
                    return 9;
                case ProductType.FEDBK:
                    return 9;
                case ProductType.FEDCV:
                    return 9;
                default:
                    return (decimal?)null;
            }
        }
    }
}
