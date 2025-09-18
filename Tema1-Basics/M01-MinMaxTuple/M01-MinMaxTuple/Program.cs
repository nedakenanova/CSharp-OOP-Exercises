class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 9, -1, 7 };
        var result = GetMinMax(arr);
        Console.WriteLine($"Min: {result.min}, Max: {result.max}");
    }

    public static (int min, int max) GetMinMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Масивът е празен или null.");
        }

        int min = numbers[0];
        int max = numbers[0];

        foreach (int n in numbers)
        {
            if (n < min) min = n;
            if (n > max) max = n;
        }

        return (min, max);
        
    }
}
