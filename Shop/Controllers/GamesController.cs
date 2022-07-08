using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Services;
using Shop.Models;
using System.Linq;
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

        public async Task<IActionResult> Filter(string searchString)
        {
            var allGames = await _service.GetAllAsync(n => n.GameShops);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allGames.Where(n => n.FullName.Contains(searchString) || n.Descritpion.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }            
            return View("Index", allGames);
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

        [HttpPost]
        public async Task<IActionResult> Create(NewGame game)
        {
            if (!ModelState.IsValid)
            {
                var gameDropdownData = await _service.GetNewGameDropdownsValues();

                ViewBag.Producers = new SelectList(gameDropdownData.Producers, "Id", "FullName");
                ViewBag.Authors = new SelectList(gameDropdownData.Authors, "Id", "FullName");
                ViewBag.GameShops = new SelectList(gameDropdownData.GameShops, "Id", "Name");

                return View(game);
            }

            await _service.AddNewGameAsync(game);
            return RedirectToAction(nameof(Index));
        }


        //Get: Games/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var gameDetails = await _service.GetGamesByIdAsync(id);
            if (gameDetails == null) return View("NotFound");

            var response = new NewGame()
            {
                Id = gameDetails.Id,
                FullName = gameDetails.FullName,
                Descritpion = gameDetails.Descritpion,
                Price = gameDetails.Price,
                ImageURL = gameDetails.ImageURL,
                CreateDate = gameDetails.CreateDate,
                GameCategory = gameDetails.GameCategory,
                AuthorsId = gameDetails.AuthorsId,
                GameShopsId = gameDetails.GameShopsId,
                ProducersId = gameDetails.ProducersId
            };

            var gameDropdownData = await _service.GetNewGameDropdownsValues();

            ViewBag.Producers = new SelectList(gameDropdownData.Producers, "Id", "FullName");
            ViewBag.Authors = new SelectList(gameDropdownData.Authors, "Id", "FullName");
            ViewBag.GameShops = new SelectList(gameDropdownData.GameShops, "Id", "Name");

            return View(response);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewGame game)
        {
            if (id != game.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var gameDropdownData = await _service.GetNewGameDropdownsValues();

                ViewBag.Producers = new SelectList(gameDropdownData.Producers, "Id", "FullName");
                ViewBag.Authors = new SelectList(gameDropdownData.Authors, "Id", "FullName");
                ViewBag.GameShops = new SelectList(gameDropdownData.GameShops, "Id", "Name");

                return View(game);
            }

            await _service.UpdateGameAsync(game);
            return RedirectToAction(nameof(Index));
        }
    }
}
