using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 司机报价表
    /// </summary>
    public class Driver_Quotation : Entity<int>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int dq_Id { get; set; }
        /// <summary>
        /// 询价表外键
        /// </summary>
        public int ifid { get; set; }
        /// <summary>
        /// 报价表外键
        /// </summary>
        public int oid { get; set; }
    }
}
