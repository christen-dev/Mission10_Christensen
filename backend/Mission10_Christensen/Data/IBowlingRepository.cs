namespace Mission10_Christensen.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
        public IEnumerable<Bowlers> GetBowlerWithTeam();
    }
}
