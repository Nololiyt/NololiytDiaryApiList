using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity.Account
{
    public enum CreateResult
    {
        Success = 0,
        IllegalAccountName = 1,
        IllegalPassword = 2,
        OccupiedAccountName = 3
    }
}
