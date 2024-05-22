using static Challenges.MathematicalFunctions;

namespace Challenges.Tests;

public class MathematicalFunctionsTests
{
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