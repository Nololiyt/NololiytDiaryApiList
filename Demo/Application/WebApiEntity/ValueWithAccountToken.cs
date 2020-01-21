using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity
{
    public class ValueWithAccountToken<TValue>
    {
        public TValue Value { get; set; }
        public byte[] AccountToken { get; set; }
    }
}
