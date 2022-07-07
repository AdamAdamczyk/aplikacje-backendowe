using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Services;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGamesService _service;

        public GamesController(IGamesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allGames = await _service.GetAllAsync(n => n.GameShops);
            return View(allGames);
        }

        //GET: Authors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var gameDetails = await _service.GetGamesByIdAsync(id);
            return View(gameDetails);
        }

        //Get: Games/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
