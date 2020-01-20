using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiEntity.Diary
{
    public class SearchFactor
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string[] Keywords { get; set; }
        public PageFactor PageFactor { get; set; }
    }
}
