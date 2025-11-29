using System.IO;
using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KomkovAA.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string txt = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutFileTask7.txt");
            FileInfo fileInfo = new FileInfo(txt);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(txt);

            } 
            string a = "";
            string text = File.ReadAllText(path);
            if (Char.IsDigit(text[0]) && !Char.IsDigit(text[1]))
            {
                a += "9";
            }
            else {a += text[0]; }
                for (int i = 1; i < text.Length - 1; i++)
                {
                    if (Char.IsDigit(text[i]) && !Char.IsDigit(text[i + 1]) & !Char.IsDigit(text[i - 1]))
                    {
                        a += "9";

                    }
                    else { a += text[i]; }

                }
            if (Char.IsDigit(text[text.Length - 1]) && !Char.IsDigit(text[text.Length - 2]))
            {
                a += "9";
            }
            else { a += text[text.Length - 1]; }
            File.AppendAllText(txt, $"{a}");
            return a;
        }
    }
}
