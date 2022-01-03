using DrinkAndGo.Data.Interface;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Mocks.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly MyDbContext _context;

        public DrinkRepository(MyDbContext context)
        {
            _context = context;
        }
        public Drink GetDrinkById(int id)
        {
            return _context.Drinks.Where(s => s.DrinkId == id).FirstOrDefault();
        }

        public IEnumerable<Drink> Drinks()
        {
            return _context.Drinks.ToList();
        }

        public IEnumerable<Drink> GetTopDrinks()
        {
            return _context.Drinks.Where(s => s.IsPreferredDrink == true).ToList();
        }
    }
}
