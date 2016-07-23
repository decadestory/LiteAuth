using LiteAuth.Common;
using LiteAuth.Entity;
using LiteAuth.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteAuth.Service
{
    public class SysUserSvc
    {
        private readonly SysUserRepository _sur = new SysUserRepository();

        public DataResult<string> Add(SysUser entity)
        {
            try
            {
                var result = _sur.Add(entity);
                return new DataResult<string> { IsOk = result > 0, Msg = "添加成功" };
            }
            catch (Exception e)
            {
                return new DataResult<string> { IsOk = false, Msg = "添加失败:" + e.Message };
            }
        }
    }
}
