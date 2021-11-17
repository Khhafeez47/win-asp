using Abp.Authorization;
using win-asp-core-iis.Authorization.Roles;
using win-asp-core-iis.Authorization.Users;

namespace win-asp-core-iis.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
