using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_SETUP.Models;


namespace MVC_SETUP.Repository
{
    public class BookRepository
    {
        //using our bookmodel in models foldert for data 
        public List<Bookmodel> GetAllBooks()
        {
            return DatabaseSource();
        }

        public Bookmodel GetBookBy (int id)
        {
            return DatabaseSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Bookmodel> searchbook(string bookname, string authorname)
        {
            return DatabaseSource().Where(x => x.TiTle.Contains(bookname)|| x.Author.Contains(authorname)).ToList();
        }

        //creating our database because no external database yet
        private List<Bookmodel> DatabaseSource()
        {
            return new List<Bookmodel>()
            {
                new Bookmodel(){Id=1, TiTle="MVC", Author="Net.Core", Description ="Here we talk all about Mvc"},
                new Bookmodel(){Id=2, TiTle="Java", Author="Java & Microsoft", Description ="Here we talk all about Java"},
                new Bookmodel(){Id=3, TiTle="C#", Author="Microsoft", Description ="Here we talk all about C#"},
                new Bookmodel(){Id=4, TiTle="Javascript", Author="Microsoft",Description ="Here we talk all about Javascript"},
                new Bookmodel(){Id=5, TiTle="Bootstrap", Author="Bootstrap", Description ="Here we talk all about Bootstrap"},
                new Bookmodel(){Id=6, TiTle="PHP", Author="Microsoft", Description ="Here we talk all about PHP"}
            };
        }
    }
}
