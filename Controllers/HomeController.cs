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
        public IActionResult Create(string fname, string lname, int age, string email, string password)
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("In the Create route");
            Console.WriteLine("******************************************************************");
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    _fname = fname,
                    _lname = lname,
                    _age = age,
                    _email = email,
                    _password = password,
                };
                return RedirectToAction("Success");
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
        public IActionResult Success()
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("In the Success route");
            Console.WriteLine("******************************************************************");
            return View();
        }
    }
}
