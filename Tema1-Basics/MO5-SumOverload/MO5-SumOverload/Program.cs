using System;
class Programm
{
    public static int Sum(int a,int b)
    {
        return a + b;
    }
    public static double Sum(double a,double b) 
    { 
        double sum =a+b; return sum;
    }
    public static int Sum( params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine(Sum(3, 4));            
        Console.WriteLine($"{Sum(2.5, 3.5):F2}");        
        Console.WriteLine(Sum(1, 2, 3, 4, 5));   

    }
}