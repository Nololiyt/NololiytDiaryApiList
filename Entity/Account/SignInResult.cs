using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity.Account
{
    public enum SignInResult
    {
        Success = 0,
        WrongAccountOrPassword = 1,
        WrongAgreementHash = 2
    }
}
