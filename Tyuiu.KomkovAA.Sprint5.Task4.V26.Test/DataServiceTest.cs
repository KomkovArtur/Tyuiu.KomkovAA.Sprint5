using System.IO;
using Tyuiu.KomkovAA.Sprint5.Task4.V26.Lib;
namespace Tyuiu.KomkovAA.Sprint5.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Артур\Desktop\InPutDataFileTask4V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
