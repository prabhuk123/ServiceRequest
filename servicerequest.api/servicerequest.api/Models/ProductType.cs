using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace servicerequest.api.Models
{
    public class ProductType
    {
        [Key]
        public long ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }
    }
}
