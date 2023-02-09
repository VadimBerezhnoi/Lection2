//3-й вид методов

Console.Clear();

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();

Console.Write($"{year} - сегодняшняя дата");