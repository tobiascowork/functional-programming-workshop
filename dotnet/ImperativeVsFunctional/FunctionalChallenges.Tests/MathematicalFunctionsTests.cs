using static Challenges.MathematicalFunctions;

namespace Challenges.Tests;

public class MathematicalFunctionsTests
{
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 15)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, 9)]
    public void SumOfNumbersIsReturned(int[] numbers, int expectedSum)
    {
        var actualSum = Sum(numbers);
        
        Assert.Equal(expectedSum, actualSum);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, 5)]
    public void LargestNumberIsReturned(int[] numbers, int expectedMax)
    {
        var actualMax = Max(numbers);
        
        Assert.Equal(expectedMax, actualMax);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 1)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, -2)]
    public void SmallestNumberIsReturned(int[] numbers, int expectedMin)
    {
        var actualMin = Min(numbers);
        
        Assert.Equal(expectedMin, actualMin);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0, 0)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 1, 0)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, 3, 2)]
    public void IndexOfNumberIsReturned(int[] numbers, int searchNumber, int expectedIndex)
    {
        var actualIndex = IndexOf(numbers, searchNumber);
        
        Assert.Equal(expectedIndex, actualIndex);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0, true)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 1, true)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, 6, false)]
    public void ReturnsTrueIfNumberExistsInList(int[] numbers, int searchNumber, bool expectedContains)
    {
        var actualContains = Contains(numbers, searchNumber);
        
        Assert.Equal(expectedContains, actualContains);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, new []{ 0, 0, 0, 0, 0 })]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, new []{ 5, 4, 3, 2, 1 })]
    public void NumbersReturnedInReversedOrder(int[] numbers, int[] expectedReversedNumbers)
    {
        var actualReversedNumbers = Reverse(numbers);
        
        Assert.Equal(expectedReversedNumbers, actualReversedNumbers);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 })]
    [InlineData(new []{ 1, 2, 3, 4, 5 })]
    public void NumberInListIsReturned(int[] numbers)
    {
        var copiedNumbers = Copy(numbers);
        
        Assert.Equal(numbers, copiedNumbers);
    }
    
    [Theory]
    [InlineData(new []{ 0, 0, 0, 0, 0 }, 0, 5)]
    [InlineData(new []{ 1, 2, 3, 4, 5 }, 1, 1)]
    [InlineData(new []{ -1, -2, 3, 4, 5 }, 6, 0)]
    public void AmountOfOccurrencesOfGivenNumberIsReturned(int[] numbers, int searchNumber, int expectedOccurrences)
    {
        var actualOccurrences = CountOccurrences(numbers, searchNumber);
        
        Assert.Equal(expectedOccurrences, actualOccurrences);
    }
    
    [Theory]
    [InlineData(0, 5, 0)]
    [InlineData(2, 1, 2)]
    [InlineData(3, 3, 27)]
    [InlineData(4, 4, 256)]
    public void PowerOfNIsReturned(int number, int n, int expected)
    {
        var actual = Power(number, n);
        
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 1)]
    [InlineData(10, 4)]
    [InlineData(100, 25)]
    [InlineData(1000, 168)]
    [InlineData(10000, 1229)]
    [InlineData(100000, 9592)]
    [InlineData(1000000, 78498)]
    [InlineData(10000000, 664579)]
    [InlineData(100000000, 5761455)]
    public void PositiveNumberLargerThanOneN_UsingEratosthenesSieve_CorrectAmountOfPrimeNumbersAreReturned(int n, int correctAmountOfPrimes)
    {
        var result = GetAmountOfPrimes(n);
        
        Assert.Equal(correctAmountOfPrimes, result);
    }
}