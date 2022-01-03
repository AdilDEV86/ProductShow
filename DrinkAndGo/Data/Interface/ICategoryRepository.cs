using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories();
        Category GetCategorieById(int idCategory);

        Category GetCategoryByName(string category);
    }
}
