using ServiceRequestModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeServiceModels
{
    public class ServiceRequests
    {
        public string Name { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }

        public long ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }

        public TimeSpan ServieTiming { get; set; }
    }
}
