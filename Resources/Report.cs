using System;
using System.Text;

namespace AccurateBackground.Resources
{
    public class Report
    {
        public string id { get; set; }
        public DateTime created { get; set; }
        public string supportReferenceId { get; set; }
        public string reportFormat { get; set; }
        public string report { get; set; }

        public string html
        {
            get
            {
                var data = Convert.FromBase64String(report);
                return Encoding.UTF8.GetString(data);
            }
        }
    }
}