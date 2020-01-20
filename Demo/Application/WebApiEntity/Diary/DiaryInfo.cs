using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity.Diary
{
    public class DiaryInfo
    {
        public string Content { get; set; }
        /// <summary>
        /// UTC时间。
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}