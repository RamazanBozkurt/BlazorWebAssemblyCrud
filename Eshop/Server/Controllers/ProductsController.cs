using Eshop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Eshop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var response = _context.Products.ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var response = _context.Products.Where(p => p.Id == id).FirstOrDefault();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product, int id)
        {
            _context.Products.Update(product);
            _context.SaveChanges();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var deletedProduct = _context.Products.Where(p => p.Id == id).FirstOrDefault();

            _context.Products.Remove(deletedProduct);
            _context.SaveChanges();

            return Ok();
        }
    }
}
