using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint3.TaskReview.V30.Lib;

namespace Tyuiu.PostikaAO.Sprint3.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -1;
            int stopValue = 1;

            int len = stopValue - startValue + 1;

            double[] valieWaitArray;
            valieWaitArray = new double[len];

            valieWaitArray[0] = -2.16;
            valieWaitArray[1] = 3.25;
            valieWaitArray[2] = 6.64;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valieWaitArray, res);


        }
    }
}
