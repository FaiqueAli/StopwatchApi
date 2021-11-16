using StopWatchAPI.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StopWatchAPI.Data
{
    public class StopwatchManager
    {
        private StopwatchManager()
        {

        }
        private static StopwatchManager _instance;
        private static bool _isRunning =false;
        private static long timeSpan = 0;
        public static StopwatchManager GetObject()
        {
            if (_instance is null)
                _instance = new StopwatchManager();
            return _instance;
        }
        public StopwatchModel OperateStopwatch(bool isStrat)
        {
            Stopwatch stopWatch = new Stopwatch();
            StopwatchModel stopwatchModel = new StopwatchModel();
            if (isStrat)
            {
                if (!_isRunning)
                {
                    stopWatch.Start();
                    _isRunning = isStrat;
                    timeSpan = Stopwatch.GetTimestamp();
                    stopwatchModel.startTimeSpan = timeSpan;
                    stopwatchModel.isRunning = _isRunning;
                    //TimeSpan ts = stopWatch.Elapsed;
                    //long dt = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                }
                else
                {
                    stopwatchModel.startTimeSpan = timeSpan;
                    stopwatchModel.isRunning = _isRunning;
                }
            }
            else
            {
                stopWatch.Stop();
                _isRunning = false;
                timeSpan = 0;
                stopwatchModel.isRunning = _isRunning;
                stopwatchModel.startTimeSpan = 0;
                //tStamp = Stopwatch.GetTimestamp();
            }
            return stopwatchModel;
        }
    }
    }
