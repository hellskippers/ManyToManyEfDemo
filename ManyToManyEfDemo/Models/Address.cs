using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManyToManyEfDemo.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public String AddressDesc { get; set; }
        public int StudentId { get; set; }

        public virtual Student student { get; set; }
    }
}