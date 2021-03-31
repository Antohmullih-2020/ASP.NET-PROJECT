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
                new Bookmodel(){Id=1, TiTle="MVC", Author="Kiptoo"},
                 new Bookmodel(){Id=2, TiTle="Java", Author="Ann"},
                  new Bookmodel(){Id=3, TiTle="c#", Author="Microsoft"}
            };
        }
    }
}
