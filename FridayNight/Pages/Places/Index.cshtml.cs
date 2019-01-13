using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FridayNight.Models;
using FridayNight.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FridayNight.Pages.Places
{
    public class IndexModel : PageModel
    {
        private PlacesRepository repo = new PlacesRepository();
        public List<Category> Categories { get; set; }

        public void OnGet()
        {
            ShowCategories();
        }

        private void ShowCategories()
        {
            Categories = repo.GetAllCategories();
        }
    }
}