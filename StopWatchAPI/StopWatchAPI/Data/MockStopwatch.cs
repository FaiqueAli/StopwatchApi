using StopWatchAPI.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StopWatchAPI.Data
{
    public class MockStopwatch : IStopwatch
    {

        public StopwatchModel GetStartTimespan(bool isStrat)
        {
            StopwatchModel stopwatchModel = new StopwatchModel();
            StopwatchManager watchManager = StopwatchManager.GetObject();
            stopwatchModel = watchManager.OperateStopwatch(isStrat);
            return stopwatchModel;
        }

        public StopwatchModel StartTimer()
        {
            return GetStartTimespan(true);
        }

        public StopwatchModel StopTimer()
        {
            return GetStartTimespan(false);
        }

    }
}
