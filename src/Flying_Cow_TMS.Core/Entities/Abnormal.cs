using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 回单表
    /// </summary>
    public class Abnormal: Entity<int>, IHasCreationTime
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int a_Id { get; set; }
        /// <summary>
        /// 异常状态
        /// </summary>
        public int a_Abnormal { get; set; }
        /// <summary>
        /// 异常说明
        /// </summary>
        public string a_Explain { get; set; }
        /// <summary>
        /// 签收人
        /// </summary>
        public string a_Signer { get; set; }
        /// <summary>
        /// 签收时间 
        /// </summary>
        public DateTime a_Signing { get; set; }
        /// <summary>
        /// 签收状态
        /// </summary>
        public string a_Status { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string a_Picture { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string a_Remarks { get; set; }
        /// <summary>
        /// 卸货外键
        /// </summary>
        public string receiptid { get; set; }
        /// <summary>
        /// 订单外键
        /// </summary>
        public string ifid { get; set; }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
