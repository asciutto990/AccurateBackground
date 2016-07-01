using System.Collections.Generic;
using AccurateBackground.Enums;
using AccurateBackground.Interfaces;
using AccurateBackground.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.InputModels
{
    public class OrderInput : IOrder
    {
        /// <summary>
        /// Describes the candidate for which the order is being placed
        /// </summary>
        public string candidateId { get; set; }

        /// <summary>
        /// PKG_BASIC (Criminal History (National)) includes checks of the National Criminal Database Search, One Name Submission.
        /// PKG_STANDARD (Criminal and Address Check (National and Local)) Includes National and County criminal history, Global terror watchlist.
        /// PKG_PRO (7-year Criminal History and Address Check) SSN address trace, National Criminal search, and seven-year historical check at county criminal level.
        /// PKG_EMPTY (An empty package) You can add searches to build a custom package
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PackageType packageType { get; set; }

        /// <summary>
        /// In the EXPRESS workflow, the developer is responsible for providing all the required Candidate information in the Candidate resource.
        /// In the INTERACTIVE workflow, an email to a secure data collection form will be sent to the candidate to record their consent to the background check and all the required information necessary to conduct the checks.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Workflow workflow { get; set; }

        public JobLocation jobLocation { get; set; }

        /// <summary>
        /// Describes if a copy of the final report detail needs to be sent to the candidate. Options are: true, false
        /// </summary>
        public bool? copyOfReport { get; set; }

        /// <summary>
        /// Reference codes. Array of strings, support up to a maximum of 4 elements. Zero based index.
        /// </summary>
        public string[] referenceCodes { get; set; }

        /// <summary>
        /// Any comments on the order
        /// </summary>
        public string clientComments { get; set; }

        /// <summary>
        /// Choose any number of additional product types to run on the given Candidate. This can include foreign country searches, extra drug screens, etc
        /// </summary>
        public List<AdditionalProduct> additionalProductTypes { get; set; }
    }
}
