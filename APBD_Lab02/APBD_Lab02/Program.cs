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

static int CalculateMax(int[] values)
{
    int max = values[0];
    foreach (int value in values)
    {
        if (value > max)
        {
            max = value;
        }
    }
    return max;
}

static int CalculateMin(int[] values)
{
    int min = values[0];

    return -1;
}