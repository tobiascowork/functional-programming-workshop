namespace Challenges;

public static class SortingAlgorithms
{
    public static int[] BubbleSort(int[] numbers) {
        var m = numbers.Length - 1;

        while(m > 0)
        {
            for(var i = 0; i < m; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Swap(ref numbers[i],  ref numbers[i+1]);
                }
            }
            m--;
        }

        return numbers;
    }

    public static int[] InsertionSort(int[] numbers) {
        for(var i = 1; i < numbers.Length; i++)
        {
            var min = i;

            for(var j = i-1; j >= 0 && numbers[min] < numbers[j]; j--)
            {
                Swap(ref numbers[min], ref numbers[j]);
                min = j;
            }
        }

        return numbers;
    }

    public static int[] SelectionSort(int[] numbers) {
        for(var i = 0; i < numbers.Length; i++)
        {
            var min = i;

            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[min])
                {
                    min = j;
                }
            }

            Swap(ref numbers[min], ref numbers[i]);
        }

        return numbers;
    }
    
    public static int[] CocktailSort(int[] numbers) {
        var l = 0;
        var r = numbers.Length;

        while( l < r ) {
            var max = l; //Left and right index of array

            for (var i = l + 1; i < r; i++)
            {
                if (numbers[i] > numbers[max])
                {
                    max = i;
                }
            }

            Swap(ref numbers[max], ref numbers[--r]);

            var min = r; //Left and right index of array

            for (var i = r - 1; i >= l; i--)
            {
                if (numbers[i] < numbers[min])
                {
                    min = i;
                }
            }

            Swap(ref numbers[min], ref numbers[l++]);
        }

        return numbers;
    }
    
    public static int[] ShellSort(int[] numbers) {
        for (var gap = numbers.Length / 2; gap > 0; gap /= 2)
        {
            for (var i = gap; i < numbers.Length; i++)
            {
                for (var j = i - gap; j >= 0 && numbers[j] > numbers[j + gap]; j -= gap)
                {
                    Swap(ref numbers[j], ref numbers[j + gap]);
                }   
            }
        }

        return numbers;
    }
    
    public static int[] QuickSort(int[] numbers)
    {
        QuickSort(numbers, 0, numbers.Length - 1);
        return numbers;
    }
    
    private static void QuickSort(int[] numbers, int left, int right)
    {
        if (left >= right)
            return;
        
        Swap(ref numbers[left], ref numbers[(left + right) / 2]);

        // Partition
        var pivot = left;
        for (var i = left + 1; i <= right; i++)
        {
            if (numbers[i] < numbers[left])
            {
                Swap(ref numbers[++pivot], ref numbers[i]);
            }
        }

        Swap(ref numbers[left], ref numbers[pivot]);
        QuickSort(numbers, left, pivot - 1);
        QuickSort(numbers, pivot + 1, right);
    }
        
    private static void Swap(ref int a, ref int b) {
        (a, b) = (b, a);
    }
}