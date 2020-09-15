using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 调度表
    /// </summary>
    public class Dispatch : Entity<int>
    {
        /// <summary>
        /// 该表的主键
        /// </summary>
        public int dis_Id { get; set; }
        /// <summary>
        /// 与路线表关联
        /// </summary>
        public int routeid { get; set; }
        /// <summary>
        /// 与运输方进行关联
        /// </summary>
        public int transportid { get; set; }
        /// <summary>
        /// 与订单表进行关联
        /// </summary>
        public int orderid { get; set; }
        /// <summary>
        /// 判断该订单是否调度
        /// </summary>
        public int dis_State { get; set; }
    }
}
