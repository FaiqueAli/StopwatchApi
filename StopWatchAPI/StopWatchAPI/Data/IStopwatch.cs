using StopWatchAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StopWatchAPI.Data
{
    public interface IStopwatch
    {
        //StopwatchModel GetStartTimespan(bool isStrat);
        StopwatchModel StartTimer();
        StopwatchModel StopTimer();

    }
}
