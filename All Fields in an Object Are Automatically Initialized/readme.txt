All Fields in an Object Are Automatically Initialized

When you declare an instance of a value type without initializing it, the compiler prevents you from referencing the uninitialized variable.
=> see region 1

If you declare and instantiate a reference type, the internal fields and properties are all initialized by setting all of the bits of the underlying memory for each item to 0.  This equates to:

Reference types = null
Numeric types = 0
Enum types = 0
Char type =
Boolean type = false
This means that value types declared inside the object are automatically initialized when the object is created.