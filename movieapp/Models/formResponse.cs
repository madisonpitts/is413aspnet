using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace movieapp.Models
{
    public class formResponse
    {
        [Key]
        [Required]
        public int MovieNumber { get; set; }

        

        [Required]
        public string Title { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        [DefaultValue(false)] 
        public bool Edited { get; set; }


        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

        [Required]
        public int CategoryNumber { get; set; }
        // build foreign key relationship
        public Category Category { get; set; }

    }
}
