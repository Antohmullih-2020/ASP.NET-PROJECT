using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SETUP.Controllers
{
    public class HomeController : Controller
    {
        //returning a model using view
        //returning a mode that as same name for method action and file name
        public ViewResult index()
        {
            var student = new { id = 1, Name = "Antony" };
            return View(student);
        }

        //returning a model using view
        //Action method with different name with file name
        public ViewResult About_us()
        {
            var student = new { id = 1, name = "Antony" };
            return View("Index", student);
        }

        public ViewResult Contact_us()
        {
            return View();
        }
    }
}
