When you instantiate a reference type using the new operator, you are creating a new instance of that type.  

The object is created on what’s known as the managed heap.  
In other words, memory is allocated to store the member data of the object and that memory is allocated from an area of memory known as the heap.

You’ve created an instance of a Person, storing the data on the heap.  You’ve also created a reference variable, obj that references (or points to) the new object.

________________________________________________________________________

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