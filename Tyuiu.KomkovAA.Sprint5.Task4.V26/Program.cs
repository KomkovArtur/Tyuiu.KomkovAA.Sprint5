using Tyuiu.KomkovAA.Sprint5.Task4.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Исходные данные:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\Users\Артур\Desktop\InPutDataFileTask4V26.txt";
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
    }
}