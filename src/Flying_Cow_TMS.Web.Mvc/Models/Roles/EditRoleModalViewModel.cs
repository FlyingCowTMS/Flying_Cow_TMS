using Abp.AutoMapper;
using Flying_Cow_TMS.Roles.Dto;
using Flying_Cow_TMS.Web.Models.Common;

namespace Flying_Cow_TMS.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
