using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Shertech001.MultiTenancy.Dto;

namespace Shertech001.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

