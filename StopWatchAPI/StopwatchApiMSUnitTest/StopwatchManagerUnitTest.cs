using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StopWatchAPI.Data;
using StopWatchAPI.Model;

namespace StopwatchApiMSUnitTest
{
    [TestClass]
    class StopwatchManagerUnitTest
    {
        [TestMethod]
        public void Sing_Stopwatch_for_MultipleClients_Test()
        {
            //Arrange
            StopwatchModel stopwatchModelClientA = new StopwatchModel();
            StopwatchModel stopwatchModelClientB = new StopwatchModel();
            StopwatchManager watchManagerClientA = StopwatchManager.GetObject();
            StopwatchManager watchManagerClientB = StopwatchManager.GetObject();

            //Act
            stopwatchModelClientA = watchManagerClientA.OperateStopwatch(true);
            stopwatchModelClientB = watchManagerClientB.OperateStopwatch(true);

            //Assert
            Assert.Equals(stopwatchModelClientA.startTimeSpan, stopwatchModelClientB.startTimeSpan);
        }
    }
}
