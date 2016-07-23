using LiteAuth.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteAuth.Repository.DbCtx;
using Orm.Son.Core;

namespace LiteAuth.Repository
{
    public class SysUserRepository
    {
        public int Add(SysUser entity)
        {
            using (var db = new DbContext())
            {
                return db.Insert(entity);
            }
        }

        public int Del(int id)
        {
            using (var db = new DbContext())
            {
                return db.Delete<SysUser>(id);
            }
        }

        public int Edit(SysUser entity)
        {
            using (var db = new DbContext())
            {
                return db.Update(entity);
            }
        }



    }
}
