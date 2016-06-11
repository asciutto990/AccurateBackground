using System.Collections.Generic;
using AccurateBackground.Enums;
using AccurateBackground.Models;

namespace AccurateBackground.Interfaces
{
    public interface ICandidate
    {
        string firstName { get; set; }
        string middleName { get; set; }
        string lastName { get; set; }
        string email { get; set; }
        string address { get; set; }
        string city { get; set; }
        string region { get; set; }

        CountryCode? country { get; set; }
        string postalCode { get; set; }
        string dateOfBirth { get; set; }
        string phone { get; set; }
        string ssn { get; set; }

        List<Alias> aliases { get; set; }
        List<Education> educations { get; set; }
        List<Employment> employments { get; set; }
        List<License> licenses { get; set; }
        List<Conviction> convictions { get; set; }
        List<Reference> references { get; set; }
        bool convicted { get; set; }
    }
}