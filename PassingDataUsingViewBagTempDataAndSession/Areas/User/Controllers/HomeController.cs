using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.Collections.Generic;
using PassingDataUsingViewBagTempDataAndSession.Areas.User.Models;

namespace PassingDataUsingViewBagTempDataAndSession.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {

        public IActionResult Login()
        {

         

            return View();
        }
        [HttpPost]
        public IActionResult Login(Registration registration)
        {
            
            if (registration.Username=="user@gmail.com" && registration.Password == "12345678")
            {
                if (ModelState.IsValid)
                {
                    TempData["User"] = registration.Username;
                    TempData["Password"]= registration.Password;
                }


                //TempData.Keep();
                return RedirectToAction("Dashboard");



            }
            else
            {

                ViewBag.message = "Username and Password don't exist";
            }


            return View();
        }



        public ActionResult Dashboard()
        {
            ViewBag.message = "Welcome Back";
            string user = (string)TempData["User"];
            ViewBag.User = user;
            string password = (string)TempData["Password"];
            ViewBag.Password = password;
            return View();
        }
        public IActionResult Logout()
        {
            
            return View();
        }
    }
}
