using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Shertech001.MultiTenancy;

namespace Shertech001.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
