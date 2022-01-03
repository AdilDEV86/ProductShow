using Product.MicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.MicroService.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Models.Product> Products();
        Models.Product GetProductById(int id);

        IEnumerable<Models.Product> GetTopProducts();

    }
}
