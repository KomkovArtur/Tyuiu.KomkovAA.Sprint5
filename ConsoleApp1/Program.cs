using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = "сегодня 12 завтра 4 послезавтра 34 и потом 4 5 a";
        string a = "";
        char nach = text[0];
        char con = text[text.Length - 1];
        foreach (char i in text)
        {
            if (i != nach && i != con)
            {
                if (Char.IsDigit(text[i]) && !Char.IsDigit(text[i + 1]) && !Char.IsDigit(text[i - 1]))
                {

                    a += "9";

                }
                else
                {
                    a += i;
                }

            }
            

        }
        Console.WriteLine(a);
    }
}