using System.IO;
using System.Runtime.Serialization.Json;
using Tyuiu.KomkovAA.Sprint5.Task7.V30;
using Tyuiu.KomkovAA.Sprint5.Task7.V30.Lib;
using static System.Net.Mime.MediaTypeNames;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Дан файл С:\\DataSprint5\\InPutDataFileTask7V30.txt (файл        *");
        Console.WriteLine("* взять из архива согласно вашему варианту. Создать папку в ручную        *");
        Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор          *");
        Console.WriteLine("* символьных данных.Заменить все однозначные числа на число \"9\".          *");
        Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V30.txt.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask7V30.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.LoadDataAndSave(path);
        Console.WriteLine(res);
        Console.WriteLine("СОХРАНЕН В: \"C:\\Users\\Артур\\AppData\\Local\\Temp\\OutPutFileTask7.txt\\");





    }
}