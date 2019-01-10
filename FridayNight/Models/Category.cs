using System;
using System.Collections.Generic;

namespace FridayNight.Models
{
    public partial class Category
    {
        public Category()
        {
            PlaceToGo = new HashSet<PlaceToGo>();
        }

        public int Idcategory { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PlaceToGo> PlaceToGo { get; set; }
    }
}
