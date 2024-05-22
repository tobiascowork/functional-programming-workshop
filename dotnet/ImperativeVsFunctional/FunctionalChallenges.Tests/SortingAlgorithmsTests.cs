using static Challenges.SortingAlgorithms;

namespace Challenges.Tests;

public class SortingAlgorithmsTests
{
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})]
    public void BubbleSort_ReturnsSortedArray(int[] listOfNumbers, int[] expected)
    {
        BubbleSort(listOfNumbers);
        
        Assert.Equal(expected, listOfNumbers);
    }
    
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})] 
    public void InsertionSort_ReturnsSortedArray(int[] listOfNumbers, int[] expected)
    {
        InsertionSort(listOfNumbers);
        
        Assert.Equal(expected, listOfNumbers);
    }
    
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})] 
    public void SelectionSort_ReturnsSortedArray(int[] listOfNumbers, int[] expected)
    {
        SelectionSort(listOfNumbers);
        
        Assert.Equal(expected, listOfNumbers);
    }
    
    [Theory]
    [InlineData(new [] { 5, 3, 4, 2, 1 }, new [] { 1, 2, 3, 4, 5 })]
    [InlineData(new [] { 2, 2, 3, 1, 1 }, new [] { 1, 1, 2, 2, 3 })]
    [InlineData(new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5})] 
    public void CocktailSort_ReturnsSortedArray(int[] listOfNumbers, int[] expected)
    {
        CocktailSort(listOfNumbers);
        
        Assert.Equal(expected, listOfNumbers);
    }
}