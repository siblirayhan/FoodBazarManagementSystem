using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FoodBazarManagementSystem.Models;

namespace FoodBazarManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FoodList()
        {
            return View(_context.fruits);
        }

        public IActionResult AddFood()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddFood(Fruit fruit,String fruit_name)
        {
            var check = _context.fruits.FirstOrDefault(a => a.fruit_name == fruit_name);
            if (check == null)
            {
                _context.fruits.Add(fruit);
                _context.SaveChanges();
                return RedirectToAction("FoodList");
            }
          
                ViewData["Exist Fruit"] = fruit_name;
            
            return View();
        }

        public IActionResult Edit(int id)
        {
            var fruit =_context.fruits.Find(id);
            return View(fruit);
        }
        
        [HttpPost]
        public IActionResult Edit(Fruit fruit)
        {
            _context.fruits.Update(fruit);
            _context.SaveChanges();
            return RedirectToAction("FoodList");
        }
        
        public IActionResult Delete(int id)
        {
            var fruit = _context.fruits.Find(id);
            _context.fruits.Remove(fruit);
            _context.SaveChanges();
            return RedirectToAction("FoodList");
        }
                        
        public IActionResult OrderManager()
        {
            return View();
        }
        
        public IActionResult Employee()
        {
            return View();
        }
        
        public IActionResult Setting()
        {
            return View();
        }
        
        public IActionResult CustomerFeedback()
        {
            return View(_context.getintouch);
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
