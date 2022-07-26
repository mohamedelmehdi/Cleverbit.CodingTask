using Cleverbit.Services.MatchSevice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cleverbit.CodingTask.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        #region Init
        private readonly IMatchService svcMatchService;

        public MatchController(
            IMatchService matchService
        )
        {
            svcMatchService = matchService;
        }
        #endregion


        // GET: api/ping
        [HttpPost]
        public IActionResult RegisterUserToMatch([FromBody] int UserId, [FromBody] int MatchId)
        {
            return Ok(svcMatchService.RegisterUser(UserId, MatchId));
        }

        // GET api/ping/with-auth
        [HttpGet("AllMatches")]
        [Authorize]
        public IActionResult MatchesHistory()
        {
            return Ok(svcMatchService.ListUserRegistrations());
        }
    }
}
