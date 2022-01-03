using DrinkAndGo.Data.Interface;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Mocks.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly MyDbContext _context;

        public CategoryRepository(MyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Categories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategorieById(int idCategory)
        {
            return _context.Categories.Where(c => c.CategoryId == idCategory).FirstOrDefault();
        }

        public Category GetCategoryByName(string category)
        {
            return _context.Categories.Where(c => c.CategoryName == category).FirstOrDefault();
        }
    }
}
