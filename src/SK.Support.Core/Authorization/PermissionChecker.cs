using Abp.Authorization;
using SK.Support.Authorization.Roles;
using SK.Support.Authorization.Users;

namespace SK.Support.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
