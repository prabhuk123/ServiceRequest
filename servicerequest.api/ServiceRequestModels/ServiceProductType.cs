using ServiceRequestModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeServiceModels
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}
