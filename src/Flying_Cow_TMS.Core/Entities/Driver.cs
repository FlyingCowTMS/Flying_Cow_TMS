using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 司机表
    /// </summary>
    public class Driver : Entity<int>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int d_Id { get; set; }
        /// <summary>
        /// 询价外键
        /// </summary>
        public int ifid { get; set; }
        /// <summary>
        /// 报价外键
        /// </summary>
        public int oid { get; set; }

    }
}
