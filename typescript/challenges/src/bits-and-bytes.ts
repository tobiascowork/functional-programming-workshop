    // Original: int bitcount(unsigned x), "The C Programming Language", page 50
export function bitCount(x: number): number {
    let b: number;
    let i: number;
    let maxIterations = 32;

    for (i = 0, b = 0; x != 0 && i < maxIterations; x >>= 1, i++) {
        if ((x & 0x01) != 0)
            b++;
    }

    return b;
}

export function byteCopy(src: Uint8Array, dst: Uint8Array, size: number) : void {
    if (size === 0)
        return;

    const n = Math.min(size, Math.min(src.length, dst.length));

    for (let i = 0; i < n; i++)
        dst[i] = src[i];
}

export function byteZero(a: Uint8Array, size: number) : void {
    for (let i = 0; i < Math.min(size, a.length); i++)
        a[i] = 0;
}

export function byteSet(a: Uint8Array, value: number, size: number) : void {
    for (let i = 0; i < Math.min(size, a.length); i++)
        a[i] = value;
}