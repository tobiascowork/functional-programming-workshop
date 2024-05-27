using static Challenges.SortingAlgorithms;

namespace Challenges.Tests;

public class SortingAlgorithmsTests
{
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})]
    public void BubbleSort_ReturnsSortedArray(int[] numbers, int[] expected)
    {
        var actual = BubbleSort(numbers);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})] 
    public void InsertionSort_ReturnsSortedArray(int[] numbers, int[] expected)
    {
        var actual = InsertionSort(numbers);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})] 
    public void SelectionSort_ReturnsSortedArray(int[] numbers, int[] expected)
    {
        var actual = SelectionSort(numbers);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})] 
    public void CocktailSort_ReturnsSortedArray(int[] numbers, int[] expected)
    {
        var actual = CocktailSort(numbers);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})] 
    public void ShellSort_ReturnsSortedArray(int[] numbers, int[] expected)
    {
        var actual = ShellSort(numbers);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})] 
    public void QuickSort_ReturnsSortedArray(int[] numbers, int[] expected)
    {
        var actual = QuickSort(numbers);
        
        Assert.Equal(expected, actual);
    }
}