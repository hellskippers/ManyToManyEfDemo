using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManyToManyEfDemo.Models
{
    public class DbFile : DbContext
    {
        public DbSet<Student> student { get;set;}
        public DbSet<Course> course { get; set; }
        public DbSet<Address> address { get; set; }
    }
}