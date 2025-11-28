using Tyuiu.KomkovAA.Sprint5.Task6.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Дан файл С:\\DataSprint5\\InPutDataFileTask6V23.txt (файл      *");
        Console.WriteLine("* взять из архива согласно вашему варианту. Создать папку в ручную        *");
        Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор        *");
        Console.WriteLine("* символьных данных.Найти количество знаков тире в заданной строке.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\Users\Артур\Desktop\InPutDataFileTask5V6.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Среднее значение всех вещественных = " + res);
    }
}