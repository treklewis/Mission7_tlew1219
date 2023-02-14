using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_tlew1219.Models
{//inherit from dbcontext file
    public class DateApplicationContext : DbContext
    {
        //constructor
        public DateApplicationContext (DbContextOptions<DateApplicationContext> options) : base (options)
        {

        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    AppliationID = 1,
                    Category = "Thriller",
                    Title = "The Departed",
                    Year = 2006,
                    Director = "Martin Scorcese",
                    Rating = "R",
                    LentTo = "",
                    Edited = true,
                    Notes = "Incredible"
                },
                new ApplicationResponse
                {
                    AppliationID = 2,
                    Category = "Adventure",
                    Title = "Tarzan",
                    Year = 1999,
                    Director = "Kevin Lima, Chris Buck",
                    Rating = "G",
                    LentTo = "",
                    Edited = false,
                    Notes = "Thank you Phil Collins"
                },
                new ApplicationResponse
                {
                    AppliationID = 3,
                    Category = "Mystery",
                    Title = "Memento",
                    Year = 2000,
                    Director = "Christopher Nolan ",
                    Rating = "R",
                    LentTo = "",
                    Edited = true,
                    Notes = "Mind blowing"
                }
            );
        }

    }
}
