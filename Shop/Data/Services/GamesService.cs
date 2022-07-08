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

        public async Task AddNewGameAsync(NewGame data)
        {
            var newGame = new Game()
            {
                FullName = data.FullName,
                Descritpion = data.Descritpion,
                Price = data.Price,
                ImageURL = data.ImageURL,
                CreateDate = data.CreateDate,
                GameCategory = data.GameCategory,
                AuthorsId = data.AuthorsId,
                ProducersId = data.ProducersId,
                GameShopsId = data.GameShopsId
            };
            await _context.Games.AddAsync(newGame);
            await _context.SaveChangesAsync();            
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

        public async Task UpdateGameAsync(NewGame data)
        {
            var dbGame = await _context.Games.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbGame != null)
            {
                dbGame.FullName = data.FullName;
                dbGame.Descritpion = data.Descritpion;
                dbGame.Price = data.Price;
                dbGame.ImageURL = data.ImageURL;
                dbGame.CreateDate = data.CreateDate;
                dbGame.GameCategory = data.GameCategory;
                dbGame.AuthorsId = data.AuthorsId;
                dbGame.ProducersId = data.ProducersId;
                dbGame.GameShopsId = data.GameShopsId;
                await _context.SaveChangesAsync();
            }
        }
    }
}
