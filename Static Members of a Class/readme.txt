When you create a new object and use a reference variable to call methods of a class, you’re using instance members of that class.  Instance members interact with just that instance of the class.

You can also work with class members without creating an instance of the class.  Static class members operate on the class itself, rather than on instances of the class.

To invoke static members, you use the name of the class, rather than a variable that points to an instance of the class.

If you assign a variable that points to a reference type to another variable of the same type, both variables end up pointing to the same object in memory.  This means that changing the contents of the object through the first reference results in changes that are also seen by the second reference.

With instance data members of a class, there is a unique set of data that exists for each instance of the class that you create.  However, for static data members, there is always just one copy of the static data for that class.  Since the data is associated with no particular instance of the class, all references to that static data work with the same copy.