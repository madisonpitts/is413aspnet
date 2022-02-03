using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace movieapp.Models
{
    public class movieContext : DbContext
    {
        // constructor
        public movieContext(DbContextOptions<movieContext> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<formResponse> responses { get; set; }
        public DbSet<Category> categories { get; set; }

        

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryNumber = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryNumber = 2, CategoryName = "Comedy" },
                new Category { CategoryNumber = 3, CategoryName = "Drama" },
                new Category { CategoryNumber = 4, CategoryName = "Family" },
                new Category { CategoryNumber = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryNumber = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryNumber = 7, CategoryName = "Television" },
                new Category { CategoryNumber = 8, CategoryName = "VHS" }
                );

            mb.Entity<formResponse>().HasData(

                new formResponse
                {
                    MovieNumber = 1,
                    CategoryNumber = 4,
                    Title = "Tangled",
                    Year = "2010",
                    Director = "Nathan Greno, Bryon Howard",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""


                },
                new formResponse
                {
                    MovieNumber = 2,
                    CategoryNumber = 2,
                    Title = "Ferris Bueller's Day Off",
                    Year = "1986",
                    Director = "John Hughes",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""


                },
                new formResponse
                {
                    MovieNumber = 3,
                    CategoryNumber = 2,
                    Title = "Can't Buy Me Love",
                    Year = "1987",
                    Director = "Steve Rash",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""


                }


                );
        }
    }
}

