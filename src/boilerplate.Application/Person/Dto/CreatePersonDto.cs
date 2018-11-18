using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace boilerplate.Person.Dto
{
    [AutoMapTo(typeof(Models.Person))]
    public class CreatePersonDto 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
