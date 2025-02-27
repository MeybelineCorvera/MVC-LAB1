using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Db;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appDbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext  _dbContext )
        {
            _logger = logger;
            appDbContext = _dbContext;
        }

        public IActionResult Index()
        {
            appDbContext.Alumnos.ToList(); 
            return View(Alumnos);
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
