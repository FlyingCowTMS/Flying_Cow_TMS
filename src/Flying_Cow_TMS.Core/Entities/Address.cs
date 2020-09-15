using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 地址表
    /// </summary>
    public class Address:Entity<int>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int a_Id { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime a_Time { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string a_Site { get; set; }
        /// <summary>
        /// 询价单外键
        /// </summary>
        public int ifid { get; set; }
    }
}
