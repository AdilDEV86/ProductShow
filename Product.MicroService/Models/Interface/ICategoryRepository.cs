using Product.MicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.MicroService.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories();
        Category GetCategorieById(int idCategory);

        Category GetCategoryByName(string category);
    }
}
