using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.SafronovVV.Sprint5.Task3.V23.Lib;

namespace Tyuiu.SafronovVV.Sprint5.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Black_Reaper\source\repos\Tyuiu.SafronovVV.Sprint5\Tyuiu.SafronovVV.Sprint5.Task3.V23\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
