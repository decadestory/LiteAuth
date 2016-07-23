using Orm.Son.Mapper;

namespace LiteAuth.Entity
{
    public class RoleInUser : BaseEntity
    {
        [Description("编号")]
        public int Id { get; set; }

        [Description("角色Id")]
        public int RoleId { get; set; }

        [Description("用户Id")]
        public int UserId { get; set; }
    }
}