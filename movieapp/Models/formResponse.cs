using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        

        [Required(ErrorMessage = "Please enter a valid title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a valid year")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Please enter a valid Director")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please select a rating")]
        public string Rating { get; set; }

        [DefaultValue(false)] 
        public bool Edited { get; set; }


        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

        [Required]
        [ForeignKey("CategoryNumber")]
        public int CategoryNumber { get; set; }
        // build foreign key relationship
        public Category Category { get; set; }

    }
}
