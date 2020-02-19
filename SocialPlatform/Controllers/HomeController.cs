using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocialPlatform.Models;

namespace SocialPlatform.Controllers
{
    public class HomeController : Controller
    {
        SocialPlatformDbContext db = new SocialPlatformDbContext();

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if(ModelState.IsValid)
            {
                if(db.Users.Any(o => o.Username.ToLower() == user.Username.ToLower()) 
                    && db.Users.Any(o => o.Password == user.Password))
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("LoginError", "Username or password was incorrect.");
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(User user)
        {
            if(ModelState.IsValid)
            {
                if(db.Users.Any(o => o.Email.Equals(user.Email, StringComparison.InvariantCultureIgnoreCase)) || 
                    db.Users.Any(o => o.Username.Equals(user.Username, StringComparison.InvariantCultureIgnoreCase)))
                {
                    ModelState.AddModelError("Error", "Username or Email already exists.");
                    return View();
                }
                db.Users.Add(user);
                db.SaveChanges();
                ViewBag.SuccessMessage = "Successfully signed up.";
            }
            
            return View();
        }
    }
}