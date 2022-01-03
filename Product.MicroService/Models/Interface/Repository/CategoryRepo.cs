using Product.MicroService.Data;
using Product.MicroService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.MicroService.Models.Interface.Repository
{
    public class CategoryRepo : ICategoryRepository
    {
        private readonly ProductDbContext _productDbContext;

        public CategoryRepo(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public IEnumerable<Category> Categories()
        {
            return _productDbContext.Categories.ToList();
        }

        public Category GetCategorieById(int idCategory)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryByName(string category)
        {
            throw new NotImplementedException();
        }
    }
}
