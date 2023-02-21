using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_zm275.Models
{
    public class FormModel
    {
        
        [Key]
        public int FormId { get; set; }

        //foreign key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]


        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set;}
        public bool Edited { get; set; }
        
    }
}
