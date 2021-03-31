using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SETUP.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult index()
        {
            return View();
        }

        public ViewResult About_us()
        {
            return View();
        }
    }
}
