// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static int CalculateAverage(int[] values)
{
    int sum = 0;
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return sum / values.Length;
}