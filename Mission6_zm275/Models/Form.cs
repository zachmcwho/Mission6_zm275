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
        
        public string LentTo { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public int Year { get; set; }
        public string Notes { get; set;}
        public bool Edited { get; set; }
        [Required]
        public string SelectedItem { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }

        public FormModel()
        {
            Items = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "G"},
            new SelectListItem {Value = "2", Text = "PG"},
            new SelectListItem {Value = "3", Text = "PG-13"},
            new SelectListItem {Value = "4", Text = "R"},
        };
        }
    }
}
