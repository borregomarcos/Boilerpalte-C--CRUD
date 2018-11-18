using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boilerplate.MultiTenancy.Dto;

namespace boilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
