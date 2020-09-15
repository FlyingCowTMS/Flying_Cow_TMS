using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flying_Cow_TMS.Entities
{
    public class Jurisdiction : Entity<int>
    {
        /// <summary>
        /// 权限表
        /// </summary>
        public int juris_Id { get; set; }
        /// <summary>
        /// 权限菜单名称
        /// </summary>
        public string juris_MenuName { get; set; }
        /// <summary>
        /// 父类ID
        /// </summary>
        public string juris_Pid { get; set; }
    }
}
