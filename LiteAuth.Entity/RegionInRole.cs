using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Son.Mapper;

namespace LiteAuth.Entity
{
    public class RegionInRole : BaseEntity
    {
        [Description("编号")]
        public int Id { get; set; }

        [Description("角色Id")]
        public int RoleId { get; set; }

        [Description("区域代码")]
        public int Code { get; set; }

        [Description("区域分组Id")]
        public int Grop { get; set; }
    }
}
