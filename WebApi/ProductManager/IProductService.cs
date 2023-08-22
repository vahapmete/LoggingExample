using WebApi.Models;

namespace WebApi.ProductManager
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task<List<Product>> GetProducts();

    }
}
