namespace Challenges;

public class FunctionsFromTheCProgrammingLanguage
{
    /*
     * Functions from Kerninghan/Ritchie - The C Programming Language
     */
    
    /**
     * Convert an ASCII string (like "234") to an integer
     * C equivalent: atoi
     */
    public static int StringToInt(string s)
    {
        int n;
        var i = 0;

        for (n = 0; s[i] >= '0' && s[i] <= '9'; n = n * 10 + s[i++] - '0') { }

        return n;
    }

    /* Convert an integer to an ASCII string, Page 64
     * C equivalent: itoa
     */
    public static string IntToString(uint n)
    {
        var chars = new char[11]; // 10 digits plus '\0'
        
        var i = 0;
        do {
            chars[i++] = (char)(n % 10 + 48);
        } while ((n /= 10) > 0);
        chars[i] = '\0';

        var resultString = new string(chars);
        StringReverse(ref resultString);

        return resultString;
    }

    /* Convert an integer to an ASCII string, base 16 */
    // Original : void itohex(unsigned int n, char *s)
    static string IntToHex(uint n)
    {
        var chars = new char[11]; // 8 digits plus 0x plus '\0'
        var i = 0;
        do
        {
            var d = n % 16;
            if (d < 10)
                chars[i++] = (char)(d + 48);
            else
                chars[i++] = (char)(d - 10 + 97);
        } while ((n /= 16) > 0);
        chars[i] = '\0';
        
        var resultString = new string(chars);
        StringReverse(ref resultString);

        return resultString;
    }
    
    /* Reverse a string, Page 62 */
    // Original : void reverse(char s[])
    static void StringReverse(ref string str)
    {
        int i, j;
        var chars = str.ToCharArray();

        for (i = 0, j = chars.Length - 1; i < j; i++, j--) {
            (chars[i], chars[j]) = (chars[j], chars[i]);
        }
    }
    
    /*
     * strncmp:
     * Compares at most n bytes from the strings s and t.
     * Returns >0 if s > t, <0 if s < t and 0 if s == t.
     */
    // Original: int strncmp(const char *s, const char *t, size_t n)
    public static int StringCompare(string s, string t, int n)
    {
        var charsS = s.ToCharArray();
        var charsT = t.ToCharArray();

        int i;
        for (i = 0; n-- > 0 && charsS[i] == charsT[i] && i < Math.Min(charsS.Length, charsT.Length) ; i++)
            if (charsS[i] == '\0')
                return 0;
        
        return charsS[i] - charsT[i];
    }

    /*
     * strncpy:
     * Coptes at most size characters from src to dest, and '\0'
     * terminates the result iff src is less than len characters long.
     * Returns dest.
     */
    public static string StringNCopy(ref string dest, ref string src, int len)
    {
        var charsDest = dest.ToCharArray();
        
        var i = 0;
        while (i++ <= len && len-- > 0)
        {
            charsDest[i] = src[i];
        }
        
        dest = new string(charsDest);
        return dest;
    }
    
//    /* Block copy: copy size bytes from source to dest.
//     * The arrays can overlap */
//    void bcopy(const char *source, char *destin, int size)
//    {
//        int i;
//
//        if (size == 0)
//            return;
//
//        if (source < destin) {
//            for (i = size - 1; i >= 0; i--)
//                destin[i] = source[i];
//        } else {
//            for (i = 0; i < size; i++)
//                destin[i] = source[i];
//        }
//    }
//
///* Zero out size bytes starting at area */
//    void bzero(char *area, int size)
//    {
//        int i;
//
//        for (i = 0; i < size; i++)
//            area[i] = 0;
//    }
//
///* Set all bytes to the specified value */
//    void bset(char *area, int value, int size)
//    {
//        int i;
//
//        for (i = 0; i < size; i++)
//            area[i] = (char)value;
//    }
}