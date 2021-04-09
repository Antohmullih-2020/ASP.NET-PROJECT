﻿using Microsoft.AspNetCore.Mvc;
using MVC_SETUP.Models;
using MVC_SETUP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SETUP.Controllers
{
    public class BookController : Controller
    {
       //initializing our repository to get data and send it to
        private readonly BookRepository _bookRepository= null;
            //constructor
            public BookController()
        {
            _bookRepository = new BookRepository();
        }
        //controllores are used for methods to present them to browsers
        public ViewResult GetAllBooks()
        {
            var data =_bookRepository.GetAllBooks();
            return View(data);
        }
        [Route("book-details/{id}")]
        public ViewResult GetBook(int id)
        {

            var data = _bookRepository.GetBookBy(id);

            return View(data);
        }
        public List<Bookmodel> searchbook (string bookname, string authorname)
        {
            return _bookRepository.searchbook(bookname, authorname);
        }
    }
}
