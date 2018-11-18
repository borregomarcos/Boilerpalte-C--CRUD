using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boilerplate.Person.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace boilerplate.Person
{
    public interface IPersonService: IAsyncCrudAppService<PersonDto, int, PagedResultRequestDto, CreatePersonDto, PersonDto>
    {
        
    }
}
