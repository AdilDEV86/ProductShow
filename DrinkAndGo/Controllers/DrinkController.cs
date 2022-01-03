using DrinkAndGo.Data.Interface;
using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController( ICategoryRepository categoryRepository , IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;
            Category SelectedCategory = _categoryRepository.GetCategoryByName(category);

            if (string.IsNullOrEmpty(category)  || SelectedCategory == null)
            {
                drinks = _drinkRepository.Drinks().OrderBy(p => p.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                
                drinks = _drinkRepository.Drinks().Where(p => p.CategoryId == SelectedCategory.CategoryId).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new DrinksListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            });
        }
    }
}
