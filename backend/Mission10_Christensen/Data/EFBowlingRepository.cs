
using Microsoft.EntityFrameworkCore;

namespace Mission10_Christensen.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingContext _bowlingContext;

        public EFBowlingRepository(BowlingContext temp)
        {
            _bowlingContext = temp;
        }
        public IEnumerable<Bowlers> Bowlers  => _bowlingContext.Bowlers;
        public IEnumerable<Bowlers> GetBowlerWithTeam()
        {
            return _bowlingContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
                .ToList();
        }
    }
}
