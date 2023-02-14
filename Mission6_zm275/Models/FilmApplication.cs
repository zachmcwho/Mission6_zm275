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

        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    mb.Entity<FormModel>().HasData(
        //        new FormModel
        //        {

        //            FormId = 1,
        //            Title = "Fast N Furious",
        //            Category = "Action",
        //            Year = 2001,
        //            Director = "Steve",
        //            SelectedItem = "R",
        //            Edited = true
        //        },
        //        new FormModel
        //        {

        //            FormId = 1,
        //            Title = "Fast N Furious 2",
        //            Category = "Action",
        //            Year = 2004,
        //            Director = "Steve",
        //            SelectedItem = "R",
        //            Edited = true
        //        },
        //        new FormModel
        //        {

        //            FormId = 1,
        //            Title = "Fast N Furious 3",
        //            Category = "Action",
        //            Year = 2006,
        //            Director = "Steve",
        //            SelectedItem = "R",
        //            Edited = false
        //        }

        //         );
        //}
    }

    
}
