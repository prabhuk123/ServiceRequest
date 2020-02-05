using System;
using System.ComponentModel.DataAnnotations;

namespace servicerequest.api.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }

        public string ProductName { get; set; }
    }
}
