using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    public class Receipt : Entity<int>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int r_Id { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string r_Order { get; set; }
        /// <summary>
        /// 货名
        /// </summary>
        public string r_Article { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string r_Spec { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int r_Number { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public int r_Weight { get; set; }
        /// <summary>
        /// 体积
        /// </summary>
        public string r_Volume { get; set; }
    }
}
