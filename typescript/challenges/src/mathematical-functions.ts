export function sum(numbers: number[]): number {
    let sum = 0;
    for(let number of numbers)
        sum += number;

    return sum;
}

export function max(numbers: number[]): number {
    let max = numbers[0];
    for(let i = 0; i < numbers.length; i++)
        if (numbers[i] > max)
            max = numbers[i];

    return max;
}

export function min(numbers: number[]): number {
    let min = numbers[0];
    for(let number of numbers)
        if (number < min)
            min = number;

    return min;
}

export function indexOf(numbers: number[], numberToFind:number): number {
    for(let i = 0; i < numbers.length; i++)
        if (numbers[i] === numberToFind)
            return i;

    return -1;
}

export function contains(numbers: number[], numberToFind:number): boolean {
    for(let number of numbers)
        if (number === numberToFind)
            return true;

    return false;
}

export function reverse(numbers: number[]): number[] {
    let reversed: number[] = new Array(numbers.length);
    for(let i = 0; i < numbers.length; i++)
        reversed[i] = numbers[numbers.length - 1 - i];

    return reversed;
}

export function copy(numbers: number[]): number[] {
    let copied: number[] = new Array(numbers.length);
    for(let i = 0; i < numbers.length; i++)
        copied[i] = numbers[i];

    return copied;
}

export function countOccurrences(numbers: number[], numberToFind:number): number {
    let count = 0;
    for(let number of numbers)
        if (number === numberToFind)
            count++;

    return count;
}

export function getAmountOfPrimes(N: number): number
{
    let primes = Array<boolean>(N / 2);

    primes = primes.fill(true);
    primes[0] = false; // 1 is not a prime number

    for(let i = 3; i * i <= N; i += 2) {
        if (primes[(i / 2) >> 0]) {
            for(let j = i * i; j <= N; j += (2*i))
                primes[(j / 2) >> 0] = false;
        }
    }

    let count = 1; // Count 2 as a prime number
    for(let i = 1; i < primes.length; i++) {
        if (primes[i])
            count++;
    }

    return count;
}