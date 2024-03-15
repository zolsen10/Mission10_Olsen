using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10API.Data;

namespace Mission10API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlerController(IBowlingRepository temp) { 
            _bowlingRepository = temp;
        }

        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlingRepository.Bowlers.Where(x => x.Team.TeamName is "Marlins" or "Sharks").ToArray();

            return bowlerData;
        }
    }
}
