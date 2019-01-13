using FridayNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayNight.Repository
{
    public interface IPlacesRepository
    {
        List<Category> GetAllCategories();
    }
}
