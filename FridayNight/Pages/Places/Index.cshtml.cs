using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FridayNight.Models;
using FridayNight.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FridayNight.Pages.Places
{
    public class IndexModel : PageModel
    {
        private PlacesRepository repo = new PlacesRepository();
        public List<Category> Categories { get; set; }
        public List<PlaceToGo> PlacesToGo { get; set; }

        public void OnGet()
        {
            ShowCategories();
            //ShowPlacesToGo();
        }

        private List<Category> ShowCategories()
        {
            Categories = repo.GetAllCategories();
            return Categories;
        }

        private List<PlaceToGo> ShowPlacesToGo()
        {
            PlacesToGo = repo.GetPlacesToGo();
            return PlacesToGo;
        }
    }
}