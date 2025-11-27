using Tyuiu.KomkovAA.Sprint5.Task2.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
        Console.WriteLine("*                                                                         *");
        int[,] a = { { 9, 6, 6 }, { 8, 7, 2 }, { 1, 7, 8 } };
        int rows = a.GetUpperBound(0) + 1;
        int cols = a.GetUpperBound(1) + 1;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{a[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(a);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Файл: " + res + " Создан!");
        Console.ReadKey();
    }
}