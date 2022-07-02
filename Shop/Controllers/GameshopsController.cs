using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class GameshopsController : Controller
    {
        private readonly AppDbContext _context;

        public GameshopsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allGameShops = await _context.GameShops.ToListAsync();
            return View(allGameShops);
        }
    }
}
