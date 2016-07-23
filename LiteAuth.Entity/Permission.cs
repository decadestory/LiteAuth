using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Son.Mapper;

namespace LiteAuth.Entity
{
    public class Permission: BaseEntity
    {
        [Description("编号")]
        public int Id { get; set; }

        [Description("权限代码")]
        public string Code { get; set; }

        [Description("父级代码")]
        public int ParentCode { get; set; }

        [Description("权限名称")]
        public string Name { get; set; }

        [Description("链接地址Url")]
        public string Url { get; set; }

        [Description("菜单Icon类")]
        public string Icon { get; set; }

        [Description("权限类型")]
        public int PermissionType { get; set; }

        [Description("系统类型")]
        public int SysType { get; set; }

    }
}
