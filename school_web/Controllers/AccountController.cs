using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DataBase.DAL;

namespace school_web.Controllers
{
    public class AccountController : Controller
    {
        SchoolContext ctx = new SchoolContext();
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult signUp()
        {
            return View();
        }
        public IActionResult signUp_insert(string userName,string email, string password)
        {
          
            if (ctx.Users.Any(a => a.Username == userName && a.Password == password))
            {
               
                return RedirectToAction("LogIn");
            }
            User ur = new User()
            {
                Username = userName,
                Email = email,
                Password = password
           
            };
            ctx.Users.Add(ur);
            ctx.SaveChanges();
            return RedirectToAction("IUser", "UserProfileController1");

        }
        public IActionResult LogIn_check(string userName, string password)
        {
            //string a=Request.QueryString.Value;
            if (ctx.Users.Any(a => a.Username == userName && a.Password == password))
            {
                return RedirectToAction("IUser", "UserProfileController1");
            }
            return RedirectToAction("signUp");
        }

    }
}
