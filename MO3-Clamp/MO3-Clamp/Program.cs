using System;
class Program
{
    public static int Clamp(int value, int min, int max)
    {
        if (min > max)
        {
            throw new ArgumentException("min не може да е по-голям от max");
        }

        int result;
        if (value < min)
        {
            result = min;
        }

        else if (value > max) { result = max; }
        else { result = value; }
        return result;

    }
    static void Main()
    {
        Console.WriteLine(Clamp(5, 1, 10));
        Console.WriteLine(Clamp(-3, 0, 100));
        Console.WriteLine(Clamp(200, 0, 100));
        Console.WriteLine(Clamp(0, 0, 0));
    }
}