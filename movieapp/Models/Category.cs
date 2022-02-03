﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace movieapp.Models
{
    public class Category 
    {
        [Key]
        [Required]
        public int CategoryNumber { get; set; }
        public string CategoryName { get; set; }


       
    }
}
