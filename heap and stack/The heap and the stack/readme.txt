The heap and the stack

In C#, all objects are created on either the heap or the stack.

The stack is an area of memory where the following is stored:

Objects whose type is a value type
(e.g. enums, built-in types and structs)
Values of parameters passed to methods
References to objects created on the heap   (aka pointers)
The heap is an area of memory where the following is stored:

Objects that are instances of reference types
(e.g. strings, arrays, built-in types in the .NET framework, custom types)
Memory for objects created on the stack is allocated when a method is called or when the object is instantiated.  The memory is released when the method that instantiated the object exits.

Memory for objects created on the heap is allocated when the object is instantiated and managed by the CLR garbage collector, which frees memory periodically.

NOTE:
Objects Are on the Heap, References to Objects Are on the Stack

