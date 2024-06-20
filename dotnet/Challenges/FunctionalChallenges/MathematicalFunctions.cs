using System.Diagnostics.CodeAnalysis;

namespace Challenges;

public static class MathematicalFunctions
{
    // public static int Sum(int[] numbers)
    // {
    //     var sum = 0;
    //     
    //     foreach(var number in numbers)
    //         sum += number;
    //     
    //     return sum;
    // }
    public static int Sum(IEnumerable<int> numbers) => numbers.Sum();
    //
    // public static int Max(int[] numbers)
    // {
    //     var max = numbers[0];
    //     
    //     for(var i = 0; i < numbers.Length; i++)
    //         if (numbers[i] > max)
    //             max = numbers[i];
    //     
    //     return max;
    // }
    public static int Max(IEnumerable<int> numbers) => numbers.Max();
    
    // public static int Min(int[] numbers)
    // {
    //     var min = numbers[0];
    //     
    //     foreach(var number in numbers)
    //         if (number < min)
    //             min = number;
    //     
    //     return min;
    // }    
    public static int Min(IEnumerable<int> numbers) => numbers.Min();
    
    public static int IndexOf(int[] numbers, int numberToFind)
    {
        for(var i = 0; i < numbers.Length; i++)
            if (numbers[i] == numberToFind)
                return i;

        return -1;
    }

    // public static bool Contains(int[] numbers, int numberToFind)
    // {
    //     foreach(var number in numbers)
    //         if (number == numberToFind)
    //             return true;
    //     
    //     return false;
    // }
    public static bool Contains(IEnumerable<int> numbers, int numberToFind) => numbers.Any(numberToFind.Equals);
    
    // public static int[] Reverse(int[] numbers)
    // {
    //     var reversed = new int[numbers.Length];
    //     
    //     for(var i = 0; i < numbers.Length; i++)
    //         reversed[i] = numbers[numbers.Length - 1 - i];
    //     
    //     return reversed;
    // }
    public static int[] Reverse(int[] numbers) => numbers.Reverse().ToArray();
    
    // public static int[] Copy(int[] numbers)
    // {
    //     var copied = new int[numbers.Length];
    //     
    //     for(var i = 0; i < numbers.Length; i++)
    //         copied[i] = numbers[i];
    //     
    //     return copied;
    // }    
    
    public static int[] Copy(IEnumerable<int> numbers) => numbers.ToArray();
    
    // public static int CountOccurrences(int[] numbers, int numberToFind)
    // {
    //     var count = 0;
    //     
    //     foreach(var number in numbers)
    //         if (number == numberToFind)
    //             count++;
    //     
    //     return count;
    // }    
    public static int CountOccurrences(int[] numbers, int numberToFind) => numbers.Count(numberToFind.Equals);

    // public static int Power(int number, int n)
    // {
    //     var p = 1;
    //     
    //     for (var i = 1; i <= n; i++)
    //         p *= number;
    //
    //     return p;
    // }  
    // public static int Power(int number, int n) => (int)Math.Pow(number, n);
    public static int Power(int number, int n) => new int[n].Fill(number).Aggregate(1, (a, b) => a*b);
    private static T[] Fill<T>(this ICollection<T> collection, T value) => Enumerable.Range(0, collection.Count).Select(_ => value).ToArray();
    
    public static int GetAmountOfPrimes(int n)
    {
        Span<bool> primes = new bool[n / 2];
        
        primes.Fill(true);
        primes[0] = false; // 1 is not a prime number
    
        for(var i = 3; i * i <= n; i += 2)
        {
            if (IsPrime(primes, i))
            {
                for(var j = i * i; j <= n; j += (2*i))
                    SetNotPrime(primes, j);
            }
        }
    
        var count = 1; // Count 2 as a prime number
        for(var i = 1; i < primes.Length; i++)
        {
             if (primes[i])
               count++;
        }
    
        return count;
    }

    private static bool IsPrime(Span<bool> primes, int number)
    {
        var index = number / 2;
          
        return index < primes.Length && primes[index];
    }
    private static void SetNotPrime(Span<bool> primes, int num)
    {
        var index = num / 2;
        
        if (index >= primes.Length)
            return;
        
        primes[index] = false;
    }
}