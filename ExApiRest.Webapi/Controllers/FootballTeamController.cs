using ExApiRest.Application;
using ExApiRest.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;





namespace ExApiRest.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        IApplication<FootballTeam> _football;
        public FootballTeamController(IApplication<FootballTeam> football)
        {
            _football = football;

        }
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(new FootballTeam()
            {

                Name = "San Lorenzo",
                Score = 100

            });
        }
    }

}
