using Abp.Authorization;
using ThinkAM.Sites.Authorization.Roles;
using ThinkAM.Sites.Authorization.Users;

namespace ThinkAM.Sites.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
