// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static double GetAverage(int[] array)
{
    double result = 0;
    foreach (var n in array)
    {
        result += n;
    }
    result /= array.Length;
    return result;
}