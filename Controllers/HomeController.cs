using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Form_Submission.Models;


namespace Form_Submission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("In the index route");
            Console.WriteLine("******************************************************************");
            ViewBag.Errors = new List<string>();
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(User newUser)
        {
            if (ModelState.IsValid)
            {
    
                Console.WriteLine("******************************************************************");
                Console.WriteLine("In the Create route");
                Console.WriteLine($"{newUser._fname}");
                Console.WriteLine("******************************************************************");
                return RedirectToAction("Success", newUser);
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                ViewBag.Errors = ModelState.Values;
                return View("Index");
            }
        }
        
        [HttpGet]
        [Route("/success")]
        public IActionResult Success(User newUser)
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("In the Success route");
            Console.WriteLine("******************************************************************");
            return View(newUser);
        }
    }
}
