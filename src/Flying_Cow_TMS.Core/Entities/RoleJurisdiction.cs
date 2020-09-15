using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 角色权限表
    /// </summary>
    public class RoleJurisdiction : AuditedEntity<int>
    {
        /// <summary>
        /// 角色权限表ID
        /// </summary>
        public int role_Id { get; set; }
        /// <summary>
        /// 角色表外键
        /// </summary>
        public int roleid { get; set; }
        /// <summary>
        /// 权限表外键
        /// </summary>
        public int jurisid { get; set; }
    }
}
