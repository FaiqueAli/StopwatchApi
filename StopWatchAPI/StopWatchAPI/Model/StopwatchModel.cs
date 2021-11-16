using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StopWatchAPI.Model
{
    public class StopwatchModel
    {
        public long startTimeSpan { get; set; }
        public bool isRunning { get; set; }
    }
}
