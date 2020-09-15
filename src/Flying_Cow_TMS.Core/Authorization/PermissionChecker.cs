using Abp.Authorization;
using Flying_Cow_TMS.Authorization.Roles;
using Flying_Cow_TMS.Authorization.Users;

namespace Flying_Cow_TMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
