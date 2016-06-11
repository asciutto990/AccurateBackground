using System;

namespace AccurateBackground.Http.Models
{
    public class AccurateErrorResponseException : InvalidOperationException
    {
        public AccurateErrorResponse ErrorResponse;
        public AccurateErrorResponseException(AccurateErrorResponse e, string message)
            : base(message)
        {
            ErrorResponse = e;
        }
    }
}
