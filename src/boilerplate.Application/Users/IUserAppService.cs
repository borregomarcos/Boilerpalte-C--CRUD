using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boilerplate.Roles.Dto;
using boilerplate.Users.Dto;

namespace boilerplate.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
