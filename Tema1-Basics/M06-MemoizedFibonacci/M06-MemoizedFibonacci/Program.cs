using System;
class Program
{
    static Dictionary<int, long> cache = new Dictionary<int, long>();

    public static long Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        
        if (cache.ContainsKey(n))
            return cache[n];

        
        long result = Fib(n - 1) + Fib(n - 2);
        cache[n] = result;

        return result;
    }
    static void Main()
    {
        
        
            Console.WriteLine(Fib(0));    
            Console.WriteLine(Fib(1));    
            Console.WriteLine(Fib(5));    
            Console.WriteLine(Fib(10));   
            Console.WriteLine(Fib(20));   
            Console.WriteLine(Fib(50));   

            try
            {
                Console.WriteLine(Fib(-1)); 
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Грешка: " + ex.Message);
            }
        

    }
}