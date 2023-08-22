using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Firebase;
using WebApi.Models;
using WebApi.ProductManager;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController( IProductService productService)
        {
            _productService = productService;
        }
      
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] string productName)
        {
            Product product = new Product() {Name = productName};
            Product productResponse=  await _productService.AddProduct(product);
            return Ok(productResponse);
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
           
            List<Product> productResponse=  await _productService.GetProducts();
            return Ok(productResponse);
        }
    }
}
