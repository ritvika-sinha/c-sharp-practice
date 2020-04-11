Using the concatenation operator (+) for string concatenation is convenient, but can be inefficient because a new string is allocated for each concatenation.

In the first example,we are appending the string equivalents of the first 50,000 integers:

Note:
C# includes the Stopwatch class in the System.Diagnostics namespace, which can be used to accurately measure the time taken for code execution.

We can make this code more efficient by using the Append method of the StringBuilder class, which avoids allocating memory for the string on each iteration:

Conclusion: 
StringBuilder is definitely more efficient, but likely worth using only when you plan on doing a large number of string concatenations. 