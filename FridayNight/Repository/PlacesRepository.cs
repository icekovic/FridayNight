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

        public List<PlaceToGo> GetPlacesToGo(int idCategory)
        {
            List<PlaceToGo> placesToGo = new List<PlaceToGo>();

            using (FridayNightContext context = new FridayNightContext())
            {
                var places = from p in context.PlaceToGo
                             join c in context.Category on p.CategoryId equals c.Idcategory
                             where p.Category.Idcategory == idCategory
                             select p;

                foreach(PlaceToGo place in places)
                {
                    placesToGo.Add(place);
                }

                //var places = context.PlaceToGo;
                //foreach (PlaceToGo place in places)
                //{
                //    placesToGo.Add(place);
                //}
            }

            return placesToGo;
        }
    }
}
