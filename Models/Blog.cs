using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.ComponentModel;

namespace BlogApplication.Models
{
    public class Blog
    {
        [Key]
        public long blogid { get; set; }

        [Required]
        [Display(Name="Title")]
        public string title { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Cannot exceed 1000 characters")]
        [Display(Name = "Body")]
        public string body { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime datePublished { get; set; }

        [Display(Name = "Category" )]
        public Category category { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string url { get; set; }

        [Display(Name = "Writer")]
        public User writer { get; set; }


        [Display(Name = "Active")]
        public bool active { get; set; }


    }
}