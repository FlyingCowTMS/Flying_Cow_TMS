﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 提货表
    /// </summary>
    public class Takegoods : AuditedEntity<int>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int t_Id { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string t_Order { get; set; }
        /// <summary>
        /// 货名
        /// </summary>
        public string t_Article { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string t_Spec { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int t_Number { get; set; }
        /// <summary>
        /// 总重量
        /// </summary>
        public float t_Weight { get; set; }
        /// <summary>
        /// 体积
        /// </summary>
        public int t_Volume { get; set; }
        /// <summary>
        /// 始发
        /// </summary>
        public string t_Starting { get; set; }
        /// <summary>
        /// 始发地址
        /// </summary>
        public string t_Origin { get; set; }
        /// <summary>
        /// 到站
        /// </summary>
        public string t_Station { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string t_Address { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string t_Picture { get; set; }
        /// <summary>
        /// 签收时间 
        /// </summary>
        public DateTime t_Signing { get; set; }
        /// <summary>
        /// 报价表外键
        /// </summary>
        public int oid { get; set; }
    }
}
