using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;

namespace MVC_SETUP.Controllers
{
    public class HomeController : Controller
    {
        //returning a model using view
        //returning a mode that as same name for method action and file name
        public ViewResult index()
        {
            
            ViewBag.Title ="Santozpalmer web";
            dynamic data = new ExpandoObject();
            data.id = 123;
            data.name = "Palmer";
            ViewBag.Data = data;
            return View();
        }

        //returning a model using view
        //Action method with different name with file name
        public ViewResult About_us()
        {
            return View();
        }

        public ViewResult Contact_us()
        {
            return View();
        }

      
    }
}
