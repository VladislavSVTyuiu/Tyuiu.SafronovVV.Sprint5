using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.SafronovVV.Sprint5.Task6.V5.Lib;

namespace Tyuiu.SafronovVV.Sprint5.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";
            int wait = 5;
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }

    }
}
