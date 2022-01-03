using DrinkAndGo.Data.Interface;
using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Components
{
 

        public class ShoppingCartSummary : ViewComponent
        {
            private readonly ShoppingCart _shoppingCart;
        private readonly ICategoryRepository _categorieRepository;

        public ShoppingCartSummary(ShoppingCart shoppingCart,ICategoryRepository categorieRepository)
            {
                _shoppingCart = shoppingCart;
                _categorieRepository = categorieRepository;
            }

            public IViewComponentResult Invoke()
            {
             var items = _shoppingCart.GetShoppingCartItems();
           // var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem() };
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                Categories = _categorieRepository.Categories().ToList(),
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
                    
                };
                return View(shoppingCartViewModel);
            }


        }

    
}
