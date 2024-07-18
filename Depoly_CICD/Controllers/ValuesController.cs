using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Depoly_CICD.Controllers
{
    [Route("api/depoly")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Result()
        {
            return "Check in GITHUB new";
        }



    }
}
