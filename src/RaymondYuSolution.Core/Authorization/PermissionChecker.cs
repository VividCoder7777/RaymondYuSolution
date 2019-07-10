using Abp.Authorization;
using RaymondYuSolution.Authorization.Roles;
using RaymondYuSolution.Authorization.Users;

namespace RaymondYuSolution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
