using System.IO;
using Tyuiu.KomkovAA.Sprint5.Task7.V30;
namespace Tyuiu.KomkovAA.Sprint5.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            if (fileExsist)
            {
                File.Delete(path);
            }
        }
    }
}
