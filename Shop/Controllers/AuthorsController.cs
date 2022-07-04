using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Data.Services;
using Shop.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class AuthorsController : Controller
    {

        private readonly IAuthorsService _service;

        public AuthorsController(IAuthorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }


        //Get: Authors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Biography")]Author author)
        {
            if(!ModelState.IsValid)
            {
                return View(author);
            }

            await _service.AddAsync(author);
            return RedirectToAction(nameof(Index));
        }

        //GET: Authors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);

            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        //Get: Authors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Biography")] Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }

            await _service.UpdateAsync(id,author);
            return RedirectToAction(nameof(Index));
        }

        //Get: Authors/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
