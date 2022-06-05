using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ProductController : ControllerBase
    {
        public ActionResult<IEnumerable<string>> GetProducts()
        {
            return new string[] { "Product 1", "Product 2" };
        }
    }
}
