using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        // here we can "inject" our context service into the contstructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
            ViewBag.AllDishes = AllDishes;
            return View("Index");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View("NewDish");
        }

        [HttpPost("new")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("NewDish");
        }

        [HttpGet("{dishId}")]
        public IActionResult ShowOne(int dishId)
        {
            Dish selectedDish = dbContext.Dishes.SingleOrDefault(d => d.DishId == dishId);
            return View("OneDish", selectedDish);
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult EditPage(int dishId)
        {
            Dish selectedDish = dbContext.Dishes.SingleOrDefault(d => d.DishId ==dishId);
            return View("EditDish", selectedDish);
        }

        [HttpPost("edit/{dishId}")]
        public IActionResult EditDish(int dishId, Dish editDish)
        {
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault(dbContext => dbContext.DishId == dishId);
            if(ModelState.IsValid)
            {
                RetrievedDish.Name = editDish.Name;
                RetrievedDish.Chef = editDish.Chef;
                RetrievedDish.Calories = editDish.Calories;
                RetrievedDish.Tastiness = editDish.Tastiness;
                RetrievedDish.Description = editDish.Description;
                RetrievedDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("ShowOne", new { dishId });
            }
            return View("EditPage");
        }

        [HttpGet("delete/{dishId}")]
        public IActionResult DeleteDish(int dishId)
        {
            Dish RetrievedDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == dishId);
            dbContext.Dishes.Remove(RetrievedDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
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
