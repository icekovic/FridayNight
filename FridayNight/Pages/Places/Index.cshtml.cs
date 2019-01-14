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
        //public List<SelectListItem> CategoriesSelectList { get; set; }
        public Category Category { get; set; }
        public SelectList CategoriesSelectList { get; set; }
        private List<Category> Categories { get; set; }

        public void OnGet()
        {
            ShowCategories();
            //ShowPlacesToGo();
        }

        private void ShowCategories()
        {
            Categories = repo.GetAllCategories();
            CategoriesSelectList = new SelectList(Categories, "Idcategory", "Name");

            //foreach(Category category in Categories)
            //{
            //    CategoriesSelectList = new List<SelectListItem>()
            //    {
            //        new SelectListItem { Value = category.Idcategory.ToString(), Text = category.Name}
            //    };
            //}
        }
    }
}