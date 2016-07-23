using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Son.Mapper;

namespace LiteAuth.Entity
{
    public class Region : BaseEntity
    {
        [Description("编号")]
        public int Id { get; set; }

        [Description("区域代码")]
        public int Code { get; set; }

        [Description("区域父级代码")]
        public int ParentCode { get; set; }

        [Description("区域名称")]
        public string Name { get; set; }

        [Description("区域等级")]
        public int Level { get; set; }

        [Description("区域分组")]
        public int Group { get; set; }

        [Description("区域类型")]
        public int RegionType { get; set; }
    }
}
