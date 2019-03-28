using System.Threading.Tasks;
using Abp.Application.Services;
using Shertech001.Authorization.Accounts.Dto;

namespace Shertech001.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
