using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KomkovAA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double count = 0;
            string[] array;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    array = line.Split(" ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        res = res + Convert.ToDouble(array[i]);
                        count++;
                    }

                }
            }
            return Math.Round(res / count, 3);

        }
    }
}
