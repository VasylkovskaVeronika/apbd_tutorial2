// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static double GetMax(int[] arr)
{
    double res = 0;
    foreach (var num in arr) {
        if(res<num)
            res = num;
    }
    return res;
}