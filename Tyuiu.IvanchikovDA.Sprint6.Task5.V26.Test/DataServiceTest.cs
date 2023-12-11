using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint6.Task5.V26.Lib;

namespace Tyuiu.IvanchikovDA.Sprint6.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.IvanchikovDA.Sprint6\Tyuiu.IvanchikovDA.Sprint6.Task5.V26\bin\Debug\InPutFileTask5V26.txt";
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(res, new double[] { 5.0 });
        }
    }
}
