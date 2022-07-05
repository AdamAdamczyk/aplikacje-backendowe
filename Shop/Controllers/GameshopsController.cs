using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Services;
using Shop.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class GameshopsController : Controller
    {
        private readonly IGameShopsService _service;

        public GameshopsController(IGameShopsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allGameShops = await _service.GetAllAsync();
            return View(allGameShops);
        }


        //GET: producers/details
        public async Task<IActionResult> Details(int id)
        {
            var gameShopsDetails = await _service.GetByIdAsync(id);
            if (gameShopsDetails == null) return View("NotFound");
            return View(gameShopsDetails);
        }

        //GET: GameShop/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Localization")] GameShop gameShops)
        {
            if (!ModelState.IsValid)
                return View(gameShops);

            await _service.AddAsync(gameShops);
            return RedirectToAction(nameof(Index));
        }

        //Get: GameShop/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var gameShopsDetails = await _service.GetByIdAsync(id);
            if (gameShopsDetails == null) return View("NotFound");
            return View(gameShopsDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Localization")] GameShop gameShop)
        {
            if (!ModelState.IsValid)
            {
                return View(gameShop);
            }

            await _service.UpdateAsync(id, gameShop);
            return RedirectToAction(nameof(Index));
        }

        //Get: GameShop/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var gameShopsDetails = await _service.GetByIdAsync(id);
            if (gameShopsDetails == null) return View("NotFound");
            return View(gameShopsDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameShopsDetails = await _service.GetByIdAsync(id);
            if (gameShopsDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
