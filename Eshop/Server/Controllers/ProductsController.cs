using Eshop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;

namespace Eshop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient _client;
        public ProductsController(ApplicationDbContext context, HttpClient client)
        {
            _context = context;
            _client = client;
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

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var deletedProduct = GetProductById(id);

                if(deletedProduct == null)
                {
                    return NotFound($"Product with Id = {id} is not found!");
                }
                else
                {
                    var test = DeleteProductFromDatabase(id);
                    return Ok(test);
                }
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
            }
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product DeleteProductFromDatabase(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if(product == null)
            {
                return null;
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return product;
        }

        [Route("api/reqres")]
        public IActionResult GetReqresData()
        {
            //await HttpClient.GetFromJsonAsync<List<Generic>>("https://reqres.in/api/users");

            var reqres = _client.GetStringAsync("https://reqres.in/api/users");

            return Ok(reqres);
        }
    }
}
