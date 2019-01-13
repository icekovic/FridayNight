using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FridayNight.Models;

namespace FridayNight.Repository
{
    public class PlacesRepository : IPlacesRepository
    {
        public PlacesRepository()
        {

        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            using (FridayNightContext context = new FridayNightContext())
            {
                var cat = context.Category;
                foreach (Category c in cat)
                {
                    categories.Add(c);
                }
            }

            return categories;
        }

        public List<PlaceToGo> GetPlacesToGo()
        {
            List<PlaceToGo> placesToGo = new List<PlaceToGo>();

            using (FridayNightContext context = new FridayNightContext())
            {
                var places = context.PlaceToGo;
                foreach (PlaceToGo place in places)
                {
                    placesToGo.Add(place);
                }
            }

            return placesToGo;
        }
    }
}
