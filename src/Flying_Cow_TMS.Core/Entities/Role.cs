using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role : AuditedEntity<int>
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public int role_Id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string role_Name { get; set; }
        /// <summary>
        /// 角色权限
        /// </summary>
        public string role_Remark { get; set; }
    }
}
