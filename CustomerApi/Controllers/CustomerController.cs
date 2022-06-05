using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class CustomerController : ControllerBase
    {
        //
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetCustomers()
        {
            return new string[] { "Customer 1","Customer 2"};
        }
    }
}
