using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Christensen.Data;

namespace Mission10_Christensen.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlingController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }
        public IEnumerable<Bowlers> GetBowlers()
        {
            var BowlersData = _bowlingRepository.GetBowlerWithTeam();
            return BowlersData;
        }
    }
}
