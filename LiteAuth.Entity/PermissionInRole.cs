using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Son.Mapper;

namespace LiteAuth.Entity
{
    public class PermissionInRole:BaseEntity
    {
        [Description("编号")]
        public int Id { get; set; }

        [Description("角色Id")]
        public int RoleId { get; set; }

        [Description("权限代码")]
        public int Code { get; set; }

        [Description("权限类型")]
        public int PermissionType { get; set; }

        [Description("系统类型")]
        public int SysType { get; set; }
    }
}
