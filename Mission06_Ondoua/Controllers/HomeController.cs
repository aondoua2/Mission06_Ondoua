using Microsoft.AspNetCore.Mvc;
using Mission06_Ondoua.Models;

namespace Mission06_Ondoua.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;
        public HomeController(MovieApplicationContext temp) // constructor
        {
            _context = temp;
        }
        // GET: Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: Home/About
        public IActionResult About()
        {
            return View();
        }

        // GET: Home/Form
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        // POST: Home/Confirmation
        [HttpPost]
        public IActionResult Form(Application response)
        {
            _context.Applications.Add(response); // add record to the DB
            _context.SaveChanges();
            return View("Confirmation", response);
        }

        public IActionResult Confirmation(Application response)
        {
            return View();
        }
    }
}