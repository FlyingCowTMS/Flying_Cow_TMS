using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    /// <summary>
    /// 异常表
    /// </summary>
    public class Anomaly:Entity<int>,IHasCreationTime
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ano_Id { get; set; }
        /// <summary>
        /// 回单表外键
        /// </summary>
        public int aid { get; set; }
        /// <summary>
        /// 解决方案
        /// </summary>
        public string ano_processing { get; set; }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
