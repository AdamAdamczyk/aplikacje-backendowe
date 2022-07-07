using Microsoft.EntityFrameworkCore;
using Shop.Data.Base;
using Shop.Models;
using System.Threading.Tasks;

namespace Shop.Data.Services
{
    public class GamesService:EntityBaseRepository<Game>, IGamesService
    {
        private readonly AppDbContext _context;

        public GamesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Game> GetGamesByIdAsync(int id)
        {
            var gamesDetails = _context.Games
                .Include(d => d.Producers)
                .Include(p => p.Authors)
                .Include(g => g.GameShops)
                .FirstOrDefaultAsync(n => n.Id == id);
            return await gamesDetails;
        }
    }
}
