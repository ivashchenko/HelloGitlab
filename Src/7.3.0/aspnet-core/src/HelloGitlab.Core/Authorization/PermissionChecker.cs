using Abp.Authorization;
using HelloGitlab.Authorization.Roles;
using HelloGitlab.Authorization.Users;

namespace HelloGitlab.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
