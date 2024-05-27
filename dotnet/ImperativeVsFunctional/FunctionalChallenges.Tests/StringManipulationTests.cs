namespace Challenges.Tests;

using static StringManipulation;

public class StringManipulationTests
{
    [Theory]
    [InlineData("asdf", "asdf")]
    [InlineData("ASDF", "asdf")]
    [InlineData("!ASD$QWERTY%", "!asd$qwerty%")]
    public void ToLower_ReturnsTheCorrectLowercaseString(string input, string expected)
    {
        var result = ToLower(input);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("asdf", "ASDF")]
    [InlineData("ASDF", "ASDF")]
    [InlineData("!asd$qwerty%", "!ASD$QWERTY%")]
    public void ToUpper_ReturnsTheCorrectLowercaseString(string input, string expected)
    {
        var result = ToUpper(input);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("a", 'a', "")]
    [InlineData("abc", 'a', "bc")]
    [InlineData("abc", 'b', "ac")]
    [InlineData("abc", 'c', "ab")]
    [InlineData("abc", 'd', "abc")]
    public void Squeeze_ReturnsTheCorrectStringWithCharacterRemoved(string input, char c, string expected)
    {
        var result = Squeeze(input, c);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("", "a", "a")]
    [InlineData("a", "a", "aa")]
    [InlineData("ab", "cd", "abcd")]
    [InlineData("Hello ", "World!", "Hello World!")]
    public void String_StringConcatenate_ReturnsTheCorrectConcatenatedString(string inputS, string inputT, string expected)
    {
        var result = StringConcatenate(inputS, inputT);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("0", 0)]
    [InlineData("1", 1)]
    [InlineData("12", 12)]
    [InlineData("123", 123)]
    [InlineData("-123", -123)]
    [InlineData("-12", -12)]
    [InlineData("-1", -1)]
    [InlineData("-0", 0)]
    public void ValidStringRepresentationOfInteger_StringToInt_ReturnsTheCorrectInteger(string input, int expected)
    {
        var result = StringToInt(input);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(0, "0")]
    [InlineData(1, "1")]
    [InlineData(12, "12")]
    [InlineData(123, "123")]
    [InlineData(-123, "-123")]
    [InlineData(-12, "-12")]
    [InlineData(-1, "-1")]
    public void Integer_IntToString_ReturnsTheCorrectStringRepresentationOfInteger(int input, string expected)
    {
        var result = IntToString(input);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("a", "a")]
    [InlineData("ab", "ba")]
    [InlineData("abc", "cba")]
    public void String_StringReverse_ReturnsTheCorrectReversedString(string input, string expected)
    {
        var result = StringReverse(input);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("0.0", 0)]
    [InlineData("0.1", 0.1)]
    [InlineData("0.12", 0.12)]
    [InlineData("12.30000003", 12.30000003)]
    [InlineData("-0.1", -0.1)]
    [InlineData("-0.12", -0.12)]
    [InlineData("-12.30000003", -12.30000003)]
    [InlineData("-0.0", 0)]
    public void ValidStringRepresentationOfFloat_StringToFloat_ReturnsTheCorrectFloat(string input, double expected)
    {
        var result = StringToFloat(input);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("a", "a", 0)]
    [InlineData("a", "b", -1)]
    [InlineData("b", "a", 1)]
    [InlineData("a", "bb", -1)]
    [InlineData("bb", "a", 1)]
    [InlineData("a", "af", -1)]
    [InlineData("aaf", "a", 1)]
    [InlineData("aaa", "aaf", -5)]
    [InlineData("aaf", "aaa", 5)]
    public void TwoStrings_StringCompare_ReturnsCorrectComparison(string s, string t, int expected)
    {
        var result = StringCompare(s, t);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(0, "0x00")]
    [InlineData(1, "0x01")]
    [InlineData(12, "0x0c")]
    [InlineData(1212, "0x04bc")]
    [InlineData(121212, "0x01d97c")]
    public void UnsignedInteger_IntToHex_ReturnsTheCorrectHexRepresentationOfInteger(uint input, string expected)
    {
        var result = IntToHex(input);
        
        Assert.Equal(expected, result);
    }
}