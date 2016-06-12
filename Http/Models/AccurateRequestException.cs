using System;

namespace AccurateBackground.Http.Models
{
    public class AccurateRequestException : InvalidOperationException
    {
        public AccurateErrorResponse ErrorResponse;
        public AccurateRequestException(AccurateErrorResponse e, string message)
            : base(message)
        {
            ErrorResponse = e;
        }
    }
}
