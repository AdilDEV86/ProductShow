using Product.MicroService.Data;
using Product.MicroService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.MicroService.Models.Interface.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _productDbContext;

        public ProductRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public Product GetProductById(int id)
        {
            return _productDbContext.Products.Where(p => p.ProductId == id).FirstOrDefault();
        }

        public IEnumerable<Product> GetTopProducts()
        {
            return _productDbContext.Products.Where(p => p.IsPreferredDrink == true).ToList();
        }

        public IEnumerable<Product> Products()
        {
            return _productDbContext.Products.ToList();
        }
    }
}
