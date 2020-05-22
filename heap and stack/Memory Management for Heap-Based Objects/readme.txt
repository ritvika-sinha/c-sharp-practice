Memory Management for Heap-Based Objects

In C#, you create an object on the heap when you instantiate an object using the new keyword.

The memory for an object on the heap can be freed when it’s no longer being referenced by any variables.  This can happen when the variables that reference it go out of scope, or when they are set to point to another object.

More precisely, the memory will be reclaimed by the Garbage Collector (GC) in .NET.  When an application needs more memory, the GC is triggered and it releases memory for any dead objects.