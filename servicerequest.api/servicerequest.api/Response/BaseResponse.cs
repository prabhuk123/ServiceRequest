using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicerequest.api.Response
{
    public abstract class BaseResponse
    {
        public BaseResponse()
        {

        }

        public bool Success { get; protected set; }
        public string Message { get; protected set; }

        public BaseResponse(bool success, string failures)
        {
            Success = success;
            Message = failures;
        }
    }
}
