using Microsoft.EntityFrameworkCore;
using Shop.Data.Base;
using Shop.Data.ViewModels;
using Shop.Models;
using System.Linq;
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

        public async Task<NewGameDropdowns> GetNewGameDropdownsValues()
        {
            var response = new NewGameDropdowns()
            {
                Authors = await _context.Authors.OrderBy(n => n.FullName).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync(),
                GameShops = await _context.GameShops.OrderBy(n => n.Name).ToListAsync()
            };
            
            return response;
        }
    }
}
