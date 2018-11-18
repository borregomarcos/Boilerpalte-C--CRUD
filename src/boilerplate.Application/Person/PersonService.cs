using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using boilerplate.Models;
using Abp.Application.Services;
using boilerplate.Person.Dto;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;

namespace boilerplate.Person
{
    public class PersonService : AsyncCrudAppService<Models.Person,PersonDto, int, PagedResultRequestDto, CreatePersonDto, PersonDto>, IPersonService
    {
        public PersonService(IRepository<Models.Person> repository)
        : base(repository)
        {

        }


    }
}
