using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Son.Mapper;

namespace LiteAuth.Entity
{
    public class SysUser: BaseEntity
    {
        [Description("编号")]
        public int Id { get; set; }

        [Description("父级Id")]
        public int ParentId { get; set; }

        [Description("用户名")]
        public string Name { get; set; }

        [Description("真实姓名")]
        public string RealName { get; set; }

        [Description("密码")]
        public string Pwd { get; set; }

        [Description("手机号")]
        public string PhoneNumber { get; set; }

        [Description("邮箱")]
        public string Email { get; set; }

        [Description("系统类型")]
        public int SysType { get; set; }

    }
}
