using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> Create()
        {
            var gameDropdownData = await _service.GetNewGameDropdownsValues();

            ViewBag.Producers = new SelectList(gameDropdownData.Producers, "Id", "FullName");
            ViewBag.Authors = new SelectList(gameDropdownData.Authors, "Id", "FullName");
            ViewBag.GameShops = new SelectList(gameDropdownData.GameShops, "Id", "Name");

            return View();
        }
    }
}
