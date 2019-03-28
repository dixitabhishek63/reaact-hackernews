using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Shertech001.Controllers
{
    public abstract class Shertech001ControllerBase: AbpController
    {
        protected Shertech001ControllerBase()
        {
            LocalizationSourceName = Shertech001Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
