namespace AccurateBackground.Models
{
    public class Report
    {
        public string base64encodedHTML { get; set; }
        public string reportId => base64encodedHTML.Replace("/report/", string.Empty);
    }
}