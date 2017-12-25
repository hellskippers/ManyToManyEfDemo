using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManyToManyEfDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        
        public virtual ICollection<Course> Courses { get; set; }
    }
}