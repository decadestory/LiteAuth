using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteAuth.Repository.DbCtx
{
    public class DbContext:Orm.Son.Core.SonConnection
    {
        public DbContext() : base("LiteAuth") { }
    }
}
