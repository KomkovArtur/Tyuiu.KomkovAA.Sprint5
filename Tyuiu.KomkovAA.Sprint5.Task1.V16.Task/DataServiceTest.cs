using System.IO;
using Tyuiu.KomkovAA.Sprint5.Task1.V16.Lib;
namespace Tyuiu.KomkovAA.Sprint5.Task1.V16.Task
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Stud0\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
