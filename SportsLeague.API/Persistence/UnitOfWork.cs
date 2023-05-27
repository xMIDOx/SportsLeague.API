using SportsLeague.API.Core;

namespace SportsLeague.API.Persistence
{
    public class UnitOfWork : IUnitOfwork
    {
        private readonly SportsLeagueDbContext _context;

        public UnitOfWork(SportsLeagueDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
