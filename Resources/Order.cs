using System;
using System.Collections.Generic;
using AccurateBackground.Enums;
using AccurateBackground.Interfaces;
using AccurateBackground.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Resources
{
    public class Order : IOrder
    {
        public string id { get; set; }

        public string candidateId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PackageType packageType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Workflow workflow { get; set; }

        public JobLocation jobLocation { get; set; }
        public bool? copyOfReport { get; set; }
        public string[] referenceCodes { get; set; }
        public string clientComments { get; set; }

        public DateTime created { get; set; }
        public DateTime? submitted { get; set; }
        public DateTime updated { get; set; }
        public DateTime? completed { get; set; }

        public Candidate candidate { get; set; }
        public bool candidateInfoComplete { get; set; }
        public string supportReferenceId { get; set; }
        public string reportUrl { get; set; }

        public string status { get; set; }
        public string result { get; set; }

        public List<Product> products { get; set; }
        public int percentageComplete { get; set; }

        public List<AdditionalProduct> additionalProductTypes { get; set; }
    }
}
