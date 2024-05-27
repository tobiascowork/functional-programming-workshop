import {
    intToHex,
    intToString,
    squeeze, stringCompare,
    stringConcatenate,
    stringReverse, stringToFloat,
    stringToInt,
    toLower,
    toUpper
} from "../src/string-manipulation";
import {reverse} from "../src/mathematical-functions";

describe('StringManipulationTests', () => {
    test.each([
        ["asdf", "asdf"],
        ["ASDF", "asdf"],
        ["!ASD$QWERTY%", "!asd$qwerty%"],
    ])('ToLower returns the correct lowercase string', (input, expected) => {
        const result = toLower(input);

        expect(result).toEqual(expected);
    });

    test.each([
        ["asdf", "ASDF"],
        ["ASDF", "ASDF"],
        ["!asd$qwerty%", "!ASD$QWERTY%"],
    ])('ToUpper returns the correct uppercase string', (input, expected) => {
        const result = toUpper(input);

        expect(result).toEqual(expected);
    });

    /* Make sure to convert the character to a string using string literals */
    test.each([
        ["a", 'a', ""],
        ["abc", 'a', "bc"],
        ["abc", 'b', "ac"],
        ["abc", 'c', "ab"],
        ["abc", 'd', "abc"],
    ])('Squeeze returns the correct string with character removed', (input, c, expected) => {
        const result = squeeze(input, c);

        expect(result).toEqual(expected);
    });

    test.each([
        ["", "a", "a"],
        ["a", "a", "aa"],
        ["ab", "cd", "abcd"],
        ["Hello ", "World!", "Hello World!"],
    ])('StringConcatenate returns the correct concatenated string', (inputS, inputT, expected) => {
        const result = stringConcatenate(inputS, inputT);

        expect(result).toEqual(expected);
    });

    test.each([
        ["0", 0],
        ["1", 1],
        ["12", 12],
        ["123", 123],
        ["-123", -123],
        ["-12", -12],
        ["-1", -1],
        ["-0", -0],
    ])('StringToInt returns the correct integer', (input, expected) => {
        const result = stringToInt(input);

        expect(result).toEqual(expected);
    });

    test.each([
        [0, "0"],
        [1, "1"],
        [12, "12"],
        [123, "123"],
        [-123, "-123"],
        [-12, "-12"],
        [-1, "-1"],
        [-0, "0"],
    ])('IntToString returns the correct string representation of integer', (input, expected) => {
        const result = intToString(input);

        expect(result).toEqual(expected);
    });

    test.each([
        ["a", "a"],
        ["ab", "ba"],
        ["abc", "cba"],
    ])('StringReverse returns the correct reverse string', (input, expected) => {
        const result = stringReverse(input);

        expect(result).toEqual(expected);
    });

    test.each([
        ["0.0", 0],
        ["0.1", 0.1],
        ["0.12", 0.12],
        ["12.30000003", 12.30000003],
        ["-0.1", -0.1],
        ["-0.12", -0.12],
        ["-12.30000003", -12.30000003],
        ["-0.0", -0.0],
    ])('StringToFloat returns the correct float', (input, expected) => {
        const result = stringToFloat(input);

        expect(result).toBeCloseTo(expected);
    });

    test.each([
        ["a", "a", 0],
        ["a", "b", -1],
        ["b", "a", 1],
        ["a", "bb", -1],
        ["bb", "a", 1],
        ["a", "af", -1],
        ["aaf", "a", 1],
        ["aaa", "aaf", -5],
        ["aaf", "aaa", 5],
    ])('StringCompare returns correct comparison', (s, t, expected) => {
        const result = stringCompare(s, t);

        expect(result).toEqual(expected);
    });

    /* In js, there is no concept of Unsigned Integer,
    Make sure to check if input is negative or not a number inside the function */

    test.each([
        [0, "0x00"],
        [1, "0x01"],
        [12, "0x0c"],
        [1212, "0x04bc"],
        [121212, "0x01d97c"],
    ])('IntToHex returns the correct hex representation of integer', (input, expected) => {
        if (input < 0 || isNaN(input)) throw new Error('Input must be a non-negative number');
        const result = intToHex(input);

        expect(result).toEqual(expected);
    });
});