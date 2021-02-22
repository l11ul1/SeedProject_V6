using System;
using System.Collections.Generic;

#nullable disable

namespace SeedProject_V6.Models
{
    public partial class SeedProduct
    {
        public int ProductId { get; set; }
        public int? VendorId { get; set; }
        public string ProductName { get; set; }
        public SeedProductInfo ProductInfo { get; set; }
    }
}
