using System;
using System.Collections.Generic;
using AccurateBackground.Enums;
using AccurateBackground.Interfaces;
using AccurateBackground.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccurateBackground.Resources
{
    public class Candidate : ICandidate
    {
        public string id { get; set; }

        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string region { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode? country { get; set; }

        public string postalCode { get; set; }
        public string dateOfBirth { get; set; }
        public string phone { get; set; }
        public string ssn { get; set; }

        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public int revision { get; set; }
        public Government governmentId { get; set; }
        public List<Alias> aliases { get; set; }
        public List<Education> educations { get; set; }
        public List<Employment> employments { get; set; }
        public List<License> licenses { get; set; }
        public List<Conviction> convictions { get; set; }
        public List<Reference> references { get; set; }
        public bool? convicted { get; set; }
    }
}