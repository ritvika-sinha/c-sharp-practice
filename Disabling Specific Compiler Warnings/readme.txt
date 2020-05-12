uint x = 0x1234;

Due to above line, a warning appears in the Output window – CS0219: The variable ‘x’ is assigned but its value is never used.

If you’re aware of what this warning means, you don’t intend to change the source code to resolve it, and you want to no longer see the warning for this particular line, you can use the #pragma warning directive.  
Place the directive immediately above the offending line and reference warning #219.

You’ll no longer get warning #219 for this line when you compile.