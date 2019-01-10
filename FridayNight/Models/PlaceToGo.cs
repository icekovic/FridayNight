using System;
using System.Collections.Generic;

namespace FridayNight.Models
{
    public partial class PlaceToGo
    {
        public int IdplaceToGo { get; set; }
        public string Name { get; set; }
        public string PriceRange { get; set; }
        public string Address { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
