using System.Collections.Generic;
using cmdrAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace cmdrAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly CommandContext _context;

        public CommandsController(CommandContext context)
        {
            _context = context;
        }

        //GET: api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            return _context.CommandItems;
        }
    }
}