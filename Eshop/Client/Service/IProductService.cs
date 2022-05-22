using Eshop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eshop.Client.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task AddProduct(Product product);
        Task UpdateProduct(Product product, int id);
        Task DeleteProduct(int id);
    }
}
