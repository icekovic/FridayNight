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

        //public Category Category { get; set; }
        //public SelectList CategoriesSelectList { get; set; }
        public List<Category> Categories { get; set; }
        public List<PlaceToGo> PlacesToGo { get; set; }

        public void OnGet()
        {
            ShowCategories();
            ShowPlacesToGo();
        }

        private void ShowCategories()
        {
            Categories = repo.GetAllCategories();
            //CategoriesSelectList = new SelectList(Categories, "Idcategory", "Name");
        }

        private void ShowPlacesToGo()
        {
            //string selectedCategory = Request.Form["CategoriesSelectList"].ToString();
            //PlacesToGo = repo.GetPlacesToGo(1);
        }
    }
}