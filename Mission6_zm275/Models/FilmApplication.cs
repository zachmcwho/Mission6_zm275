using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_zm275.Models
{
    public class FilmApplication : DbContext
    {
        public FilmApplication(DbContextOptions<FilmApplication> options) : base (options)
        {

        }

        public DbSet<FormModel> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Romance" },
                new Category { CategoryId = 3, CategoryName = "None" }
                );
            mb.Entity<FormModel>().HasData(
                new FormModel
                {

                    FormId = 1,
                    Title = "Fast n Furious",
                    CategoryId = 1,
                    Year = 2001,
                    Director = "dave",
                    Rating = "PG-13",
                    Edited = false
                },
                new FormModel
                {

                    FormId = 3,
                    Title = "Fast N Furious 2",
                    CategoryId = 1,
                    Year = 2004,
                    Director = "dave",
                    Rating = "PG-13",
                    Edited = true
                },
                new FormModel
                {

                    FormId = 2,
                    Title = "romeo",
                    CategoryId = 2,
                    Year = 21,
                    Director = "adam",
                    Rating = "G",
                    LentTo = "noone",
                    Edited = true
                }

                 );
        }
    }

    
}
