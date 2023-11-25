using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.SafronovVV.Sprint5.Task4.V8.Lib;

namespace Tyuiu.SafronovVV.Sprint5.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Black_Reaper\source\repos\Tyuiu.SafronovVV.Sprint5\Tyuiu.SafronovVV.Sprint5.Task4.V8\bin\Debug\InPutDataFileTask4V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool waitt = true;

            Assert.AreEqual(waitt, fileExsist);
        }
    }
}
