using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.SafronovVV.Sprint5.Task2.V12.Lib;

namespace Tyuiu.SafronovVV.Sprint5.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Black_Reaper\source\repos\Tyuiu.SafronovVV.Sprint5\Tyuiu.SafronovVV.Sprint5.Task2.V12\bin\Debug\OutPutFileTask2.csv";
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
