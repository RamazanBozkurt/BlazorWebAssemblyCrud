using Eshop.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Eshop.Client.Service
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public ProductService(HttpClient client)
        {
            _client = client;
        }

        public async Task AddProduct(Product product)
        {
            await _client.PostAsJsonAsync("api/products", product);
        }

        public async Task DeleteProduct(int id)
        {
            await _client.DeleteAsync($"api/products/{id}");
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _client.GetFromJsonAsync<Product>($"api/products/{id}");
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _client.GetFromJsonAsync<List<Product>>("api/products");    
        }

        public async Task UpdateProduct(Product product, int id)
        {
            await _client.PutAsJsonAsync("api/product", product);
        }
    }
}
