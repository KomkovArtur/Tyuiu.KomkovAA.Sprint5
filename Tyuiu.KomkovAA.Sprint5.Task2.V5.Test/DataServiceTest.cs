using System.IO;
using Tyuiu.KomkovAA.Sprint5.Task2.V5.Lib;
namespace Tyuiu.KomkovAA.Sprint5.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Артур\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
