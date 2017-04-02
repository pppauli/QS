using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkingTime
{
    [TestClass]
    public class WorkingTimeFunctionTest
    {

        [ClassCleanup]
        public static void tearDown()
        {
            ArgumentLogger.createLogFile();
        }

        [TestMethod]
        public void DummyTest()
        {

        }
    }
}