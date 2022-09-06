using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shop.Services;

namespace shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;   
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            //ürünleri business'dan alacak:         

            return Ok(_productService.GetProducts());
        }
    }
}
