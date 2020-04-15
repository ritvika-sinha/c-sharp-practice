C# supports two bitwise shift operators that allow you to shift a series of bits a certain number of bit positions to the left or right.

<<    Left shift
>>    Right shift

The shift operators work on the following types: uint, int, ulong, and long.

Note that shifting to the left is the same as multiplying the value by 2 to the power of the # of bits shifted.  E.g. Shifting by 1 bit doubles the number and shifting by 2 bits multiples the number by 4.

Similarly, shifting to the right divides the value by 2 to the power of the # of bits shifted.

When doing bitwise shifting using the << and >> operators, the data value being shifted will always shift new bits in–from the left when right shifting, or from the right when left shifting.  The value of the new bits depend on the direction of the shift and the data type being shifted.

Right shift
If shifting int or long, new bits at left match sign of the value
If shifting uint or ulong, new bits at left are 0-valued

Left shift
New bits at right are 0-valued
Shift operations can never result in an overflow.