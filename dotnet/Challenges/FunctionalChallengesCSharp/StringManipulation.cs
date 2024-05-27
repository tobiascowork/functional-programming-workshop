namespace Challenges;

// Functions from Kerninghan/Ritchie - The C Programming Language

public static class StringManipulation
{

    /* Convert a string to lowercase
     * Original: void lower(char s[]), page 43
     */
    public static string ToLower(string s)
    {
        var chars = s.ToCharArray();
        
        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] is >= 'A' and <= 'Z')
            {
                chars[i] = (char)(chars[i] + 32);
            }
        }

        return new string(chars);
    }
    
    public static string ToUpper(string s)
    {
        var chars = s.ToCharArray();
        
        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] is >= 'a' and <= 'z')
            {
                chars[i] = (char)(chars[i] - 32);
            }
        }

        return new string(chars);
    }

    /* Remove all occurrences of character c from string s
     * Original: void squeeze(char s[], int c), page 47
     */
    public static string Squeeze(string s, char c)
    {
        var chars = s.ToCharArray();
        var j = 0;
        
        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] != c)
            {
                chars[j++] = chars[i];
            }
        }

        return new string(chars, 0, j);
    }
    
    /* Concatenate string s to string t
     * Original: void strcat(char s[], char b[]), page 48
     * This is a very modified version of the original function
     */
    public static string StringConcatenate(string s, string t)
    {
        var charsS = s.ToList();
        var charsT = t.ToCharArray();

        for (int i = 0; i < charsT.Length; i++)
        {
            charsS.Add(charsT[i]);
        }

        return new string(charsS.ToArray());
    }
    
    /* Convert an ASCII string (like "234") to an integer
     * Original: int atoi(char[] s), page 61
     */
    public static int StringToInt(string s)
    {
        var sign = s[0] == '-' ? -1 : 1;
        var i = s[0] == '-' ? 1 : 0;

        for (; i < s.Length && IsSpace(s[i]); i++) { }
        
        int n;
        for (n = 0; i < s.Length && IsDigit(s[i]); n = n * 10 + s[i++] - '0') { }

        return sign * n;
    }

    private static bool IsSpace(char c)
    {
        return c is ' ' or '\t' or '\n';
    }

    private static bool IsDigit(char c)
    {
        return c is >= '0' and <= '9';
    }

    /* Convert an integer to an ASCII string
     * Original: void itoa(int n, char s[]), page 64
     */
    public static string IntToString(int n)
    {
        var chars = new char[11]; // 10 digits plus possible sign

        var sign = n < 0;
        if (sign)
        {
            n = -n;
        }
        
        var i = 0;
        do
        {
            chars[i++] = (char)(n % 10 + 48);
        } while ((n /= 10) > 0);

        if (sign)
        {
            chars[i++] = '-';
        }

        return StringReverse(new string(chars, 0, i));
    }

    /* Trim leading and trailing spaces from a string
     * Original: void trim(char s[]), page 65
     * Modification: Remove leading spaces as well
     */
    public static string Trim(string s)
    {
        var chars = s.ToCharArray();
        int i, j;
        
        for (i = 0; i < chars.Length && IsSpace(chars[i]); i++) { }
        for (j = i; j < chars.Length && !IsSpace(chars[j]); j++) { }

        return new string(chars, i, j - i);
    }

    /* Convert an integer to an ASCII string, base 16 */
    // Original : void itohex(unsigned int n, char *s)
    public static string IntToHex(uint n)
    {
        var chars = new char[10]; // 8 digits plus 0x
        var i = 0;
        do
        {
            var d = n % 16;
            if (d < 10)
                chars[i++] = (char)(d + 48);
            else
                chars[i++] = (char)(d - 10 + 97);
        } while ((n /= 16) > 0);

        if (i % 2 != 0)
        {
            chars[i++] = '0';
        }
        chars[i++] = 'x';
        chars[i++] = '0';

        return StringReverse(new string(chars, 0, i));
    }
    
    /* Reverse a string
     * Original: void reverse(char s[]), page 62
     */
    public static string StringReverse(string str)
    {
        int i, j;
        var chars = str.ToCharArray();

        for (i = 0, j = chars.Length - 1; i < j; i++, j--) {
            (chars[i], chars[j]) = (chars[j], chars[i]);
        }

        return new string(chars);
    }
    
    /* String to float
     * Original: double atof(char s[]), page 71
     */
    public static double StringToFloat(string s)
    {
        var i = 0;
        var sign = 1;
        var val = 0.0;
        var power = 1.0;

        for (; i < s.Length && IsSpace(s[i]); i++) { }

        if (s[i] == '-')
        {
            sign = -1;
            i++;
        }
        else if (s[i] == '+')
        {
            i++;
        }

        for (; i < s.Length && IsDigit(s[i]); i++)
        {
            val = val * 10.0 + (s[i] - '0');
        }

        if (s[i] == '.')
        {
            i++;
        }

        for (; i < s.Length && IsDigit(s[i]); i++)
        {
            val = val * 10.0 + (s[i] - '0');
            power *= 10.0;
        }

        return sign * val / power;
    }
    
    /* Compares two strings s and t
     * Returns > 0 if s > t, < 0 if s < t and 0 if s == t.
     * Original: int strncmp(const char *s, const char *t, size_t n), page 106
     */
    public static int StringCompare(string s, string t)
    {
        var lengthS = s.Length;
        var lengthT = t.Length;
        
        if(lengthS > lengthT)
        {
            return 1;
        }
        if(lengthS < lengthT)
        {
            return -1;
        }
        
        int i;
        for (i = 0; s[i] == t[i]; i++)
        {
            if (i == lengthS - 1)
            {
                return 0;
            }
        }
        
        
        return s[i] - t[i];
    }
}