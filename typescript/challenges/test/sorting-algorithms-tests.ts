import {bubbleSort, cocktailSort, insertionSort, quickSort, selectionSort, shellSort} from "../src/sorting-algorithms";

test.each([
    [[5, 3, 4, 2, 1], [1, 2, 3, 4, 5]],
    [[2, 2, 3, 1, 1], [1, 1, 2, 2, 3]],
    [[1, 2, 3, 4, 5], [1, 2, 3, 4, 5]]
])('BubbleSort returns sorted array', (listOfNumbers, expected) => {
    expect(bubbleSort(listOfNumbers)).toEqual(expected);
});

test.each([
    [[5, 3, 4, 2, 1], [1, 2, 3, 4, 5]],
    [[2, 2, 3, 1, 1], [1, 1, 2, 2, 3]],
    [[1, 2, 3, 4, 5], [1, 2, 3, 4, 5]]
])('InsertionSort returns sorted array', (listOfNumbers, expected) => {
    expect(insertionSort(listOfNumbers)).toEqual(expected);
});

test.each([
    [[5, 3, 4, 2, 1], [1, 2, 3, 4, 5]],
    [[2, 2, 3, 1, 1], [1, 1, 2, 2, 3]],
    [[1, 2, 3, 4, 5], [1, 2, 3, 4, 5]]
])('SelectionSort returns sorted array', (listOfNumbers, expected) => {
    expect(selectionSort(listOfNumbers)).toEqual(expected);
});

test.each([
    [[5, 3, 4, 2, 1], [1, 2, 3, 4, 5]],
    [[2, 2, 3, 1, 1], [1, 1, 2, 2, 3]],
    [[1, 2, 3, 4, 5], [1, 2, 3, 4, 5]]
])('CocktailSort returns sorted array', (listOfNumbers, expected) => {
    expect(cocktailSort(listOfNumbers)).toEqual(expected);
});

test.each([
    [[5, 3, 4, 2, 1], [1, 2, 3, 4, 5]],
    [[2, 2, 3, 1, 1], [1, 1, 2, 2, 3]],
    [[1, 2, 3, 4, 5], [1, 2, 3, 4, 5]]
])('ShellSort returns sorted array', (listOfNumbers, expected) => {
    expect(shellSort(listOfNumbers)).toEqual(expected);
});

test.each([
    [[5, 3, 4, 2, 1], [1, 2, 3, 4, 5]],
    [[2, 2, 3, 1, 1], [1, 1, 2, 2, 3]],
    [[1, 2, 3, 4, 5], [1, 2, 3, 4, 5]]
])('QuickSort returns sorted array', (listOfNumbers, expected) => {
    expect(quickSort(listOfNumbers)).toEqual(expected);
});
