using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace BlogApplication.Models
{
    public class BlogDB : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}