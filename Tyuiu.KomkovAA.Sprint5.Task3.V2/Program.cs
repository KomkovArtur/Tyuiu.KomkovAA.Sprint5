using Tyuiu.KomkovAA.Sprint5.Task3.V2;
using Tyuiu.KomkovAA.Sprint5.Task3.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds  = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x = 3;
        Console.WriteLine("x = " + x);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Файл: " + ds.SaveToFileTextData(x));
        Console.WriteLine("Создан! ");
    }
}