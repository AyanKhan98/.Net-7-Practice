using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryPrac.Models;

namespace RepositoryPrac.Controllers
{
    public class AdminWorks : Controller
    {
        [Authorize(Roles = UtilityRole.Role_Admin)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
