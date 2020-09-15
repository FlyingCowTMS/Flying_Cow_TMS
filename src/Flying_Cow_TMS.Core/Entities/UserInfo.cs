using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfo : AuditedEntity<int>
    {
        /// <summary>
        /// 用户表ID
        /// </summary>
        public int user_Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_Name { get; set; }
        /// <summary>
        /// 用户电话
        /// </summary>
        public string user_Phone { get; set; }
    }
}
