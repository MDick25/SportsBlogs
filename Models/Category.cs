using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace BlogApplication.Models
{
    public class Category
    {
        [Required]
        [Display(Name = " categoryName")]
        public string categoryname { get; set; }


    }
}