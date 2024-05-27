import {
    contains,
    copy,
    countOccurrences,
    getAmountOfPrimes,
    indexOf,
    max,
    min,
    reverse,
    sum
} from '../src/mathematical-functions';

test.each([
    [[0, 0, 0, 0, 0], 0],
    [[1, 2, 3, 4, 5], 15],
    [[-1, -2, 3, 4, 5], 9],
])("returns sum of numbers", (numbers, expectedSum) => {
    const actualSum = sum(numbers);
    expect(actualSum).toBe(expectedSum);
});

test.each([
    [[0, 0, 0, 0, 0], 0],
    [[1, 2, 3, 4, 5], 5],
    [[-1, -2, 3, 4, 5], 5],
])("returns largest number", (numbers, expectedMax) => {
    const actualMax = max(numbers);
    expect(actualMax).toBe(expectedMax);
});

test.each([
    [[0, 0, 0, 0, 0], 0],
    [[1, 2, 3, 4, 5], 1],
    [[-1, -2, 3, 4, 5], -2],
])("returns smallest number", (numbers, expectedMin) => {
    const actualMin = min(numbers);
    expect(actualMin).toBe(expectedMin);
});

test.each([
    [[0, 0, 0, 0, 0], 0, 0],
    [[1, 2, 3, 4, 5], 1, 0],
    [[-1, -2, 3, 4, 5], 3, 2],
])("returns index of number", (numbers, searchNumber, expectedIndex) => {
    const actualIndex = indexOf(numbers, searchNumber);
    expect(actualIndex).toBe(expectedIndex);
});

test.each([
    [[0, 0, 0, 0, 0], 0, true],
    [[1, 2, 3, 4, 5], 1, true],
    [[-1, -2, 3, 4, 5], 6, false],
])("returns true if number exists in list", (numbers, searchNumber, expectedContains) => {
    const actualContains = contains(numbers, searchNumber);
    expect(actualContains).toBe(expectedContains);
});

test.each([
    [[0, 0, 0, 0, 0], [0, 0, 0, 0, 0]],
    [[1, 2, 3, 4, 5], [5, 4, 3, 2, 1]],
])("returns numbers in reversed order", (numbers, expectedReversedNumbers) => {
    const actualReversedNumbers = reverse(numbers);
    expect(actualReversedNumbers).toEqual(expectedReversedNumbers);
});

test.each([
    [[0, 0, 0, 0, 0]],
    [[1, 2, 3, 4, 5]],
])("returns copy of list", (numbers) => {
    const copiedNumbers = copy(numbers);
    expect(copiedNumbers).toEqual(numbers);
});

test.each([
    [[0, 0, 0, 0, 0], 0, 5],
    [[1, 2, 3, 4, 5], 1, 1],
    [[-1, -2, 3, 4, 5], 6, 0],
])("returns count of occurrences of given number", (numbers, searchNumber, expectedOccurrences) => {
    const actualOccurrences = countOccurrences(numbers, searchNumber);
    expect(actualOccurrences).toBe(expectedOccurrences);
});

const cases = [
    [2, 1],
    [10, 4],
    [100, 25],
    [1000, 168],
    [10000, 1229],
    [100000, 9592],
    [1000000, 78498],
    [10000000, 664579],
    [100000000, 5761455]
];

describe('When using Eratosthenes sieve to count primes', () => {
    test.each(cases)('Given a positive number %i the expected amount of primes are %i', (n, expectedAmountOfPrimes) => {
        expect(getAmountOfPrimes(n)).toBe(expectedAmountOfPrimes);
    });
});