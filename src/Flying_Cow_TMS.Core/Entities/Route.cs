using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 路线表
    /// </summary>
    public class Route : AuditedEntity<int>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int r_Id { get; set; }
        /// <summary>
        /// 途中站
        /// </summary>
        public string r_Pass { get; set; }
        /// <summary>
        /// 订单表外键
        /// </summary>
        public int ifid { get; set; }
        /// <summary>
        /// 到达时间
        /// </summary>
        public DateTime r_Time { get; set; }
    }
}
