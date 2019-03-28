using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Shertech001.Roles.Dto;
using Shertech001.Users.Dto;

namespace Shertech001.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
