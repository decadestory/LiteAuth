using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Son.Mapper;

namespace LiteAuth.Entity
{
    public class BaseEntity
    {
        [Description("添加时间")]
        public DateTime AddTime { get; set; }

        [Description("是否可用")]
        public bool Enable { get; set; }
    }
}
