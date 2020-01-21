using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity
{
    public class Reply
    {
        public ReplyCode Code { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class Reply<TResult>
    {
        public ReplyCode Code { get; set; }
        public TResult Result { get; set; }
        public string ErrorMessage { get; set; }
    }
    /*
     * 以上两种格式可以统一为以下格式：
     *  public class Reply
     *  {
     *      public ReplyCode Code { get; set; }
     *      public dynamic Result { get; set; }
     *      public string ErrorMessage { get; set; }
     *  }
     */
}
