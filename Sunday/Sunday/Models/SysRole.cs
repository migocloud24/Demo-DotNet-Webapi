﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunday.Models
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class SysRole
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 菜单权限
        /// </summary>
        public string Menus { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(128)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        public string UpdateUserId { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// 删除者
        /// </summary>
        public string DeleteUserId { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeleteDate { get; set; }

        /// <summary>
        /// 是否可用的
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 是否删除的
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}