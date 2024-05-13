using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ThinkAM.Sites.Controllers
{
    public abstract class SitesControllerBase: AbpController
    {
        protected SitesControllerBase()
        {
            LocalizationSourceName = SitesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
