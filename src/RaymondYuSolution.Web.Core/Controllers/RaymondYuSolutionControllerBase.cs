using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RaymondYuSolution.Controllers
{
    public abstract class RaymondYuSolutionControllerBase: AbpController
    {
        protected RaymondYuSolutionControllerBase()
        {
            LocalizationSourceName = RaymondYuSolutionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
