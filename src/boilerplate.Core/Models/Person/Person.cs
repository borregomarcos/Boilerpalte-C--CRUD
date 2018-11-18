using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace boilerplate.Models
{
    public class Person : Entity<int>
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
