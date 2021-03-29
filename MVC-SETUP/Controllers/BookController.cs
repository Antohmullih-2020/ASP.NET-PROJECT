using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SETUP.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }

        public string GetBook(int id)
        {
            return $"Book with id ={id}";
        }
        public string searchbook (string bookname, string authorname)
        {
            return $"Book with Name ={bookname} &  Author= {authorname}";
        }
    }
}
