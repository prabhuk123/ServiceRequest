using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace servicerequest.api.Models
{
    public class ProductServices
    {
        [Key]
        public long ProductServiceId { get; set; }

        public string ProductServiceName { get; set; }

        public long ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }
    }
}
