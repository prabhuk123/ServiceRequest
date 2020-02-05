using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace servicerequest.api.Models
{
    public class ServiceRequests
    {
        [Key]
        public long ServiceRequestId { get; set; }
        public string Name { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }

        public long ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }

        public long ProductServiceId { get; set; }

        public ProductServices ProductServices { get; set; }

        public string ServiceTiming { get; set; }
    }
}
