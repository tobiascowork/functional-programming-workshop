export function bubbleSort(listOfNumbers: number[]): number[] {
    let m = listOfNumbers.length - 1;

    while(m > 0) {

        for (let i = 0; i < m; i++) {
            if (listOfNumbers[i] > listOfNumbers[i + 1]) this.swap(listOfNumbers, i, i + 1);
        }

        m--;
    }

    return listOfNumbers;
}

export function insertionSort(listOfNumbers: number[]): number[] {
    for(let i = 1; i < listOfNumbers.length; i++) {
        let min = i;

        let j;
        for (j = i - 1; j >= 0 && listOfNumbers[min] < listOfNumbers[j]; j--) {
            swap(listOfNumbers, min, j);
            min = j;
        }
    }

    return listOfNumbers;
}

export function selectionSort(listOfNumbers: number[]): number[] {
    for(let i = 0; i < listOfNumbers.length; i++) {
        let min = i;

        for(let j = i+1; j < listOfNumbers.length; j++)
            if(listOfNumbers[j] < listOfNumbers[min]) min = j;

            swap(listOfNumbers, min, i);
    }

    return listOfNumbers;
}

export function cocktailSort(listOfNumbers: number[]): number[] {
    let l = 0;
    let r = listOfNumbers.length;

    while( l < r ) {

        let max = l;

        for (let i = l + 1; i < r; i++)
            if (listOfNumbers[i] > listOfNumbers[max]) max = i;

        swap(listOfNumbers, max, --r);

        let min = r;

        for (let i = r - 1; i >= l; i--)
            if (listOfNumbers[i] < listOfNumbers[min]) min = i;

        swap(listOfNumbers, min, l++);
    }

    return listOfNumbers;
}

function swap(array: number[], indexA: number, indexB: number): void {
    let temp = array[indexA];
    array[indexA] = array[indexB];
    array[indexB] = temp;
}