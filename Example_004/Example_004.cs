//4-й вид методов

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        int Method4(int count, string text)
        {
            int i = 0;
            string result = string.Empty;

            while (i < count)
            {
                result = result + text;
                i++;
            }
            return result;
        }

        string res = Method4(10, "qwerty");
        Console.WriteLine(res);
    }
}