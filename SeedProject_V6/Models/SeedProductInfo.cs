using System;
using System.Collections.Generic;

#nullable disable

namespace SeedProject_V6.Models
{
    public partial class SeedProductInfo
    {
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImg { get; set; }
        public double? ProductRating { get; set; }
        public DateTime DateAdded { get; set; }
        public int? RatingCount { get; set; }

        public virtual SeedProduct Product { get; set; }
    }
}
