using Microsoft.AspNetCore.Mvc;
using RepositoryPrac.Models;
using System.Diagnostics;

namespace RepositoryPrac.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IStatusRepository _db;
        public HomeController(ILogger<HomeController> logger,IStatusRepository repository)
        {
            _logger = logger;
            _db = repository;
        }

        public IActionResult Index()
        {
            List<Status> list = _db.GetAll().ToList();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}