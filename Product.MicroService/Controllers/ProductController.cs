using Microsoft.AspNetCore.Mvc;
using Product.MicroService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.MicroService.Controllers
{


    [ApiController]
    [Route("api/p")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // GET: api/values
        [HttpGet("products")]
        public ActionResult<IEnumerable<Models.Product>> Get()
        {
            return  _productRepository.Products().ToList();
        }

        // GET: api/values/5
        [HttpGet("products/{id}")]
        public ActionResult<Models.Product> Get(int id)
        {
            Models.Product _product = _productRepository.GetProductById(id);
            if (_product == null)
                return NotFound();
            return _product;
        }

        // POST: api/values
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/values/5
        public void Delete(int id)
        {
        }
    }
}
