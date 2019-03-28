using Abp.Authorization;
using Shertech001.Authorization.Roles;
using Shertech001.Authorization.Users;

namespace Shertech001.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
