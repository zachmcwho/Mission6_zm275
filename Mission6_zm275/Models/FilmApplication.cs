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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormModel>().HasData(
                new FormModel
                {

                    FormId = 1,
                    Title = "Fast n Furious",
                    Category = "Action",
                    Year = 2001,
                    Director = "dave",
                    SelectedItem = "PG-13",
                    Edited = false
                },
                new FormModel
                {

                    FormId = 3,
                    Title = "Fast N Furious 2",
                    Category = "Action",
                    Year = 2004,
                    Director = "dave",
                    SelectedItem = "PG-13",
                    Edited = true
                },
                new FormModel
                {

                    FormId = 2,
                    Title = "romeo",
                    Category = "romance",
                    Year = 21,
                    Director = "adam",
                    SelectedItem = "G",
                    LentTo = "noone",
                    Edited = true
                }

                 );
        }
    }

    
}
