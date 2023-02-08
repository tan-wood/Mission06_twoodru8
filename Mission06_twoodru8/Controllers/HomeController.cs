using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_twoodru8.Models;
using System.Diagnostics;

namespace Mission06_twoodru8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //instanciating the dbcontext and having a get and set
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
        //the original get request for the movie form
        [HttpGet]
        public IActionResult MovieForm() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieFormModel m)
        {
            //if the model is validated, then we will add it and save the changes and send them to the confirmation screen
            if (ModelState.IsValid)
            {
                _dbContext.Add(m);
                _dbContext.SaveChanges();
                return View("Confirmation", m);
            }//else, we will throw them back to the view and display the error.
            else
            {
                return View();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}