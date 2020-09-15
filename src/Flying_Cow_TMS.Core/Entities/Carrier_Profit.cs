using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 承运商利润表
    /// </summary>
    public class Carrier_Profit : Entity<int>
    {
        public int cp_Id { get; set; }
        /// <summary>
        /// 利润
        /// </summary>
        public float cp_Profit { get; set; }
        /// <summary>
        /// 其他费用
        /// </summary>
        public float cp_ElseCost { get; set; }
        /// <summary>
        /// 报价有效截止日期
        /// </summary>
        public DateTime cp_EndTime { get; set; }
        /// <summary>
        /// 总计
        /// </summary>
        public float cp_Aggregate { get; set; }
        /// <summary>
        /// 货物表外键
        /// </summary>
        public int ciid { get; set; }
    }
}
