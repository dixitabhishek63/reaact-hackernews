using System.Threading.Tasks;
using Abp.Application.Services;
using Shertech001.Sessions.Dto;

namespace Shertech001.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
