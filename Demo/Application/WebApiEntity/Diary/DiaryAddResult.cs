using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity.Diary
{
    public enum DiaryAddResult
    {
        Success = 0,
        NotSignedIn = 1,
        EmptyContent = 3
    }
}
