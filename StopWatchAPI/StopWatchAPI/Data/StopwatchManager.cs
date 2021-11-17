using StopWatchAPI.Model;
using System;
using System.Diagnostics;

namespace StopWatchAPI.Data
{
    public  class StopwatchManager
    {
        private StopwatchManager()
        {

        }
        private static StopwatchManager _instance;
        private static bool _isRunning =false;
        private static long timeSpan = 0;
        private static readonly object Instancelock = new object();
        public static StopwatchManager GetObject()
        {
            lock (Instancelock)
            {
                if (_instance is null)
                    _instance = new StopwatchManager();
                return _instance;
            }
        }
        public StopwatchModel OperateStopwatch(bool isStart)
        {
            Stopwatch stopWatch = new Stopwatch();
            StopwatchModel stopwatchModel = new StopwatchModel();
            if (isStart==true && _isRunning==false)
            {
                stopWatch.Start();
                timeSpan = Stopwatch.GetTimestamp();
            }
            else if (!isStart)
            {
                stopWatch.Stop();
                timeSpan = 0;
            }
            _isRunning = isStart;
            stopwatchModel.startTimeSpan = timeSpan;
            stopwatchModel.isRunning = _isRunning;
            return stopwatchModel;
        }
    }
    }
