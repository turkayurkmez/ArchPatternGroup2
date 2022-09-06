using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IActionResult GetProducts()
        {
            //ürünleri business'dan alacak:

            return Ok();
        }
    }
}
