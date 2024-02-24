using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Mission06_Ondoua.Models;
using Microsoft.EntityFrameworkCore;


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
            ViewBag.Categories = _context.Categories.ToList();
            return View("Form");
        }
        

        // POST: Home/Confirmation
        [HttpPost]
        public IActionResult Form(Movie response)
        {
           // if (ModelState.IsValid)
            //{
  

                _context.Movies.Add(response); // add record to the DB
                _context.SaveChanges();
                return View("Confirmation", response);
            //}
            //else // invalid data
            //{
               ViewBag.Categories = _context.Categories
                   .OrderBy(x => x.CategoryName)
                   .ToList();
            //}
            return View("Confirmation");
        }

        public IActionResult Confirmation(Movie response)
        {
            return View();
        }

        public IActionResult Waitlist()
        {
            // this is our linq query-- SQL language we use to pull data from DB
            var movies= _context.Movies.ToList();
                //.Where(x => x.Rating == "R")
                //.OrderBy(x => x.Year).ToList();

            return View(movies);
        }

        // create a new action
        public IActionResult Update(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            
            ViewBag.Categories= _context.Categories.ToList();
            return View("Form", recordToEdit);
            //return View("Form", recordToEdit);
        }
        [HttpPost]
        public IActionResult Update(Movie updatedInfo)
        {
     
           var movie = _context.Movies
                .Single(x => x.MovieId == updatedInfo.MovieId);
            
           
            movie.Title = updatedInfo.Title;
            movie.Year = updatedInfo.Year;
            movie.Director = updatedInfo.Director;
            movie.Rating = updatedInfo.Rating;
            movie.Edited = updatedInfo.Edited;
            movie.LentTo = updatedInfo.LentTo;
            movie.CopiedToPlex = updatedInfo.CopiedToPlex;
            movie.Notes = updatedInfo.Notes;
            _context.SaveChanges();
            return RedirectToAction("Waitlist");
        }
        

        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);
            _context.Movies.Remove(recordToDelete);
            _context.SaveChanges();
            return RedirectToAction("Waitlist");

            //ViewBag.Categories = _context.Categories.ToList();
            //return View("Deletion", recordToDelete);
            //return View("Form", recordToEdit);
        }
    } 
}