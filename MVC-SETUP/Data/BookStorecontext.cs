using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SETUP.Data
{
    public class BookStorecontext : DbContext
    {
        public BookStorecontext(DbContextOptions<BookStorecontext> options)
            :base(options)
        {

        }

        //setting db
        public DbSet<Books> Books { get; set; }

        //db setup
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Sever.;DatabaseBookStore;Integrated Security=True;")
            base.OnConfiguring(optionsBuilder);
        }
    }
}
