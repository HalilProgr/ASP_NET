using ASP_NET.db;
using ASP_NET.Interfaces;
using ASP_NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace ASP_NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookService _service​;
        public HomeController(BookService service)
        {
            _service = service; }
    public async Task<ActionResult> Index()
        {
            var projects = await _service.GetProjectAsync();
            return View(projects);
        }
        public ActionResult Create()
        {
            return View();
        }
    [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(BookDTO book)
        {
            try
            {
                await _service.InsertAsync(book);
                await _service.CompletedAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
