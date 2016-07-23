using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Son.Mapper;

namespace LiteAuth.Entity
{
    public class Role : BaseEntity
    {
        [Description("编号")]
        public int Id { get; set; }

        [Description("角色名称")]
        public string Name { get; set; }

        [Description("角色说明")]
        public string RoleNote { get; set; }
    }
}
