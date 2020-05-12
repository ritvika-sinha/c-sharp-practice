If you have an array containing a collection of numeric values, you can get the average (mean) using the Average method.

The Average method is an extension method, applied to Array by virtue of its implementation of the IEnumerable interface.  
It’s part of the System.Linq namespace, so you’ll need a using statement for this namespace.  
Average is available in .NET 4 and 3.5.

Average will work for arrays containing any numeric type.