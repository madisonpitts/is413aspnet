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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<formResponse>().HasData(

                new formResponse
                {
                    MovieID = 1,
                    Category = "Family",
                    Title = "Tangled",
                    Year = "2010",
                    Director = "Nathan Greno, Bryon Howard",
                    Rating ="PG",
                    Edited=false,
                    LentTo = "",
                    Notes = ""
                

                },
                new formResponse
                {
                    MovieID = 2,
                    Category = "Comedy",
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
                    MovieID = 3,
                    Category = "Comedy",
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

