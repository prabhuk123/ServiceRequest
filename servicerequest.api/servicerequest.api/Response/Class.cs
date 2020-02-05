using servicerequest.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicerequest.api.Response
{
    public class SaveServiceRequestsResponse : BaseResponse
    {
        public ServiceRequests ServiceRequests { get; private set; }

        private SaveServiceRequestsResponse(bool success, string message, ServiceRequests serviceRequests) : base(success, message)
        {
            ServiceRequests = serviceRequests;
        }

        public SaveServiceRequestsResponse(ServiceRequests serviceRequests) : this(true, string.Empty, serviceRequests)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveServiceRequestsResponse(string message) : this(false, message, null)
        { }
    }

}
