You create a new instance of a reference type by using the new operator and declaring a reference to the new object.  Memory for the object is allocated on the heap and the reference to the object is stored on the stack.

The object itself is able to be destroyed, i.e. its memory freed, when there are no longer any variables that reference it.  This is done automatically by the Garbage Collector (GC) in .NET.

Unlike with C++, you cannot explicitly delete a heap-based object and free its memory.  Only the Garbage Collector can release the memory for the object.  The Garbage Collector will not actually destroy the object unless a) there are no longer any references to the object and b) the CLR invokes the Garbage Collector because it needs memory.