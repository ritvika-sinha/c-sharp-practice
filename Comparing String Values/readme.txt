The 'and' operators are not overloaded for the System.String type, which means that you can’t compare strings using the relational operators.

Instead, you can use the static System.String.Compare method, which takes two strings and returns an integer value.  

If the first string is less than the second, a negative number is returned. If the first string is greater, a positive number is returned.  
If the strings are equal, the return value is zero.