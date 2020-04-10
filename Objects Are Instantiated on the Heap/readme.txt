When you instantiate a reference type using the new operator, you are creating a new instance of that type.  

The object is created on what’s known as the managed heap.  
In other words, memory is allocated to store the member data of the object and that memory is allocated from an area of memory known as the heap.

You’ve created an instance of a Person, storing the data on the heap.  You’ve also created a reference variable, obj that references (or points to) the new object.