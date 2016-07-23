using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteAuth.Common
{
    public class DataResult<T>
    {
        public bool IsOk { get; set; }
        public T Data { get; set; }
        public string Msg { get; set; }
        public object ExtData { get; set; }
    }
}
