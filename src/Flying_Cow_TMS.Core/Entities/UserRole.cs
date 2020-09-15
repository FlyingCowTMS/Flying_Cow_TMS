using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 用户角色表
    /// </summary>
    public class UserRole:AuditedEntity<int>
    {
        /// <summary>
        /// 用户角色表ID
        /// </summary>
        public int usro_Id { get; set; }
        /// <summary>
        /// 用户表外键
        /// </summary>
        public int userid { get; set; }
        /// <summary>
        /// 角色表外键
        /// </summary>
        public int roleid { get; set; }

    }
}
