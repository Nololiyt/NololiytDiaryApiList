using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity.Diary
{
    public class PageFactor
    {
        /// <summary>
        /// 表示每页的个数。
        /// </summary>
        public int Count { get; set; }
        public int PageIndex { get; set; }
    }
}
