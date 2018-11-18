using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace boilerplate.Person.Dto
{
    [AutoMap(typeof(Models.Person))]
    public class PersonDto : EntityDto<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
