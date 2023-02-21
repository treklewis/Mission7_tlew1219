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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Create list of majors to populate ID and names
            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, Name = "Thriller" },
                    new Category { CategoryID = 2, Name = "Adventure" },
                    new Category { CategoryID = 3, Name = "Mystery" }
            );

            //Seed database with three favorite movies
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    AppliationID = 1,
                    CategoryID = 1,
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
                    CategoryID = 2,
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
                    CategoryID = 3,
                    Title = "Memento",
                    Year = 2000,
                    Director = "Christopher Nolan",
                    Rating = "R",
                    LentTo = "",
                    Edited = true,
                    Notes = "Mind blowing"
                }
            );
        }

    }
}
