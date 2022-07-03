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
            var data = await _service.GetAll();
            return View(data);
        }


        //Get: Authors/Create
        public async Task<IActionResult> Create()
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

            _service.Add(author);
            return RedirectToAction(nameof(Index));
        }
    }
}
