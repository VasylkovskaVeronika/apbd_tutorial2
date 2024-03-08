// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static double GetAverage(int[] arr)
{
    double res = 0;
    foreach (var num in arr) {
        res += num;
    }
    res/= arr.Length;
    return res;
}