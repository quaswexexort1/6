try
{
    int a = 10;
    int b = 22;
    int c = 41;
    int min = Math.Min(Math.Min(a, c), b);
    Console.WriteLine($"Наименьшим числом является {min}");
    a = 76; b = 5; c = 37;
    min = Math.Min(Math.Min(a, c), b);
    Console.WriteLine($"Наименьшим числом является {min}");
    a = 11; b = 75; c = 14;
    min = Math.Min(Math.Min(a, c), b);
    Console.WriteLine($"Наименьшим числом является {min}");
}
catch
{
    Console.WriteLine("Error!");
}