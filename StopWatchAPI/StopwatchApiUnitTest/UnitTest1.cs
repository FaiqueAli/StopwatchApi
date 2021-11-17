using Microsoft.VisualStudio.TestTools.UnitTesting;
using StopWatchAPI.Data;
using StopWatchAPI.Model;

namespace StopwatchApiUnitTest
{
    [TestClass]
    public class UnitTest1
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
            Assert.AreEqual(stopwatchModelClientA.startTimeSpan, stopwatchModelClientB.startTimeSpan);
        }
    }
}
