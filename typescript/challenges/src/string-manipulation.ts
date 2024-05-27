export function toLower(s: string): string {
    let chars = s.split("")

    for (let i = 0; i < chars.length; i++) {
        if (chars[i] >= 'A' && chars[i] <= 'Z') {
            chars[i] = String.fromCharCode(chars[i].charCodeAt(0) + 32);
        }
    }

    return chars.join("");
}

export function toUpper(s: string): string {
    let chars = s.split("")

    for (let i = 0; i < chars.length; i++) {
        if (chars[i] >= 'a' && chars[i] <= 'z') {
            chars[i] = String.fromCharCode(chars[i].charCodeAt(0) - 32);
        }
    }

    return chars.join("");
}

export function squeeze(s: string, c: string): string {
    let chars = s.split("");
    let j = 0;

    for (let i = 0; i < chars.length; i++) {
        if (chars[i] != c) {
            chars[j++] = chars[i];
        }
    }

    return chars.slice(0, j).join("");
}

export function stringConcatenate(s: string, t: string): string {
    return s + t;
}

export function stringToInt(s: string): number {
    let sign = s.charAt(0) == '-' ? -1 : 1;
    let i = s.charAt(0) == '-' ? 1 : 0;

    while (i < s.length && isSpace(s.charAt(i))) {
        i++;
    }

    let n = 0;
    while (i < s.length && !isNaN(+s.charAt(i))) {
        n = n * 10 + +s.charAt(i++);
    }

    return sign * n;
}

export function intToString(n: number): string {
    let sign = n < 0;

    if (sign) {
        n = -n;
    }

    let i = 0;
    let chars = [];

    do {
        chars[i++] = String.fromCharCode(n % 10 + 48);
    } while ((n = Math.floor(n / 10)) > 0);

    if (sign) {
        chars[i++] = '-';
    }

    return stringReverse(chars.slice(0, i).join(""));
}

export function trim(s: string): string {
    let chars = s.split('');
    let i, j;

    for (i = 0; i < chars.length && isSpace(chars[i]); i++) { }
    for (j = i; j < chars.length && !isSpace(chars[j]); j++) { }

    return chars.slice(i, j).join('');
}

export function intToHex(n: number): string {
    let chars = []
    let i = 0;
    do {
        let d = n % 16;
        if (d < 10)
            chars[i++] = String.fromCharCode(d + 48);
        else
            chars[i++] = String.fromCharCode((d - 10) + 97);
    } while ((n = Math.floor(n / 16)) > 0);

    if (i % 2 !== 0) {
        chars[i++] = '0';
    }
    chars[i++] = 'x';
    chars[i++] = '0';

    return stringReverse(chars.slice(0, i).join(''));
}

export function stringReverse(str: string): string {
    let chars = str.split('');
    let i = 0, j = chars.length - 1;

    while( i < j) {
        let temp = chars[i];
        chars[i] = chars[j];
        chars[j] = temp;

        i++;
        j--;
    }

    return chars.join('');
}

export function stringToFloat(s: string): number {
    let i = 0;
    let sign = 1;
    let val = 0.0;
    let power = 1.0;

    while (i < s.length && isSpace(s[i])) {
        i++;
    }

    if (s[i] === '-') {
        sign = -1;
        i++;
    } else if (s[i] === '+') {
        i++;
    }

    while (i < s.length && !isNaN(+s[i])) {
        val = val * 10.0 + (+s[i] - (+'0'));
        i++;
    }

    if (s[i] === '.') {
        i++;
    }

    while (i < s.length && !isNaN(+s[i])) {
        val = val * 10.0 + (+s[i] - (+'0'));
        power *= 10.0;
        i++;
    }

    return sign * val / power;
}

export function stringCompare(s: string, t: string): number {
    let lengthS = s.length;
    let lengthT = t.length;

    if(lengthS > lengthT) {
        return 1;
    }
    if(lengthS < lengthT) {
        return -1;
    }

    let i;
    for (i = 0; s[i] === t[i]; i++) {
        if (i === lengthS - 1) {
            return 0;
        }
    }

    return s[i].charCodeAt(0) - t[i].charCodeAt(0);
}

function isSpace(c: string): boolean {
    return c === ' ' || c === '\t' || c === '\n';
}