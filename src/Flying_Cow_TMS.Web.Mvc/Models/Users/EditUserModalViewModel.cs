using System.Collections.Generic;
using System.Linq;
using Flying_Cow_TMS.Roles.Dto;
using Flying_Cow_TMS.Users.Dto;

namespace Flying_Cow_TMS.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
