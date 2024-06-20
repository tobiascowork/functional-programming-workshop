namespace Challenges;

public static class BitsAndBytes
{
    // Original: int bitcount(unsigned x), "The C Programming Language", page 50
    // public static int BitCount(uint x)
    // {
    //     int b;
    //     
    //     for (b = 0; x != 0; x >>= 1)
    //         if ((x & 0x01) != 0)
    //             b++;
    //     
    //     return b;
    // }
    public static int BitCount(uint x) => Convert.ToString(x, 2).Count(c => c == '1');
    
    // public static void ByteCopy(byte[] src, byte[] dst, int size)
    // {
    //     if (size == 0)
    //         return;
    //
    //     var n = Math.Min(size, Math.Min(src.Length, dst.Length));
    //     
    //     for (var i = 0; i < n; i++)
    //         dst[i] = src[i];
    // }
    public static void ByteCopy(byte[] src, byte[] dst, int size) => 
        Array.Copy(src, dst, Math.Min(size, Math.Min(src.Length, dst.Length)));

    // public static void ByteZero(byte[] a, int size)
    // {
    //     for (var i = 0; i < Math.Min(size, a.Length); i++)
    //         a[i] = 0;
    // }    
    //
    public static void ByteZero(byte[] a, int size) => a.AsSpan(0, Math.Min(size, a.Length)).Clear();

    // public static void ByteSet(byte[] a, byte value, int size)
    // {
    //     for (var i = 0; i < Math.Min(size, a.Length); i++)
    //         a[i] = value;
    // }
    public static void ByteSet(byte[] a, byte value, int size) => a.AsSpan(0, Math.Min(size, a.Length)).Fill(value);
}