namespace Challenges;

public static class SortingAlgorithms
{
    public static void BubbleSort(int[] listOfNumbers) {
        var m = listOfNumbers.Length - 1;

        while(m > 0) {

            for(var i = 0; i < m; i++) {
                if(listOfNumbers[i] > listOfNumbers[i+1]) Swap(ref listOfNumbers[i],  ref listOfNumbers[i+1]);
            }

            m--;
        }
    }

    public static void InsertionSort(int[] listOfNumbers) {
        for(var i = 1; i < listOfNumbers.Length; i++) {
            var min = i;

            int j;
            for(j = i-1; j >= 0 && listOfNumbers[min] < listOfNumbers[j]; j--) {
                Swap(ref listOfNumbers[min], ref listOfNumbers[j]);
                min = j;
            }
        }
    }

    public static void SelectionSort(int[] listOfNumbers) {
        for(var i = 0; i < listOfNumbers.Length; i++){
            var min = i;

            for(var j = i+1; j < listOfNumbers.Length; j++)
                if(listOfNumbers[j] < listOfNumbers[min]) min = j;

            Swap(ref listOfNumbers[min], ref listOfNumbers[i]);
        }

    }
    
    public static void CocktailSort(int[] listOfNumbers) {
        var l = 0;
        var r = listOfNumbers.Length;

        while( l < r ) {

            var max = l; //Left and right index of array

            for(var i = l+1; i < r; i++)
                if(listOfNumbers[i] > listOfNumbers[max]) max = i;

            Swap(ref listOfNumbers[max], ref listOfNumbers[--r]);

            var min = r; //Left and right index of array

            for(var i = r-1; i >= l; i--)
                if(listOfNumbers[i] < listOfNumbers[min]) min = i;

            Swap(ref listOfNumbers[min], ref listOfNumbers[l++]);

        }
    }
    
    
//    /*  Calculates needed values for rightRadixSort
//*   and calls rightRadixSort until *a is sorted.
//*   Arguments:
//*   int *a  : array to be sorted
//*   int n   : Length of a
//*   Return:
//*   void
//*/
//void RightRadix::sort(int *a, int n){
//    int max = 0;    // Max in a
//    int nb  = 0;    // Number of bits in max(must be )
//    int nd  = 0;    // Number of digits and size of *bit
//    int rem = 0;    // Remainder
//    int ns  = 0;    // Next shift
//    int *bit;       // Bits to sort on
//    int *b;         // Sorted elements
//
//    // Get max in a
//    max = max_element(a, n);
//
//    // Count bits in max
//    while( max >= (1 << nb) ) nb++;
//
//    // Amount of bits in nb's digits
//    nd = max_ab(1, (int)(nb / NUMBIT));
//    rem = nb % NUMBIT;
//
//    // Distribute the bits per digit to be sorted
//    bit = new int[nd];
//    for(int i = 0; i < nd; i++) {
//        bit[i] = nb/nd;
//        if(rem-- > 0) bit[i]++;
//    }
//
//    // Right Radix sort on each bit
//    b = new int[n];
//    for(int i = 0; i < nd; i++) {
//        rightRadixSort(a, b, n, bit[i], ns);
//        swap_pointer(a, b);
//        ns += bit[i];
//    }
//
//    // If nd is a odd number one more swap is needed
//    if( nd & 1 ) memcpy(a, b, sizeof(int)*n);
//
//    // Dealloc b at the end!
//    delete []b;
//}
//
//
///** Sorts a to b based on the right radix
//*   Arguments:
//*   int *a  : Array to be sorted
//*   int *b  : Array holding the result
//*   int n   : Length of *a and *b
//*   int ml  : Mask length
//*   int sh  : Shift size
//*   Return:
//*   void
//*/
//void RightRadix::rightRadixSort(int *a, int *b, int n, int ml, int sh) {
//    int ac = 0;     // Acumulated value of *count
//    int tmp = 0;    // Tmp for calculating ac
//    int mask = 0;   // Mask
//    int *count;     // Frequency of each radix value in a
//
//    // Calculate mask
//    mask = (1 << ml) - 1;
//
//    // Create count
//    count = new int[mask + 1];
//
//    // Count the frequency of each radix value in a
//    for(int i = 0; i < n; i++)
//        count[ (a[i] >> sh) & mask ]++;
//
//    // Calculate the acumulated value of count
//    for(int i = 0; i <= mask; i++) {
//        tmp = count[i];
//        count[i] = ac;
//        ac += tmp;
//    }
//
//    // Assign each value of a to the correct position in b
//    for(int i = 0; i < n; i++)
//        b[count[ (a[i] >> sh) & mask ]++] = a[i];
//}
//    

    // Helper function to swap two values
    private static void Swap(ref int a, ref int b) {
        (a, b) = (b, a);
    }
}