using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace cmdrAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAction()
        {
            return new string[] {"this", "is", "hard", "coded!"};
        }
    }
}