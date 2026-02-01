using System;
using System.Threading;
namespace LoggingMethod
{


    public class MyTasks
    {
        [TimeLog("Fast Task Time")]
        public void FastWork()
        {
            Thread.Sleep(400);
        }

        [TimeLog("Slow Task Time")]
        public void SlowWork()
        {
            Thread.Sleep(1200);
        }
    }

}