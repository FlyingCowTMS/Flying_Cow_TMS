using System.Collections.Generic;
using Flying_Cow_TMS.Roles.Dto;

namespace Flying_Cow_TMS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}