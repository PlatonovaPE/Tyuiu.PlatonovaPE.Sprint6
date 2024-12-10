using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PlatonovaPE.Sprint6.Task6.V26.Lib;

namespace Tyuiu.PlatonovaPE.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.IsTrue(Exists);

 
        }
    }
}