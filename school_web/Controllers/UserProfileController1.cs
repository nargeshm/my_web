using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school_web.Controllers
{

    public class UserProfileController1 : Controller
    {
        public IActionResult IUser()
        {
            return View();
        }
    }
}
