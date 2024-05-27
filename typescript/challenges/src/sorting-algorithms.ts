export function bubbleSort(numbers: number[]): number[] {
    let m = numbers.length - 1;

    while(m > 0) {
        for (let i = 0; i < m; i++) {
            if (numbers[i] > numbers[i + 1]) {
                swap(numbers, i, i + 1);
            }
        }
        m--;
    }

    return numbers;
}

export function insertionSort(numbers: number[]): number[] {
    for(let i = 1; i < numbers.length; i++) {
        let min = i;

        for (let j = i - 1; j >= 0 && numbers[min] < numbers[j]; j--) {
            swap(numbers, min, j);
            min = j;
        }
    }

    return numbers;
}

export function selectionSort(numbers: number[]): number[] {
    for(let i = 0; i < numbers.length; i++) {
        let min = i;

        for(let j = i+1; j < numbers.length; j++) {
            if(numbers[j] < numbers[min]) {
                min = j;
            }
        }
        swap(numbers, min, i);
    }

    return numbers;
}

export function cocktailSort(numbers: number[]): number[] {
    let l = 0;
    let r = numbers.length;

    while( l < r ) {
        let max = l;

        for (let i = l + 1; i < r; i++) {
            if (numbers[i] > numbers[max]) {
                max = i;
            }
        }

        swap(numbers, max, --r);

        let min = r;

        for (let i = r - 1; i >= l; i--) {
            if (numbers[i] < numbers[min]) {
                min = i;
            }
        }

        swap(numbers, min, l++);
    }

    return numbers;
}

export function shellSort(numbers: number[]): number[] {
    for (let gap = (numbers.length / 2) >> 0; gap > 0; gap = (gap / 2) >> 0) {
        for (let i = gap; i < numbers.length; i++) {
            for (let j = i - gap; j >= 0 && numbers[j] > numbers[j + gap]; j -= gap) {
                swap(numbers, j, j + gap);
            }
        }
    }

    return numbers;
}

export function quickSort(numbers: number[]): number[] {
    _quickSort(numbers, 0, numbers.length - 1);
    return numbers;
}

function _quickSort(numbers: number[], left: number, right: number): void {
    if (left >= right)
        return;

    swap(numbers, left, ((left + right) / 2) >> 0);

    // Partition
    let pivot = left;
    for (let i = left + 1; i <= right; i++) {
        if (numbers[i] < numbers[left]) {
            swap(numbers, ++pivot, i);
        }
    }

    swap(numbers, left, pivot);

    _quickSort(numbers, left, pivot - 1);
    _quickSort(numbers, pivot + 1, right);
}


const swap = (array: number[], indexA: number, indexB: number): void => {
    [array[indexA], array[indexB]] = [array[indexB], array[indexA]];
};