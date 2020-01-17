using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity.Account
{
    public class AccountInfo
    {
        public string Account { get; set; }
        public BasicAccountInfo BasicAccountInfo { get; set; }
    }
}
