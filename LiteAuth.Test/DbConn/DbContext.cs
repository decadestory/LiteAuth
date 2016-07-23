using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteAuth.Entity;
using Orm.Son.Core;

namespace LiteAuth.Test.DbConn
{
    public class DbContext:SonConnection
    {
        public DbContext() : base("LiteAuth")
        {
        }
    }
}
