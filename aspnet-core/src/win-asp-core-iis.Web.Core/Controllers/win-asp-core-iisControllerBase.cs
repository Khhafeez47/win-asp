using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace win-asp-core-iis.Controllers
{
    public abstract class win-asp-core-iisControllerBase: AbpController
    {
        protected win-asp-core-iisControllerBase()
        {
            LocalizationSourceName = win-asp-core-iisConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
