using System.Collections.Generic;

namespace AccurateBackground.Http.Models
{
    public class AccurateErrorResponse
    {
        public IEnumerable<AccurateError> errors { get; set; }

        public class AccurateError
        {
            public string code { get; set; }
            public string message { get; set; }
            public string param { get; set; }
        }
    }
}
