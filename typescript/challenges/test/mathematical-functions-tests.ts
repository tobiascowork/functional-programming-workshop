import { getAmountOfPrimes } from '../src/mathematical-functions';

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