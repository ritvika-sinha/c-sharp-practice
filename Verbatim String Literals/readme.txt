Because the backslash (\) is the first character in an escape sequence, you need to use the double-backslash sequence (\\) to embed actual backslashes in a string literal.
(see string file1)

Because this can get a little hard to read, C# allows using the at sign (@) character to indicate a verbatim string literal–a string literal in which escape sequences should not be interpreted.

Using a verbatim string literal, we can write the earlier string without doubling the backslashes:
(see string file2)

We can also use a verbatim string literal to split a string across multiple lines in the source code, rather than embedding the \n escape sequence:
(see string address)

Verbatim string can also be used for including quotation marks in strings.
