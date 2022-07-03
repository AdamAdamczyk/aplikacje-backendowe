using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class GamesController : Controller
    {
        private readonly AppDbContext _context;

        public GamesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allGames = await _context.Games.Include(n => n.GameShops).ToListAsync();
            return View(allGames);
        }
    }
}
