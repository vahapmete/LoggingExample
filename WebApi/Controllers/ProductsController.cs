using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            Product productResponse = new Product(product.Id, product.Name);
            return Ok(product);
        }
    }
}
