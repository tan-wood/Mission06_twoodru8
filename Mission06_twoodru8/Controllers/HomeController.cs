using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_twoodru8.Models;
using System.Diagnostics;

namespace Mission06_twoodru8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFormDBContext _dbContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieFormDBContext databaseContext)
        {
            _logger = logger;
            _dbContext = databaseContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieFormModel m)
        {
            _dbContext.Add(m);
            _dbContext.SaveChanges();
            return View(m);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}