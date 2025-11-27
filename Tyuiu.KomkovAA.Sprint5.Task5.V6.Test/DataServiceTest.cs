using System.IO;
using Tyuiu.KomkovAA.Sprint5.Task5.V6.Lib;
namespace Tyuiu.KomkovAA.Sprint5.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Артур\Desktop\InPutDataFileTask5V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
