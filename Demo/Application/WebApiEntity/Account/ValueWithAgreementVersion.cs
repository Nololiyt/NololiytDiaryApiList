using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity.Account
{
    public class ValueWithAgreementVersion<TValue>
    {
        public TValue CombinedValue { get; set; }
        public string AgreementVersion { get; set; }
    }
}
