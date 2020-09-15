using System.Collections.Generic;
using Flying_Cow_TMS.Roles.Dto;

namespace Flying_Cow_TMS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
