using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint6.Task2.V10.Lib;

namespace Tyuiu.IvanchikovDA.Sprint6.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -24.47;
            valueWaitArray[1] = -22.89;
            valueWaitArray[2] = -40.60;
            valueWaitArray[3] = -1.50;
            valueWaitArray[4] = -1.43;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = -0.19;
            valueWaitArray[7] = 4.30;
            valueWaitArray[8] = 38.43;
            valueWaitArray[9] = -4.25;
            valueWaitArray[10] = -2.39;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
