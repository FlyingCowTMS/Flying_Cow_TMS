using System.Collections.Generic;
using Flying_Cow_TMS.Roles.Dto;

namespace Flying_Cow_TMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
